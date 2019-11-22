using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CourseWork.DBClasses
{
    class PupleDB : UserDB
    {
        public int puple_id { get; private set; }
        public ClassDB classDB { get; private set; }
        public List<ParentDB> parents { get; private set; }

        public void addNewPupleIntoDB(string login, string password, string fio,
        string sex, DateTime age, string internal_mail, ClassDB classDB, List<ParentDB> parents)
        {
            addNewUserIntoDB(login, password, 1, fio, sex, age, internal_mail);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("AddNewPuple", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@addedUserId", user_id));
            cmd.Parameters.Add(new SqlParameter("@classId", classDB.class_id));
            cmd.Parameters.Add(new SqlParameter("@pupleId", SqlDbType.Int)).Direction = ParameterDirection.Output;

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            foreach (ParentDB parent in parents)
                dt.Rows.Add(new object[] { parent.parent_id });
            var param = cmd.Parameters.AddWithValue("@parentId", dt);
            param.SqlDbType = SqlDbType.Structured;

            cmd.ExecuteNonQuery();
            this.puple_id = Convert.ToInt32(cmd.Parameters["@pupleId"].Value);
            sqlConnection.Close();
            this.classDB = classDB;
            this.parents = parents;
        }

        public static List<PupleDB> loadPuples()
        {
            List<PupleDB> puples = new List<PupleDB>();
            DataTable table = new DataTable();
            sqlConnection.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM PuplesFullTable", sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    PupleDB puple = new PupleDB();
                    puple.user_id = Convert.ToInt32(dr[0]);
                    puple.login = Convert.ToString(dr[1]);
                    puple.password = Convert.ToString(dr[2]);
                    puple.user_type = Convert.ToInt32(dr[3]);
                    puple.fio = Convert.ToString(dr[4]);
                    puple.sex = Convert.ToString(dr[5]);
                    puple.age = Convert.ToDateTime(dr[6]);
                    puple.internal_mail = Convert.ToString(dr[7]);
                    puple.puple_id = Convert.ToInt32(dr[8]);
                    puple.classDB = ClassDB.loadClasses().Find(c => c.class_id == Convert.ToInt32(dr[9]));
                    puples.Add(puple);
                }

            }

            sqlConnection.Close();
            return puples;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as PupleDB);
        }

        public bool Equals(PupleDB other)
        {
            return other != null && puple_id == other.puple_id;
        }

        public override int GetHashCode()
        {
            return puple_id.GetHashCode();
        }
    }
}
