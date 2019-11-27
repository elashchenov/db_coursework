using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Globalization;

namespace CourseWork.DBClasses
{
    public class AnswerDB
    {
        public int answer_id { get; set; }
        public TeacherDB teacher { get; set; }
        public SubjectDB subject { get; set; }
        public PupleDB puple { get; set; }
        public HomeworkDB homework { get; set; }
        public string pupleNote { get; set; }
        public List<string> homework_attachments { get; set; } = new List<string>();
        public List<int> homework_attachments_id { get; set; } = new List<int>();
        protected static SqlConnection sqlConnection = new SqlConnection(
            "Server=(local);" +
            "User ID=sa;" +
            "Password=sa;" +
            "DataBase=school");

        public void addNewAnswer(TeacherDB teacher, SubjectDB subject, PupleDB puple, HomeworkDB homework,
            string pupleNote, List<string> filePaths, List<string> fileNames)
        {
            List<AnswerDB> answers = AnswerDB.loadAnswers();
            if (answers.Any(p => (p.teacher.teacher_id == teacher.teacher_id) &&
            (p.subject.subject_id == subject.subject_id) &&
            (p.puple.puple_id == puple.puple_id) &&
            (p.homework.homework_id == homework.homework_id))) {
                throw new Exception("Ответ на это домашнее задание вы уже отправляли");
            }
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
            SqlCommand cmd = new SqlCommand("AddNewAnswer", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@teacherId", teacher.teacher_id));
            cmd.Parameters.Add(new SqlParameter("@subjectId", subject.subject_id));
            cmd.Parameters.Add(new SqlParameter("@pupleId", puple.puple_id));
            cmd.Parameters.Add(new SqlParameter("@homeworkId", homework.homework_id));
            cmd.Parameters.Add(new SqlParameter("@pupleNote", pupleNote));
            cmd.Parameters.Add(new SqlParameter("@answerId", SqlDbType.Int)).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            this.answer_id = Convert.ToInt32(cmd.Parameters["@answerId"].Value);
            if (!opened)
                sqlConnection.Close();
            this.teacher = teacher;
            this.subject = subject;
            this.puple = puple;
            this.homework = homework;

            for (int i = 0; i < filePaths.Count(); i++) {
                databaseFilePut(filePaths[i], fileNames[i]);
            }
        }

        public void deleteAnswer()
        {
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
            string sqlQuery = "delete from homework_attachments where answerId='" + answer_id + "'";
            using (var sqlWrite = new SqlCommand(sqlQuery, sqlConnection)) {
                sqlWrite.ExecuteNonQuery();
            }

            sqlQuery = "delete from answers where id='" + answer_id + "'";
            using (var sqlWrite = new SqlCommand(sqlQuery, sqlConnection)) {
                sqlWrite.ExecuteNonQuery();
            }
            if (!opened)
                sqlConnection.Close();
        }

        public void databaseFilePut(string varFilePath, string filename)
        {
            byte[] file;
            using (var stream = new FileStream(varFilePath, FileMode.Open, FileAccess.Read)) {
                using (var reader = new BinaryReader(stream)) {
                    file = reader.ReadBytes((int)stream.Length);
                }
            }
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
            string sqlQuery = "INSERT INTO homework_attachments " +
                "Values('"+ answer_id + "', '" + filename +"', '" + Path.GetExtension(varFilePath) + "', @File)";
            using (var sqlWrite = new SqlCommand(sqlQuery, sqlConnection)) {
                sqlWrite.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file;
                sqlWrite.ExecuteNonQuery();
            }
            if (!opened)
                sqlConnection.Close();
        }

        public void databaseFileRead(string varPathToNewLocation)
        {
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }
            using (var sqlQuery = new SqlCommand(@"SELECT attached_file FROM homework_attachments WHERE answerId='" + answer_id + "'", sqlConnection)) {
                sqlQuery.Parameters.AddWithValue("@answerId", answer_id);
                using (var sqlQueryResult = sqlQuery.ExecuteReader())
                    if (sqlQueryResult != null) {
                        sqlQueryResult.Read();
                        var blob = new Byte[(sqlQueryResult.GetBytes(0, 0, null, 0, int.MaxValue))];
                        sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length);
                        using (var fs = new FileStream(varPathToNewLocation, FileMode.Create, FileAccess.Write))
                            fs.Write(blob, 0, blob.Length);
                    }
            }
            if (!opened)
                sqlConnection.Close();
        }

        public static List<AnswerDB> loadAnswers()
        {
            List<AnswerDB> answers = new List<AnswerDB>();
            DataTable table = new DataTable();
            List<TeacherDB> teachers = TeacherDB.loadTeachers();
            List<SubjectDB> subjects = SubjectDB.loadSubjects();
            List<PupleDB> puples = PupleDB.loadPuples();
            List<HomeworkDB> homeworks = HomeworkDB.loadHomeworks();
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }

            using (SqlCommand command = new SqlCommand("SELECT * FROM answers", sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    AnswerDB answer = new AnswerDB();
                    answer.answer_id = Convert.ToInt32(dr[0]);
                    answer.teacher = teachers.Find(p => p.teacher_id == Convert.ToInt32(dr[1]));
                    answer.subject = subjects.Find(p => p.subject_id == Convert.ToInt32(dr[2]));
                    answer.puple = puples.Find(p => p.puple_id == Convert.ToInt32(dr[3]));
                    answer.homework = homeworks.Find(p => p.homework_id == Convert.ToInt32(dr[4]));
                    answer.pupleNote = Convert.ToString(dr[5]);
                    answers.Add(answer);
                }

            }
            if (!opened)
                sqlConnection.Close();
            foreach (AnswerDB answer in answers)
                answer.loadAttachments();
            return answers;
        }

        private void loadAttachments()
        {
            DataTable table = new DataTable();
            bool opened = true;
            if (sqlConnection.State == ConnectionState.Closed) {
                sqlConnection.Open();
                opened = false;
            }

            string sqlQuery = "SELECT id, filename, ext FROM homework_attachments where answerId='" + answer_id + "'";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection)) {
                table.Load(command.ExecuteReader());
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    string filename = Convert.ToString(dr[1]);
                    filename += Convert.ToString(dr[2]);
                    homework_attachments.Add(filename);
                    homework_attachments_id.Add(Convert.ToInt32(dr[0]));
                }
            }
            if (!opened)
                sqlConnection.Close();
        }

        public override string ToString()
        {
            return puple.fio.Trim() + " - " + puple.classDB.year + " " + puple.classDB.letter;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as AnswerDB);
        }

        public bool Equals(AnswerDB other)
        {
            return other != null && answer_id == other.answer_id;
        }

        public override int GetHashCode()
        {
            return answer_id.GetHashCode();
        }
    }
}
