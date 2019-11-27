using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CourseWork.DBClasses
{
    public class SheduleDB
    {
        public int shedule_id { get; set; }
        public ClassDB classDB { get; set; }
        public TeacherDB teacher { get; set; }
        public SubjectDB subject { get; set; }
        public string day { get; set; }
        public int subjectOrdinal { get; set; }

        protected static SqlConnection sqlConnection = new SqlConnection(
            "Server=(local);" +
            "User ID=sa;" +
            "Password=sa;" +
            "DataBase=school;" +
            "MultipleActiveResultSets=True");

        public static List<SheduleDB> loadSheduleByTeacher(TeacherDB teacher)
        {
            List<SheduleDB> shedules = new List<SheduleDB>();
            List<ClassDB> classes = ClassDB.loadClasses();
            List<TeacherDB> teachers = TeacherDB.loadTeachers();
            List<SubjectDB> subjects = SubjectDB.loadSubjects();
            DataTable table = new DataTable();

            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
            string sqlQuery = "SELECT * FROM shedules where teacherId='" + teacher.teacher_id + "'";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    SheduleDB shedule = new SheduleDB();
                    shedule.shedule_id = Convert.ToInt32(dr[0]);
                    shedule.classDB = classes.Find(c => c.class_id == Convert.ToInt32(dr[1]));
                    shedule.teacher = teacher;
                    shedule.subject = subjects.Find(s => s.subject_id == Convert.ToInt32(dr[3]));
                    shedule.day = Convert.ToString(dr[4]);
                    shedule.subjectOrdinal = Convert.ToInt32(dr[5]);
                    shedules.Add(shedule);
                }
            }

            if (!opened)
                sqlConnection.Close(); return shedules;
        }

        public static List<SheduleDB> loadSheduleByClass(ClassDB classDB)
        {
            List<SheduleDB> shedules = new List<SheduleDB>();
            List<ClassDB> classes = ClassDB.loadClasses();
            List<TeacherDB> teachers = TeacherDB.loadTeachers();
            List<SubjectDB> subjects = SubjectDB.loadSubjects();
            DataTable table = new DataTable();

            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
            string sqlQuery = "SELECT * FROM shedules where classId='" + classDB.class_id + "'";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    SheduleDB shedule = new SheduleDB();
                    shedule.shedule_id = Convert.ToInt32(dr[0]);
                    shedule.classDB = classDB;
                    shedule.teacher = teachers.Find(t => t.teacher_id == Convert.ToInt32(dr[2])); ;
                    shedule.subject = subjects.Find(s => s.subject_id == Convert.ToInt32(dr[3]));
                    shedule.day = Convert.ToString(dr[4]);
                    shedule.subjectOrdinal = Convert.ToInt32(dr[5]);
                    shedules.Add(shedule);
                }
            }

            if (!opened)
                sqlConnection.Close(); return shedules;
        }
    }
}
