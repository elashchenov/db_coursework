using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CourseWork.DBClasses
{
    class ClassDB
    {
        public int class_id { get; private set; }
        public int classTeacherId { get; private set; }
        public int quantity { get; private set; }
        public int year { get; private set; }
        public char letter { get; private set; }

        protected static SqlConnection sqlConnection = new SqlConnection(
            "Server=(local);" +
            "User ID=sa;" +
            "Password=sa;" +
            "DataBase=school");

        public static List<ClassDB> loadClasses()
        {
            List<ClassDB> classes = new List<ClassDB>();

            DataTable table = new DataTable();
            sqlConnection.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM classes", sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    ClassDB classDB = new ClassDB();
                    classDB.class_id = Convert.ToInt32(dr[0]);
                    classDB.classTeacherId = Convert.ToInt32(dr[1]);
                    classDB.quantity = Convert.ToInt32(dr[2]);
                    classDB.year = Convert.ToInt32(dr[3]);
                    classDB.letter = Convert.ToChar(dr[4]);
                    classes.Add(classDB);
                }
            }

            sqlConnection.Close();
            return classes;
        }

        public override string ToString()
        {
            return year.ToString() + " " + letter;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ClassDB);
        }

        public bool Equals(ClassDB other)
        {
            return other != null && class_id == other.class_id;
        }

        public override int GetHashCode()
        {
            return class_id.GetHashCode();
        }
    }
}
