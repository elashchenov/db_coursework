using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CourseWork.DBClasses
{
    public class ParentDB : UserDB
    {
        public int parent_id { get; set; }
        public List<PupleDB> puples { get; set; } = new List<PupleDB>();

        public ParentDB() { }

        public ParentDB(UserDB userDB) : base(userDB)
        {
            loadParentByUserId();
        }

        public void updateParentInDB(List<PupleDB> puplesForDelete, List<PupleDB> puplesForAdd)
        {
            UpdateUserInDB();
            string idForDelete = string.Empty;
            foreach (PupleDB puple in puplesForDelete) {
                puples.Remove(puple);
                idForDelete += puple.puple_id + ", ";
            }
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
            if (idForDelete.Count() != 0) {
                idForDelete = idForDelete.Substring(0, idForDelete.Count() - 2);
                
                string sqlQuery = "delete from puples_parents " +
                    "where parentId='" + parent_id + "' and pupleId in (" + idForDelete + ")";
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
                cmd.ExecuteNonQuery();
            }

            string valuesForAdd = string.Empty;
            foreach (PupleDB puple in puplesForAdd) {
                puples.Add(puple);
                valuesForAdd += "('" + puple.puple_id + "', '" + parent_id + "'),";
            }
            if (valuesForAdd.Count() != 0) {
                valuesForAdd = valuesForAdd.Substring(0, valuesForAdd.Count() - 1);
                string sqlQuery = "insert into puples_parents " +
                    "values" + valuesForAdd;
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
                cmd.ExecuteNonQuery();
            }

            if (!opened)
                sqlConnection.Close();
        }

        private void loadParentByUserId()
        {
            DataTable table = new DataTable();
            List<ClassDB> classes = ClassDB.loadClasses();

            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
            string sqlQuery = "select parents.id from parents " +
                "where parents.userId='" + user_id +"'";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read() == false) {
                    sqlConnection.Close();
                    throw new Exception("Такого родителя не существует");
                }
                this.parent_id = Convert.ToInt32(dr[0]);
            }

            table = new DataTable();
            sqlQuery = "select puples.userId, puples.id, puples.classId from puples_parents, puples " +
                "where puples_parents.parentId='" + parent_id + "' and puples_parents.pupleId=puples.id";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    int userId = Convert.ToInt32(dr[0]);
                    PupleDB puple = new PupleDB();
                    puple.loadByUserId(userId);
                    puple.puple_id = Convert.ToInt32(dr[1]);
                    puple.classDB = classes.Find(p => p.class_id == Convert.ToInt32(dr[2]));
                    puples.Add(puple);
                }
            }

            if (!opened)
                sqlConnection.Close();
        }

        public void addNewParentIntoDB(string login, string password, string fio,
        string sex, DateTime age, string internal_mail, List<PupleDB> puples)
        {
            addNewUserIntoDB(login, password, 2, fio, sex, age, internal_mail);
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
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
            if (!opened)
                sqlConnection.Close(); this.puples = puples;
        }

        public static List<ParentDB> loadParents()
        {
            List<ParentDB> parents = new List<ParentDB>();
            DataTable table = new DataTable();
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
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

            if (!opened)
                sqlConnection.Close(); return parents;
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
