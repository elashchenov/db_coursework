using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CourseWork.DBClasses
{

    public class SubjectDB
    {
        public int subject_id { get; set; }
        public string name { get; set; }
        protected static SqlConnection sqlConnection = new SqlConnection(
            "Server=(local);" +
            "User ID=sa;" +
            "Password=sa;" +
            "DataBase=school");

        public static List<SubjectDB> loadSubjects()
        {
            List<SubjectDB> subjects = new List<SubjectDB>();
            DataTable table = new DataTable();
            sqlConnection.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM subjects", sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    SubjectDB subject = new SubjectDB();
                    subject.subject_id = Convert.ToInt32(dr[0]);
                    subject.name = Convert.ToString(dr[1]);
                    subjects.Add(subject);
                }

            }
            sqlConnection.Close();
            return subjects;
        }

        public override string ToString()
        {
            return name;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as SubjectDB);
        }

        public bool Equals(SubjectDB other)
        {
            return other != null && subject_id == other.subject_id;
        }

        public override int GetHashCode()
        {
            return subject_id.GetHashCode();
        }
    }

    
}
