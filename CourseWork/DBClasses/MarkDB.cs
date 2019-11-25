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
        public int mark_id { get; set; }
        public PupleDB puple { get; set; }
        public SubjectDB subject { get; set; }
        public string workType { get; set; }
        public int mark { get; set; }
        public string teacherNote { get; set; }


        protected static SqlConnection sqlConnection = new SqlConnection(
            "Server=(local);" +
            "User ID=sa;" +
            "Password=sa;" +
            "DataBase=school");

        public void addNewMark(PupleDB puple, SubjectDB subject, string workType, int mark, string teacherNote)
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
            this.mark = mark;
            this.teacherNote = teacherNote;
        }
    }
}
