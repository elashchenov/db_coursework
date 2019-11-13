using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signinform = new SignInForm();
            signinform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection("Provider=SQLNCLI11; Data Source=localhost;Persist Security Info=True;User ID=sa;Password=1234;Initial Catalog=school");

            OleDbDataAdapter adapter = new OleDbDataAdapter();

            OleDbCommand command = new OleDbCommand("INSERT INTO logins (login,password) Values ('" +loginBox.Text+"','" + passBox.Text + "')", connection);

            try
            {
                connection.Open();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Coonected failed!");
            }

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Пользователь добавлен !");
            else
                MessageBox.Show("Пользователь не добавлен !");




            connection.Close();
        }
    }
}
