using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CourseWork.DBClasses
{
    class UserDB
    {
        public int user_id { get; protected set; }
        public string login { get; protected set; }
        public string password { get; protected set; }
        public int user_type { get; protected set; }
        public string fio { get; protected set; }
        public string sex { get; protected set; }
        public DateTime age { get; protected set; }
        public string internal_mail { get; protected set; }
        protected static SqlConnection sqlConnection = new SqlConnection(
            "Server=(local);" +
            "User ID=sa;" +
            "Password=sa;" +
            "DataBase=school");


        protected void addNewUserIntoDB(string login, string password, int user_type, string fio,
        string sex, DateTime age, string internal_mail)
        {
            sqlConnection.Open();
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
            sqlConnection.Close();
            this.login = login;
            this.password = password;
            this.user_type = user_type;
            this.fio = fio;
            this.sex = sex;
            this.age = age;
            this.internal_mail = internal_mail;
        }

        public static List<UserDB> loadUsers()
        {
            List<UserDB> users = new List<UserDB>();
            DataTable table = new DataTable();
            sqlConnection.Open();

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
            sqlConnection.Close();
            return users;
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
