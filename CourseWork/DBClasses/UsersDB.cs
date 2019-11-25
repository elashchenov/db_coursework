using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Common;

namespace CourseWork.DBClasses
{
    public class UserDB
    {
        public int user_id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int user_type { get; set; }
        public string fio { get; set; }
        public string sex { get; set; }
        public DateTime age { get; set; }
        public string internal_mail { get; set; }
        protected static SqlConnection sqlConnection = new SqlConnection(
            "Server=(local);" +
            "User ID=sa;" +
            "Password=sa;" +
            "DataBase=school;" +
            "MultipleActiveResultSets=True");

        public UserDB(UserDB userDB)
        {
            this.user_id = userDB.user_id;
            this.login = userDB.login;
            this.password = userDB.password;
            this.user_type = userDB.user_type;
            this.fio = userDB.fio;
            this.sex = userDB.sex;
            this.age = userDB.age;
            this.internal_mail = userDB.internal_mail;
        }

        public UserDB() { }


        protected void addNewUserIntoDB(string login, string password, int user_type, string fio,
        string sex, DateTime age, string internal_mail)
        {
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
            SqlCommand cmd = new SqlCommand("AddNewUser", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@login", login));
            cmd.Parameters.Add(new SqlParameter("@password", password));
            cmd.Parameters.Add(new SqlParameter("@user_type", user_type));
            cmd.Parameters.Add(new SqlParameter("@fio", fio));
            cmd.Parameters.Add(new SqlParameter("@sex", sex));
            cmd.Parameters.Add(new SqlParameter("@age", age.ToString("yyyy-MM-dd")));
            cmd.Parameters.Add(new SqlParameter("@internal_mail", internal_mail));
            cmd.Parameters.Add(new SqlParameter("@userId", SqlDbType.Int)).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            this.user_id = Convert.ToInt32(cmd.Parameters["@userId"].Value);
            if (!opened)
                sqlConnection.Close();
            this.login = login;
            this.password = password;
            this.user_type = user_type;
            this.fio = fio;
            this.sex = sex;
            this.age = age;
            this.internal_mail = internal_mail;
        }

        public void loadByUserId(int userId)
        {
            DataTable table = new DataTable();
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }

            string sqlQuery = "select * from users where users.id='" + userId + "'";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read() == false) {
                    sqlConnection.Close();
                    throw new Exception("Неправильный логин или пароль");
                }
                this.user_id = Convert.ToInt32(dr[0]);
                this.login = Convert.ToString(dr[1]);
                this.password = Convert.ToString(dr[2]);
                this.user_type = Convert.ToInt32(dr[3]);
                this.fio = Convert.ToString(dr[4]);
                this.sex = Convert.ToString(dr[5]);
                this.age = Convert.ToDateTime(dr[6]);
                this.internal_mail = Convert.ToString(dr[7]);
            }
            if (!opened)
                sqlConnection.Close();
        }

        public void loadByLoginAndPassword(string login, string password)
        {
            DataTable table = new DataTable();
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }

            string sqlQuery = "select * from users where users.login='" + login + "' and users.password='" + password + "'";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read() == false) {
                    sqlConnection.Close();
                    throw new Exception("Неправильный логин или пароль");
                }
                this.user_id = Convert.ToInt32(dr[0]);
                this.login = Convert.ToString(dr[1]);
                this.password = Convert.ToString(dr[2]);
                this.user_type = Convert.ToInt32(dr[3]);
                this.fio = Convert.ToString(dr[4]);
                this.sex = Convert.ToString(dr[5]);
                this.age = Convert.ToDateTime(dr[6]);
                this.internal_mail = Convert.ToString(dr[7]);
            }
            if (!opened)
                sqlConnection.Close();
        }

        public static List<UserDB> loadUsers()
        {
            List<UserDB> users = new List<UserDB>();
            DataTable table = new DataTable();
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }

            using (SqlCommand command = new SqlCommand("SELECT * FROM users", sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    UserDB user = new UserDB();
                    user.user_id = Convert.ToInt32(dr[0]);
                    user.login = Convert.ToString(dr[1]);
                    user.password = Convert.ToString(dr[2]);
                    user.user_type = Convert.ToInt32(dr[3]);
                    user.fio = Convert.ToString(dr[4]);
                    user.sex = Convert.ToString(dr[5]);
                    user.age = Convert.ToDateTime(dr[6]);
                    user.internal_mail = Convert.ToString(dr[7]);
                    users.Add(user);
                }

            }
            if (!opened)
                sqlConnection.Close();
            return users;
        }

        public void UpdateUserInDB()
        {
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
            SqlCommand cmd = new SqlCommand("UpdateUser", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@userId", user_id));
            cmd.Parameters.Add(new SqlParameter("@login", login));
            cmd.Parameters.Add(new SqlParameter("@password", password));
            cmd.Parameters.Add(new SqlParameter("@fio", fio));
            cmd.Parameters.Add(new SqlParameter("@sex", sex));
            cmd.Parameters.Add(new SqlParameter("@age", age.ToString("yyyy-MM-dd")));
            cmd.Parameters.Add(new SqlParameter("@internal_mail", internal_mail));

            cmd.ExecuteNonQuery();
            if (!opened)
                sqlConnection.Close();
        }

        public override string ToString()
        {
            return fio.Trim() + " - " + internal_mail.Trim();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as UserDB);
        }

        public bool Equals(UserDB other)
        {
            return other != null && user_id == other.user_id;
        }

        public override int GetHashCode()
        {
            return user_id.GetHashCode();
        }
    }
}
