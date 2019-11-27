using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CourseWork.DBClasses
{
    public class MarkDB
    {
        public int mark_id { get; set; } = -1;
        public PupleDB puple { get; set; }
        public SubjectDB subject { get; set; }
        public string workType { get; set; }
        public string workName { get; set; }
        public int mark { get; set; }
        public string teacherNote { get; set; }

        protected static SqlConnection sqlConnection = new SqlConnection(
            "Server=(local);" +
            "User ID=sa;" +
            "Password=sa;" +
            "DataBase=school");

        public void addNewMark()
        {
            addNewMark(puple, subject, workType, workName, mark, teacherNote);
        }

        public void addNewMark(PupleDB puple, SubjectDB subject, string workType, string workName, int mark, string teacherNote)
        {

            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
            SqlCommand cmd = new SqlCommand("AddNewMark", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@pupleId", puple.puple_id));
            cmd.Parameters.Add(new SqlParameter("@subjectId", subject.subject_id));
            cmd.Parameters.Add(new SqlParameter("@workType", workType));
            cmd.Parameters.Add(new SqlParameter("@workName", workName));
            cmd.Parameters.Add(new SqlParameter("@mark", mark));
            cmd.Parameters.Add(new SqlParameter("@teacherNote", teacherNote));
            cmd.Parameters.Add(new SqlParameter("@markId", SqlDbType.Int)).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            this.mark_id = Convert.ToInt32(cmd.Parameters["@markId"].Value);
            if (!opened)
                sqlConnection.Close();
            this.puple = puple;
            this.subject = subject;
            this.workType = workType;
            this.workName = workName;
            this.mark = mark;
            this.teacherNote = teacherNote;
        }

        public void UpdateMarkInDB()
        {
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }

            string sqlQuery = "update marks " +
                "set pupleId=@pupleId, subjectId=@subjectId, workType=@workType, " +
                "workName=@workName, mark=@mark, teacherNote=@teacherNote where marks.id='" + mark_id + "'";
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);

            cmd.Parameters.Add(new SqlParameter("@pupleId", puple.puple_id));
            cmd.Parameters.Add(new SqlParameter("@subjectId", subject.subject_id));
            cmd.Parameters.Add(new SqlParameter("@workType", workType));
            cmd.Parameters.Add(new SqlParameter("@workName", workName));
            cmd.Parameters.Add(new SqlParameter("@mark", mark));
            cmd.Parameters.Add(new SqlParameter("@teacherNote", teacherNote));

            cmd.ExecuteNonQuery();
            if (!opened)
                sqlConnection.Close();
        }

        public void deleteMark()
        {
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }

            string sqlQuery = "delete marks where marks.id='" + mark_id + "'";
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);

            cmd.ExecuteNonQuery();
            if (!opened)
                sqlConnection.Close();
        }


        public static List<MarkDB> loadMarks()
        {
            List<MarkDB> marks = new List<MarkDB>();
            DataTable table = new DataTable();
            List<PupleDB> puples = PupleDB.loadPuples();
            List<SubjectDB> subjects = SubjectDB.loadSubjects();

            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
            using (SqlCommand command = new SqlCommand("SELECT * FROM marks", sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    MarkDB mark = new MarkDB();
                    mark.mark_id = Convert.ToInt32(dr[0]);
                    mark.puple = puples.Find(p => p.puple_id == Convert.ToInt32(dr[1]));
                    mark.subject = subjects.Find(s => s.subject_id == Convert.ToInt32(dr[2]));
                    mark.workType = Convert.ToString(dr[3]);
                    mark.workName = Convert.ToString(dr[4]);
                    mark.mark = Convert.ToInt32(dr[5]);
                    mark.teacherNote = Convert.ToString(dr[6]);
                    marks.Add(mark);
                }
            }

            if (!opened)
                sqlConnection.Close(); return marks;
        }
    }
}
