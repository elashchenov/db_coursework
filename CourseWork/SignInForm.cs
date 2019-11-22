using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CourseWork
{
    public partial class SignInForm : Form
    {
        public static SignInForm instance_ { get; private set; }
        public SignInForm()
        {
            InitializeComponent();
            instance_ = this;
        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {

            String loginUser = login_tb.Text;
            String passUser = pass_tb.Text;


            OleDbConnection connection = new OleDbConnection("Provider = SQLNCLI11; Data Source = localhost; Persist Security Info = True; Password = sa; User ID = sa; Initial Catalog = school");
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataTable table = new DataTable();
            //DataSet dataset = new DataSet();

            OleDbCommand command = new OleDbCommand("Select * FROM logins Where login = '" + loginUser + "' AND password ='" + passUser + "'", connection);
            //command.Parameters.Add("@ul",OleDbType.VarChar).Value=loginUser;

            //OleDbParameter nameParam = new OleDbParameter("@ul", loginUser);

            //command.Parameters.Add(nameParam);

            //command.Parameters.Add("@up", OleDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            //dataset.Tables.Add(table);
            //adapter.Fill(table);
            //WHERE login = loginUser AND password = passUser

            try
            {
                connection.Open();
                //MessageBox.Show("Coonected!");
            }
            catch (Exception)
            {
                MessageBox.Show("Coonected failed!");
            }

            if (/*table.Rows.Count > 0*/true)
            {
                this.Hide();
                MainForm mainForm = new MainForm(this);
                mainForm.Show();
            }
            else MessageBox.Show("Нет такого пользователя !");




            connection.Close();

        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registerForm = new RegistrationForm();
            registerForm.Show();

            
        }

        
    }
}
