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

        public static List<TeacherDB> loadTeachersBySubjectId(int subjectId)
        {
            DataTable table = new DataTable();
            List<ClassDB> classes = ClassDB.loadClasses();
            sqlConnection.Open();
            List<TeacherDB> teachers = new List<TeacherDB>();

            string sqlQuery = "select user_id, login, password, user_type," +
                " fio, sex, age, internal_mail, teacher_id " +
                "from TeachersFullTable, teachers_subjects " +
                "where teachers_subjects.subjectId='" + subjectId + "'" +
                " and TeachersFullTable.teacher_id=teachers_subjects.teacherId";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    TeacherDB teacher = new TeacherDB();
                    teacher.user_id = Convert.ToInt32(dr[0]);
                    teacher.login = Convert.ToString(dr[1]);
                    teacher.password = Convert.ToString(dr[2]);
                    teacher.user_type = Convert.ToInt32(dr[3]);
                    teacher.fio = Convert.ToString(dr[4]);
                    teacher.sex = Convert.ToString(dr[5]);
                    teacher.age = Convert.ToDateTime(dr[6]);
                    teacher.internal_mail = Convert.ToString(dr[7]);
                    teacher.teacher_id = Convert.ToInt32(dr[8]);
                    teacher.classDB = classes.Find(c => c.class_id == teacher.teacher_id); ;
                    teachers.Add(teacher);
                }
            }

            sqlConnection.Close();

            return teachers;
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
