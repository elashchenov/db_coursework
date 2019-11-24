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
using CourseWork.DBClasses;

namespace CourseWork
{
    public partial class RegistrationForm : Form
    {

        private static RegistrationForm instance_;
        private UserRegistration userRegistration_;
        private bool loginWrong;
        private List<UserDB> users;
        private List<string> logins = new List<string>();
        private ToolTip toolTip = new ToolTip();


        public RegistrationForm()
        {

            InitializeComponent();
            instance_ = this;
            userRegistration_ = new UserRegistration();
            mainContainer_tbl.Controls.Add(userRegistration_.getContainer(), 0, 1);
            userRegistration_.getContainer().Hide();
            users = UserDB.loadUsers();
            foreach (UserDB user in users) {
                logins.Add(user.login);
            }

        }

        public static RegistrationForm getInstance()
        {
            return instance_;
        }

        private void userRegistrationLayout_tbl_Resize(object sender, EventArgs e)
        {
            //MessageBox.Show(userRegistrationLayout_tbl.GetControlFromPosition(0, 0).Name.ToString());
            //int margin = (userRegistrationLayout_tbl.GetControlFromPosition(0, 0).Width
            //    - userRegistrationLayout_tbl.Width) / 2;
            //userRegistrationLayout_tbl.GetControlFromPosition(0, 0).Margin = new Padding(margin, 0, margin, 0);
        }


        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signinform = new SignInForm();
            signinform.Show();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            userMainInfo_tbl.Hide();
            userRegistration_.chooseUserType(user_type_cb.SelectedIndex);
            userRegistration_.fields_Validating(null, null);
            userRegistration_.getContainer().Show();
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            SignInForm.instance_.Show();
        }

        public void backBtn_click(object sender, EventArgs e)
        {
            userRegistration_.getContainer().Hide();
            userMainInfo_tbl.Show();
        }

        

        public void signUp_btn_Click(UserRegistration ur)
        {
            try {

                //MessageBox.Show(ur.gender_cb.Text);
                DateTime age = new DateTime(
                    (int)ur.birthYear_cb.SelectedItem,
                    ur.birthMonth_cb.SelectedIndex + 1,
                    ur.birthDay_cb.SelectedIndex + 1
                    );

                switch ((int)user_type_cb.SelectedIndex) {
                    case 0:
                        List<SubjectDB> subjects = new List<SubjectDB>();
                        foreach (ComboBox cb in ur.personDataList_cb) {
                            if (cb.SelectedItem != null) {
                                subjects.Add((SubjectDB)cb.SelectedItem);
                            }
                        }

                        new TeacherDB().addNewTeacherIntoDB(login_tb.Text, password_tb.Text, fio_tb.Text,
                                ur.gender_cb.Text, age, ur.internalMail_tb.Text,
                                (ClassDB)ur.class_cb.SelectedItem, subjects.Distinct().ToList());
                        break;
                    case 1:
                        List<ParentDB> parents = new List<ParentDB>();
                        foreach (ComboBox cb in ur.personDataList_cb) {
                            if (cb.SelectedItem != null) {
                                parents.Add((ParentDB)cb.SelectedItem);
                            }
                        }
                        new PupleDB().addNewPupleIntoDB(login_tb.Text, password_tb.Text, fio_tb.Text,
                                ur.gender_cb.Text, age, ur.internalMail_tb.Text,
                                (ClassDB)ur.class_cb.SelectedItem, parents.Distinct().ToList());
                        break;
                    case 2:
                        List<PupleDB> puples = new List<PupleDB>();
                        foreach (ComboBox cb in ur.personDataList_cb) {
                            if (cb.SelectedItem != null) {
                                puples.Add((PupleDB)cb.SelectedItem);
                            }
                        }
                        new ParentDB().addNewParentIntoDB(login_tb.Text, password_tb.Text, fio_tb.Text,
                            ur.gender_cb.Text, age, ur.internalMail_tb.Text, puples.Distinct().ToList());
                        break;
                }
            }
            catch(Exception exception) {
                MessageBox.Show(exception.Message);
            }

            this.Close();
        }

        private void Fields_Validating(object sender, EventArgs e)
        {
            if (fio_tb.Text.Count() == 0 ||
                login_tb.Text.Count() == 0 ||
                loginWrong ||
                password_tb.Text.Count() == 0 ||
                user_type_cb.SelectedIndex == -1)
                next_btn.Enabled = false;
            else
                next_btn.Enabled = true;
        }

        private void login_tb_TextChanged(object sender, EventArgs e)
        {

            if (logins.Any(s => s.Contains(login_tb.Text) && login_tb.Text.Count() == s.Trim().Length)
                && (login_tb.Text.Count() != 0)) {

                next_btn.Enabled = false;
                login_tb.BackColor = Color.Salmon;
                toolTip.SetToolTip(login_tb, "Такой логин уже существует");
                loginWrong = true;
            } else {
                login_tb.BackColor = SystemColors.Window;
                toolTip.SetToolTip(login_tb, null);
                loginWrong = false;
            }
            Fields_Validating(sender, e);

        }
    }
}
