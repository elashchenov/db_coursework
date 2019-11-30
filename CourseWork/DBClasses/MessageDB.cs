using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CourseWork.DBClasses
{
    public class MessageDB
    {
        public int message_id { get; set; }
        public UserDB sender { get; set; }
        public UserDB recipient { get; set; }
        public string message { get; set; }
        public DateTime time { get; set; }
        public int readState { get; set; }

        protected static SqlConnection sqlConnection = new SqlConnection(
            "Server=(local);" +
            "User ID=sa;" +
            "Password=sa;" +
            "DataBase=school;" +
            "MultipleActiveResultSets=True");

        public void addNewMessage(UserDB sender, UserDB recipient, string message)
        {
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
            SqlCommand cmd = new SqlCommand("AddNewMessage", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@senderId", sender.user_id));
            cmd.Parameters.Add(new SqlParameter("@recipientId", recipient.user_id));
            cmd.Parameters.Add(new SqlParameter("@message", message));
            cmd.Parameters.Add(new SqlParameter("@messageId", SqlDbType.Int)).Direction = ParameterDirection.Output;
            cmd.Parameters.Add(new SqlParameter("@time", SqlDbType.DateTime)).Direction = ParameterDirection.Output;
            cmd.Parameters.Add(new SqlParameter("@readState", SqlDbType.Int)).Direction = ParameterDirection.Output;


            cmd.ExecuteNonQuery();

            this.message_id = Convert.ToInt32(cmd.Parameters["@messageId"].Value);
            this.time = Convert.ToDateTime(cmd.Parameters["@time"].Value);
            this.readState = Convert.ToInt32(cmd.Parameters["@readState"].Value);
            if (!opened)
                sqlConnection.Close();
            this.sender = sender;
            this.recipient = recipient;
            this.message = message;
        }

        public static List<UserDB> loadChatUsers(UserDB sender)
        {
            List<UserDB> chatUsers = new List<UserDB>();
            List<UserDB> users = UserDB.loadUsers();
            DataTable table = new DataTable();
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }

            string sqlQuery = "SELECT distinct recipientId FROM chats where senderId='" + sender.user_id + "'" +
                "union SELECT distinct senderId FROM chats where recipientId='" + sender.user_id + "'";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    chatUsers.Add(users.Find(p => p.user_id == Convert.ToInt32(dr[0])));
                }
            }
            if (!opened)
                sqlConnection.Close();
            chatUsers.Remove(sender);
            return chatUsers;
        }

        public static List<MessageDB> loadTopChatMessages(UserDB sender)
        {
            List<MessageDB> topMessages = new List<MessageDB>();
            List<UserDB> users = loadChatUsers(sender);
            List<UserDB> allUsers = UserDB.loadUsers();
            DataTable table = new DataTable();
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }

            foreach (UserDB recipient in users) {
                string sqlQuery = "SELECT * FROM chats where senderId='" + sender.user_id + "'" +
                    "and recipientId='" + recipient.user_id + "' " +
                    "union " + "SELECT * FROM chats where senderId = '" + recipient.user_id + "'" +
                    "and recipientId='" + sender.user_id + "'" +
                    " order by time desc";
                using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection)) {
                    table.Load(command.ExecuteReader());
                    SqlDataReader dr = command.ExecuteReader();
                    dr.Read();
                    MessageDB message = new MessageDB();
                    message.message_id = Convert.ToInt32(dr[0]);
                    message.sender = allUsers.Find(p => p.user_id == Convert.ToInt32(dr[1]));
                    message.recipient = allUsers.Find(p => p.user_id == Convert.ToInt32(dr[2]));
                    message.message = Convert.ToString(dr[3]);
                    message.time = Convert.ToDateTime(dr[4]);
                    message.readState = Convert.ToInt32(dr[5]);
                    topMessages.Add(message);
                }
            }

            if (!opened)
                sqlConnection.Close();
            return topMessages;
        }

        public static List<MessageDB> loadMessagesForChat(UserDB first, UserDB second)
        {
            List<MessageDB> messages = new List<MessageDB>();
            List<UserDB> allUsers = UserDB.loadUsers();
            DataTable table = new DataTable();
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }

            string sqlQuery = "SELECT * FROM chats where senderId='" + first.user_id + "'" +
                "and recipientId='" + second.user_id + "' " +
                "union " + "SELECT * FROM chats where senderId = '" + second.user_id + "'" +
                "and recipientId='" + first.user_id + "'" +
                " order by time desc";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    MessageDB message = new MessageDB();
                    message.message_id = Convert.ToInt32(dr[0]);
                    message.sender = allUsers.Find(p => p.user_id == Convert.ToInt32(dr[1]));
                    message.recipient = allUsers.Find(p => p.user_id == Convert.ToInt32(dr[2]));
                    message.message = Convert.ToString(dr[3]);
                    message.time = Convert.ToDateTime(dr[4]);
                    message.readState = Convert.ToInt32(dr[5]);
                    messages.Add(message);
                }
            }

            if (!opened)
                sqlConnection.Close();
            return messages;
        }

        public static int getUnreadCount(UserDB recipient, UserDB sender)
        {
            int unread = 0;

            DataTable table = new DataTable();
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }

            string sqlQuery = "SELECT count(*) FROM chats where senderId='" + recipient.user_id + "'" +
                " and recipientId='" + sender.user_id + "' and readState=0";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read()) {
                    unread = Convert.ToInt32(dr[0]);
                }
            }
            if (!opened)
                sqlConnection.Close();

            return unread;
        }

        public static void markAsRead(UserDB recipient, UserDB sender)
        {
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
            string sqlQuery = "update chats set readState=1 where senderId='" + sender.user_id + "' and " +
                "recipientId='" + recipient.user_id + "'";
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);

            cmd.ExecuteNonQuery();
            if (!opened)
                sqlConnection.Close();
        }

        public static void deleteChatFromDB(UserDB first, UserDB second)
        {
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
            string sqlQuery = "delete from chats where " +
                "senderId='" + first.user_id + "' and recipientId='" + second.user_id + "' " +
                "or senderId='" + second.user_id + "' and recipientId='" + first.user_id + "'";
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);

            cmd.ExecuteNonQuery();
            if (!opened)
                sqlConnection.Close();
        }
    }
}
