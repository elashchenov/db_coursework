using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CourseWork.DBClasses
{
    class TeacherDB : UserDB
    {
        public int teacher_id { get; private set; }
        public ClassDB classDB { get; private set; }
        public List<SubjectDB> subjects { get; private set; }

        public void addNewTeacherIntoDB(string login, string password, string fio,
        string sex, DateTime age, string internal_mail, ClassDB classDB, List<SubjectDB> subjects)
        {
            addNewUserIntoDB(login, password, 0, fio, sex, age, internal_mail);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("AddNewTeacher", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@addedUserId", user_id));
            cmd.Parameters.Add(new SqlParameter("@classId", classDB.class_id));
            cmd.Parameters.Add(new SqlParameter("@teacherId", SqlDbType.Int)).Direction = ParameterDirection.Output;

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            foreach (SubjectDB sbj in subjects)
                dt.Rows.Add(new object[]{sbj.subject_id});
            var param = cmd.Parameters.AddWithValue("@subjectId", dt);
            param.SqlDbType = SqlDbType.Structured;

            cmd.ExecuteNonQuery();
            this.teacher_id = Convert.ToInt32(cmd.Parameters["@teacherId"].Value);
            sqlConnection.Close();
            this.classDB = classDB;
            this.subjects = subjects;
        }

        public static List<TeacherDB> loadTeachers()
        {
            List<TeacherDB> teachers = new List<TeacherDB>();
            DataTable table = new DataTable();
            sqlConnection.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM TeachersFullTable", sqlConnection)) {
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
                    teacher.classDB = ClassDB.loadClasses().Find(c => c.class_id == Convert.ToInt32(dr[9])); ;
                    teachers.Add(teacher);
                }

            }

            sqlConnection.Close();
            return teachers;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as TeacherDB);
        }

        public bool Equals(TeacherDB other)
        {
            return other != null && teacher_id == other.teacher_id;
        }

        public override int GetHashCode()
        {
            return teacher_id.GetHashCode();
        }
    }
}
