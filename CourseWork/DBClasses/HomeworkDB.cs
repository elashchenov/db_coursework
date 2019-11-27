using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CourseWork.DBClasses
{
    public class HomeworkDB
    {
        public int homework_id { get; set; }
        public SubjectDB subject { get; set; }
        public ClassDB classDB { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        protected static SqlConnection sqlConnection = new SqlConnection(
            "Server=(local);" +
            "User ID=sa;" +
            "Password=sa;" +
            "DataBase=school;" +
            "MultipleActiveResultSets=True");

        public static List<HomeworkDB> loadHomeworks(SubjectDB subject, ClassDB classDB)
        {
            List<HomeworkDB> homeworks = new List<HomeworkDB>();
            DataTable table = new DataTable();
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
            string sqlQuery = "SELECT * FROM homeworks where homeworks.subjectId='" + subject.subject_id + "' and " +
                "homeworks.classId='" + classDB.class_id + "'";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    HomeworkDB homework = new HomeworkDB();
                    homework.homework_id = Convert.ToInt32(dr[0]);
                    homework.subject = subject;
                    homework.classDB = classDB;
                    homework.name = Convert.ToString(dr[3]);
                    homework.description = Convert.ToString(dr[4]);
                    homeworks.Add(homework);
                }

            }
            if (!opened)
                sqlConnection.Close(); return homeworks;
        }

        public static List<HomeworkDB> loadHomeworks()
        {
            List<HomeworkDB> homeworks = new List<HomeworkDB>();
            List<SubjectDB> subjects = SubjectDB.loadSubjects();
            List<ClassDB> classes = ClassDB.loadClasses();

            DataTable table = new DataTable();
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
            string sqlQuery = "SELECT * FROM homeworks";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    HomeworkDB homework = new HomeworkDB();
                    homework.homework_id = Convert.ToInt32(dr[0]);
                    homework.subject = subjects.Find(c => c.subject_id == Convert.ToInt32(dr[1]));
                    homework.classDB = classes.Find(c => c.class_id == Convert.ToInt32(dr[2]));
                    homework.name = Convert.ToString(dr[3]);
                    homework.description = Convert.ToString(dr[4]);
                    homeworks.Add(homework);
                }

            }
            if (!opened)
                sqlConnection.Close(); return homeworks;
        }

        public void addNewHomeworkIntoDB(SubjectDB subject, ClassDB classDB, string name, string description)
        {
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
            SqlCommand cmd = new SqlCommand("AddNewHomework", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@subjectId", subject.subject_id));
            cmd.Parameters.Add(new SqlParameter("@classId", classDB.class_id));
            cmd.Parameters.Add(new SqlParameter("@name", name));
            cmd.Parameters.Add(new SqlParameter("@description", description));
            cmd.Parameters.Add(new SqlParameter("@homeworkId", SqlDbType.Int)).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            this.homework_id = Convert.ToInt32(cmd.Parameters["@homeworkId"].Value);
            if (!opened)
                sqlConnection.Close();
            this.subject = subject;
            this.classDB = classDB;
            this.name = name;
            this.description = description;
        }

        public override string ToString()
        {
            return name;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as HomeworkDB);
        }

        public bool Equals(HomeworkDB other)
        {
            return other != null && homework_id == other.homework_id;
        }

        public override int GetHashCode()
        {
            return homework_id.GetHashCode();
        }

    }
}
