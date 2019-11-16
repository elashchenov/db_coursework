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
            //OleDbConnection connection = new OleDbConnection("Provider=SQLNCLI11; Data Source=localhost;Persist Security Info=True;User ID=sa;Password=1234;Initial Catalog=school");

            //OleDbDataAdapter adapter = new OleDbDataAdapter();

            //OleDbCommand command = new OleDbCommand("INSERT INTO logins (login,password) Values ('" +loginBox.Text+"','" + passBox.Text + "')", connection);

            //try
            //{
            //    connection.Open();

            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Coonected failed!");
            //}

            //if (command.ExecuteNonQuery() == 1)
            //    MessageBox.Show("Пользователь добавлен !");
            //else
            //    MessageBox.Show("Пользователь не добавлен !");




            //connection.Close();

            PupilForm pupilForm = new PupilForm();

            String a = comboBox1.Text;
            tableLayoutPanel2.ColumnStyles[0].SizeType = SizeType.Percent;
            tableLayoutPanel2.ColumnStyles[1].SizeType = SizeType.Percent;
            tableLayoutPanel2.ColumnStyles[2].SizeType = SizeType.Percent;
            tableLayoutPanel2.ColumnStyles[3].SizeType = SizeType.Percent;
            
            switch (a)
            {
                case "Учитель":
                    tableLayoutPanel2.ColumnStyles[0].Width = 0;
                    tableLayoutPanel2.ColumnStyles[1].Width = 100;
                    button2.Size = new Size(110,60);
                    button3.Size = new Size(110, 60);
                    NameBox.Hide();
                    break;



                case "Ученик":
                    tableLayoutPanel2.ColumnStyles[0].Width = 0;
                    tableLayoutPanel2.ColumnStyles[2].Width = 100;
                    button4.Size = new Size(110, 60);
                    button5.Size = new Size(110, 60);
                    break;


                case "Родитель":
                    tableLayoutPanel2.ColumnStyles[0].Width = 0;
                    tableLayoutPanel2.ColumnStyles[3].Width = 100;
                    button6.Size = new Size(110, 60);
                    button7.Size = new Size(110, 60);
                    break;


                default:
                    MessageBox.Show("Выберите тип пользователя");
                    break;



            }
            
            

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.ColumnStyles[0].Width = 100;
            tableLayoutPanel2.ColumnStyles[1].Width = 0;
            tableLayoutPanel2.ColumnStyles[2].Width = 0;
            tableLayoutPanel2.ColumnStyles[3].Width = 0;
            button1.Size = new Size(110, 60);
            NameBox.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.ColumnStyles[0].Width = 100;
            tableLayoutPanel2.ColumnStyles[1].Width = 0;
            tableLayoutPanel2.ColumnStyles[2].Width = 0;
            tableLayoutPanel2.ColumnStyles[3].Width = 0;
            button1.Size = new Size(110, 60);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.ColumnStyles[0].Width = 100;
            tableLayoutPanel2.ColumnStyles[1].Width = 0;
            tableLayoutPanel2.ColumnStyles[2].Width = 0;
            tableLayoutPanel2.ColumnStyles[3].Width = 0;
            button1.Size = new Size(110, 60);
        }

        

        

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signinform = new SignInForm();
            signinform.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signinform = new SignInForm();
            signinform.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signinform = new SignInForm();
            signinform.Show();
        }
    }
}
