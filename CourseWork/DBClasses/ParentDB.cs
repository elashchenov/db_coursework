using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CourseWork.DBClasses
{
    class ParentDB : UserDB
    {
        public int parent_id { get; private set; }
        public List<PupleDB> puples { get; private set; }

        public void addNewParentIntoDB(string login, string password, string fio,
        string sex, DateTime age, string internal_mail, List<PupleDB> puples)
        {
            addNewUserIntoDB(login, password, 2, fio, sex, age, internal_mail);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("AddNewParent", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@addedUserId", user_id));
            cmd.Parameters.Add(new SqlParameter("@parentId", SqlDbType.Int)).Direction = ParameterDirection.Output;

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            foreach (PupleDB puple in puples)
                dt.Rows.Add(new object[] { puple.puple_id });
            var param = cmd.Parameters.AddWithValue("@pupleId", dt);
            param.SqlDbType = SqlDbType.Structured;

            cmd.ExecuteNonQuery();
            this.parent_id = Convert.ToInt32(cmd.Parameters["@parentId"].Value);
            sqlConnection.Close();
            this.puples = puples;
        }

        public static List<ParentDB> loadParents()
        {
            List<ParentDB> parents = new List<ParentDB>();
            DataTable table = new DataTable();
            sqlConnection.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM ParentsFullTable", sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    ParentDB parent = new ParentDB();
                    parent.user_id = Convert.ToInt32(dr[0]);
                    parent.login = Convert.ToString(dr[1]);
                    parent.password = Convert.ToString(dr[2]);
                    parent.user_type = Convert.ToInt32(dr[3]);
                    parent.fio = Convert.ToString(dr[4]);
                    parent.sex = Convert.ToString(dr[5]);
                    parent.age = Convert.ToDateTime(dr[6]);
                    parent.internal_mail = Convert.ToString(dr[7]);
                    parent.parent_id = Convert.ToInt32(dr[8]);
                    parents.Add(parent);
                }

            }

            sqlConnection.Close();
            return parents;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ParentDB);
        }

        public bool Equals(ParentDB other)
        {
            return other != null && parent_id == other.parent_id;
        }

        public override int GetHashCode()
        {
            return parent_id.GetHashCode();
        }
    }
}
