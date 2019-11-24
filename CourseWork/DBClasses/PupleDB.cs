using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace CourseWork.DBClasses
{
    public class PupleDB : UserDB
    {
        public int puple_id { get; set; }
        public ClassDB classDB { get; set; }
        public List<ParentDB> parents { get; set; } = new List<ParentDB>();

        public PupleDB() { }

        public PupleDB(UserDB userDB) : base(userDB)
        {
            loadPupleByUserId();
        }

        public void updatePupleInDB(List<ParentDB> parentsForDelete, List<ParentDB> parentsForAdd)
        {
            UpdateUserInDB();
            string idForDelete = string.Empty;
            foreach (ParentDB parent in parentsForDelete) {
                parents.Remove(parent);
                idForDelete += parent.parent_id + ", ";
            }
            sqlConnection.Open();

            if (idForDelete.Count() != 0) {

                idForDelete = idForDelete.Substring(0, idForDelete.Count() - 2);

                string sqlQuery = "delete from puples_parents " +
                    "where pupleId='" + puple_id + "' and parentId in (" + idForDelete + ")";
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
                cmd.ExecuteNonQuery();
            }

            string valuesForAdd = string.Empty;
            foreach (ParentDB parent in parentsForAdd) {
                parents.Add(parent);
                valuesForAdd += "('" + puple_id + "', '" + parent.parent_id + "'),";
            }
            if (valuesForAdd.Count() != 0) {

                valuesForAdd = valuesForAdd.Substring(0, valuesForAdd.Count() - 1);
                string sqlQuery = "insert into puples_parents " +
                    "values" + valuesForAdd;
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
                cmd.ExecuteNonQuery();
            }

            sqlConnection.Close();
        }

        private void loadPupleByUserId()
        {
            DataTable table = new DataTable();
            sqlConnection.Open();

            string sqlQuery = "select puples.id, classes.id, classes.classTeacherId," +
                "classes.quantity, classes.year, classes.letter" +
                " from puples, classes " +
                "where puples.classId=classes.id and puples.userId='" + user_id +"'";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read() == false) {
                    sqlConnection.Close();
                    throw new Exception("Такого ученика не существует");
                }
                this.puple_id = Convert.ToInt32(dr[0]);
                ClassDB classDB = new ClassDB();
                classDB.class_id = Convert.ToInt32(dr[1]);
                classDB.classTeacherId = Convert.ToInt32(dr[2]);
                classDB.quantity = Convert.ToInt32(dr[3]);
                classDB.year = Convert.ToInt32(dr[4]);
                classDB.letter = Convert.ToChar(dr[5]);
                this.classDB = classDB;
            }

            table = new DataTable();
            sqlQuery = "select parents.userId, parents.id from puples_parents, parents " +
                "where puples_parents.pupleId='" + puple_id + "' and puples_parents.parentId=parents.id";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    int userId = Convert.ToInt32(dr[0]);
                    ParentDB parent = new ParentDB();
                    parent.loadByUserId(userId);
                    parent.parent_id = Convert.ToInt32(dr[1]);
                    parents.Add(parent);
                }
            }

            sqlConnection.Close();
        }

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
