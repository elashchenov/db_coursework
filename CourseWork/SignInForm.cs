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
using CourseWork.DBClasses;


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
            UserDB user = new UserDB();

            //try {
                user.loadByLoginAndPassword(loginUser, passUser);
                switch (user.user_type) {
                    case 0:
                        user = new TeacherDB(user);
                        break;
                    case 1:
                        user = new PupleDB(user);
                        break;
                    case 2:
                        user = new ParentDB(user);
                        break;
                }
                //MessageBox.Show(user.fio);
            //}
            //catch (Exception exception) {
            //    MessageBox.Show("Conection failed: " + exception.Message);
            //    return;
            //}

            this.Hide();
            MainForm mainForm = new MainForm(this, user);
            mainForm.Show();

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
