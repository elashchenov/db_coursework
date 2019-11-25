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
    public partial class Profile : Form
    {
        private Panel parentPanel_;
        private UserDB user;
        private object[] personDataItems;
        private List<FlowLayoutPanel> personDataList_flp = new List<FlowLayoutPanel>();
        private List<ComboBox> personDataList_cb = new List<ComboBox>();
        private List<string> internalMails = new List<string>();
        private List<string> logins = new List<string>();
        private ToolTip toolTip = new ToolTip();
        private bool internalMailWrong = false;
        private bool fioWrong = false;
        private bool passwordConfirmWrong = false;
        private bool loginWrong = false;
        private string personDataPrevVal;

        public TableLayoutPanel getContainer()
        {
            return userProfile_tbl;
        }

        public Profile(Panel parentPanel, UserDB user)
        {
            this.user = user;
            parentPanel_ = parentPanel;
            InitializeComponent();
            userProfile_tbl.AutoScroll = false;


            for (int i = 1919; i <= 2019; i++) {
                birthYear_cb.Items.Add(i);
            }

            birthMonth_cb.SelectedIndex = 0;
            birthDay_cb.SelectedIndex = 0;
            birthYear_cb.SelectedIndex = 100;

            loadDataIntoFields();

            userProfile_tbl.MinimumSize = new Size(0, userProfile_tbl.GetRowHeights().Sum());

            foreach (UserDB userr in UserDB.loadUsers()) {
                internalMails.Add(userr.internal_mail);
            }

            foreach (UserDB userr in UserDB.loadUsers()) {
                logins.Add(userr.login);
            }

            //wrapper.VerticalScroll.Visible = false;
            //wrapper.VerticalScroll.Maximum = 0;
            //class_lbl.Visible = false;
            //class_tb.Visible = false;
        }

        private void loadDataIntoFields()
        {
            fio_tb.Text = user.fio.Trim();
            gender_comboBox.SelectedItem = user.sex.Trim();
            birthMonth_cb.SelectedIndex = user.age.Month - 1;
            birthDay_cb.SelectedItem = user.age.Day;
            birthYear_cb.SelectedItem = user.age.Year;
            email_tb.Text = user.internal_mail.Trim();
            login_tb.Text = user.login.Trim();
            //MessageBox.Show(user.sex.Trim());

            switch (user.user_type) {
                case 0:
                    class_lbl.Text = "Ваш класс:";
                    personData_lbl.Text = "Предметы:";
                    personDataItems = SubjectDB.loadSubjects().ToArray();
                    if (((TeacherDB)user).classDB != null)
                        class_tb.Text = ((TeacherDB)user).classDB.ToString();
                    foreach (SubjectDB subject in ((TeacherDB)user).subjects) {
                        addPersonDataRow(subject, personDataItems);
                    }
                    break;
                case 1:
                    class_lbl.Text = "Класс:";
                    personData_lbl.Text = "Родители:";
                    personDataItems = ParentDB.loadParents().ToArray();
                    class_tb.Text = ((PupleDB)user).classDB.ToString();
                    foreach (ParentDB parent in ((PupleDB)user).parents) {
                        addPersonDataRow(parent, personDataItems);
                    }
                    break;
                case 2:
                    class_lbl.Hide();
                    class_tb.Hide();
                    userInfo_table.RowStyles[4].SizeType = SizeType.AutoSize;
                    resizePersonalInfoTableHeight(-40);
                    personData_lbl.Text = "Дети:";
                    personDataItems = PupleDB.loadPuples().ToArray();
                    foreach (PupleDB puple in ((ParentDB)user).puples) {
                        addPersonDataRow(puple, personDataItems);
                    }
                    break;
            }
        }

        private void userProfile_tbl_Resize(object sender, EventArgs e)
        {
            int margin = (userProfile_tbl.Width - personalInfo_gb.Width) / 2;
            personalInfo_gb.Margin = new Padding(margin, 0, margin, 3);

            int margin_psw = (userProfile_tbl.Width - loginSettings_gb.Width) / 2;
            loginSettings_gb.Margin = new Padding(margin_psw, 0, margin_psw, 3);
        }

        private void removePersonDataRow(FlowLayoutPanel flowLayoutRow)
        {
            int idxRowForDelete = userInfo_table.GetRow(flowLayoutRow);
            personDataList_cb.Remove((ComboBox)flowLayoutRow.Controls[0]);
            personDataList_flp.Remove(flowLayoutRow);
            userInfo_table.Controls.Remove(flowLayoutRow);
            flowLayoutRow.Dispose();

            if (idxRowForDelete == 5) {
                //MessageBox.Show("here");
                idxRowForDelete++;
                userInfo_table.SetRow(personDataAdd_lbl, userInfo_table.GetRow(personDataAdd_lbl) - 1);
            }

            for (int i = idxRowForDelete + 1; i < userInfo_table.RowCount; i++) {
                for (int j = 0; j < userInfo_table.ColumnCount; j++) {
                    var control = userInfo_table.GetControlFromPosition(j, i);
                    if (control != null) {
                        userInfo_table.SetRow(control, i - 1);
                    }
                }
            }

            var removeStyle = userInfo_table.RowCount - 1;

            if (userInfo_table.RowStyles.Count > removeStyle)
                userInfo_table.RowStyles.RemoveAt(removeStyle);

            userInfo_table.RowCount--;
            resizePersonalInfoTableHeight(-40);

        }

        private void addPersonDataRow(object selectedItem, object[] items)
        {
            RowStyle newRow = new RowStyle(SizeType.Absolute, 40);
            userInfo_table.RowStyles.Add(newRow);
            userInfo_table.RowCount += 1;
            userInfo_table.SetRow(personalInfoOk_btn, userInfo_table.RowCount - 1);
            userInfo_table.SetRow(personDataAdd_lbl, userInfo_table.GetRow(personDataAdd_lbl) + 1);
            resizePersonalInfoTableHeight(40);

            ComboBox comboBox = new CustomComboBox();
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox.DropDownHeight = 200;
            comboBox.Width = 320;
            comboBox.Items.AddRange(items);
            comboBox.SelectedItem = selectedItem;
            comboBox.Font = new Font("Comic Sans MS", 10);
            comboBox.TextUpdate += new EventHandler(personData_cb_TextUpdate);
            comboBox.Enter += new EventHandler(personData_cb_Enter);
            comboBox.Validating += new CancelEventHandler(personData_cb_Validating);
            comboBox.TabIndex = 7 + personDataList_cb.Count();

            PictureBox closeBtn = new PictureBox();
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            closeBtn.Margin = new Padding(8, 5, 0, 0);
            closeBtn.Image = Properties.Resources.close_btn;
            closeBtn.Size = new Size(12, 12);
            closeBtn.Anchor = AnchorStyles.Left;
            closeBtn.MouseHover += new EventHandler(close_btn_MouseHover);
            closeBtn.MouseLeave += new EventHandler(close_btn_MouseLeave);
            closeBtn.Click += new EventHandler(close_btn_Click);

            FlowLayoutPanel flowLayout = new FlowLayoutPanel();
            flowLayout.Dock = DockStyle.Fill;
            flowLayout.Margin = new Padding(0);
            flowLayout.Padding = new Padding(0, 5, 0, 0);
            flowLayout.Controls.Add(comboBox);
            flowLayout.Controls.Add(closeBtn);


            userInfo_table.Controls.Add(flowLayout, 1, 5 + personDataList_flp.Count);
            personDataList_cb.Add(comboBox);
            personDataList_flp.Add(flowLayout);
            comboBox.SelectionLength = 0;

        }

        private void resizePersonalInfoTableHeight(int onHeight)
        {
            personalInfo_gb.MinimumSize = new Size(personalInfo_gb.Width, personalInfo_gb.Height + onHeight);
            personalInfo_gb.MaximumSize = new Size(personalInfo_gb.Width, personalInfo_gb.Height + onHeight);
            userProfile_tbl.RowStyles[1].Height += onHeight;
            userProfile_tbl.Height += onHeight;
            userInfo_table.Height += onHeight;

            int sum = 0;
            for (int i = 0; i < userProfile_tbl.RowCount; i++) {
                sum += (int)userProfile_tbl.RowStyles[i].Height;
            }
            parentPanel_.AutoScrollMinSize = new Size(0, sum);
        }

        void personData_cb_TextUpdate(object sender, EventArgs e)
        {
            //ComboBox comboBox = (ComboBox)sender;
            //if (comboBox.FindString(comboBox.Text) == -1) {
            //    comboBox.TextUpdate -= new EventHandler(personData_cb_TextUpdate);
            //    comboBox.Text = comboBox.Text.Substring(0, comboBox.Text.Length - 1);
            //    comboBox.Select(comboBox.Text.Length, 0);
            //    comboBox.TextUpdate += new EventHandler(personData_cb_TextUpdate);
            //}
        }

        void personData_cb_Enter(object sender, EventArgs e)
        {
            ComboBox focusedComboBox = (ComboBox)sender;
            if (focusedComboBox.SelectedItem != null)
                personDataPrevVal = focusedComboBox.SelectedItem.ToString();
            else
                personDataPrevVal = (string)focusedComboBox.SelectedItem;
        }

        private void personData_cb_Validating(object sender, CancelEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.FindStringExact(comboBox.Text) == -1) {
                comboBox.TextUpdate -= new EventHandler(personData_cb_TextUpdate);
                comboBox.SelectedItem = personDataPrevVal;
                comboBox.Text = personDataPrevVal;
                comboBox.TextUpdate += new EventHandler(personData_cb_TextUpdate);
                //MessageBox.Show("here akjda " + comboBox.SelectedItem + comboBox.SelectedIndex);
            }

        }

        private void personDataAdd_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            addPersonDataRow(null, personDataItems);
        }

        private void close_btn_MouseHover(object sender, EventArgs e)
        {
            PictureBox close_btn = (PictureBox)sender;
            Image myImage = CourseWork.Properties.Resources.close_btn_hover;
            close_btn.Image = myImage;
        }

        private void close_btn_MouseLeave(object sender, EventArgs e)
        {
            PictureBox close_btn = (PictureBox)sender;
            Image myImage = CourseWork.Properties.Resources.close_btn;
            close_btn.Image = myImage;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            removePersonDataRow((FlowLayoutPanel)pictureBox.Parent);
        }

        private void birthMonth_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedDay = birthDay_cb.SelectedIndex;
            int days = 0;
            if ((string)birthMonth_cb.SelectedItem == "Январь" ||
                (string)birthMonth_cb.SelectedItem == "Март" ||
                (string)birthMonth_cb.SelectedItem == "Май" ||
                (string)birthMonth_cb.SelectedItem == "Июль" ||
                (string)birthMonth_cb.SelectedItem == "Август" ||
                (string)birthMonth_cb.SelectedItem == "Октябрь" ||
                (string)birthMonth_cb.SelectedItem == "Декабрь") {
                days = 31;
            }

            if ((string)birthMonth_cb.SelectedItem == "Апрель" ||
                (string)birthMonth_cb.SelectedItem == "Июнь" ||
                (string)birthMonth_cb.SelectedItem == "Сентябрь" ||
                (string)birthMonth_cb.SelectedItem == "Ноябрь") {
                days = 30;
            }

            if ((string)birthMonth_cb.SelectedItem == "Февраль") {
                days = 28;
            }

            birthDay_cb.Items.Clear();
            for (int i = 1; i <= days; i++) {
                birthDay_cb.Items.Add(i);
            }

            if (selectedDay <= days)
                birthDay_cb.SelectedIndex = selectedDay;
        }

        private void personalInfoOk_btn_Click(object sender, EventArgs e)
        {
            user.fio = fio_tb.Text.Trim();
            user.sex = gender_comboBox.Text.Trim();
            user.age = new DateTime(
                    (int)birthYear_cb.SelectedItem,
                    birthMonth_cb.SelectedIndex + 1,
                    birthDay_cb.SelectedIndex + 1
                    );
            user.internal_mail = email_tb.Text.Trim();

            object[] oldItemList = null;

            switch (user.user_type) {
                case 0:
                    oldItemList = ((TeacherDB)user).subjects.ToArray();
                    break;
                case 1:
                    oldItemList = ((PupleDB)user).parents.ToArray();
                    break;
                case 2:
                    oldItemList = ((ParentDB)user).puples.ToArray();
                    break;
            }
            
            for (int i = personDataList_cb.Count() - 1; i >= 0; i--) {
                if (personDataList_cb[i].SelectedItem == null) {
                    removePersonDataRow(personDataList_flp[i]);
                }
            }

            List<object> listForAdd = new List<object>();
            foreach (ComboBox comboBox in personDataList_cb.Where(p => !oldItemList.Any(p2 => p2 == p.SelectedItem))) {
                listForAdd.Add(comboBox.SelectedItem);
            }
            List<object> listForDelete = oldItemList.Where(p => !personDataList_cb.Any(p2 => p2.SelectedItem == p)).ToList();

            switch (user.user_type) {
                case 0:
                    ((TeacherDB)user).updateTeacherInDB(
                        new List<SubjectDB>(listForDelete.Distinct().Cast<SubjectDB>()),
                        new List<SubjectDB>(listForAdd.Distinct().Cast<SubjectDB>())
                        );
                    break;
                case 1:
                    ((PupleDB)user).updatePupleInDB(
                        new List<ParentDB>(listForDelete.Distinct().Cast<ParentDB>()),
                        new List<ParentDB>(listForAdd.Distinct().Cast<ParentDB>())
                        );
                    break;
                case 2:
                    ((ParentDB)user).updateParentInDB(
                        new List<PupleDB>(listForDelete.Distinct().Cast<PupleDB>()),
                        new List<PupleDB>(listForAdd.Distinct().Cast<PupleDB>())
                        );
                    break;
            }
        }

        private void email_tb_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(internalMails.Count().ToString());
            if (internalMails.Any(s => s.Trim().Contains(email_tb.Text.Trim()) && email_tb.Text.Trim().Count() == s.Trim().Length)
                && (email_tb.Text.Trim().Count() != 0) && user.internal_mail.Trim() != email_tb.Text.Trim()) {
                personalInfoOk_btn.Enabled = false;
                email_tb.BackColor = Color.Salmon;
                toolTip.SetToolTip(email_tb, "Такая почта уже существует");
                internalMailWrong = true;
            } else {
                email_tb.BackColor = SystemColors.Window;
                toolTip.SetToolTip(email_tb, null);
                internalMailWrong = false;
            }
            FieldValidating(sender, e);
        }

        private void FieldValidating(object sender, EventArgs e)
        {
            if (internalMailWrong || email_tb.Text.Count() == 0 || fioWrong) {
                personalInfoOk_btn.Enabled = false;
            } else {
                personalInfoOk_btn.Enabled = true;
            }
        }

        private void fio_tb_TextChanged(object sender, EventArgs e)
        {
            if (fio_tb.Text.Count() == 0) {
                personalInfoOk_btn.Enabled = false;
                fio_tb.BackColor = Color.Salmon;
                toolTip.SetToolTip(fio_tb, "Неправильное имя");
                fioWrong = true;
            } else {
                fio_tb.BackColor = SystemColors.Window;
                toolTip.SetToolTip(fio_tb, null);
                fioWrong = false;
            }
            FieldValidating(sender, e);
        }

        private void login_tb_TextChanged(object sender, EventArgs e)
        {
            if (logins.Any(s => s.Trim().Contains(login_tb.Text.Trim()) && login_tb.Text.Trim().Count() == s.Trim().Length)
                && (login_tb.Text.Trim().Count() != 0) && user.login.Trim() != login_tb.Text.Trim()) {
                passwordOk_btn.Enabled = false;
                login_tb.BackColor = Color.Salmon;
                toolTip.SetToolTip(fio_tb, "Такой логин уже существует");
                loginWrong = true;
            } else {
                login_tb.BackColor = SystemColors.Window;
                toolTip.SetToolTip(fio_tb, null);
                loginWrong = false;
            }
            PasswordFieldsValidating(sender, e);
        }

        private void PasswordFieldsValidating(object sender, EventArgs e)
        {
            if (loginWrong || login_tb.Text.Trim().Count() == 0 || oldPassword_tb.Text.Trim().Count() == 0 ||
                newPassword_tb.Text.Trim().Count() == 0 || newPasswordConfirm_tb.Text.Trim().Count() == 0 ||
                passwordConfirmWrong) {
                passwordOk_btn.Enabled = false;
            } else {
                passwordOk_btn.Enabled = true;
            }
        }

        private void newPasswordConfirm_tb_TextChanged(object sender, EventArgs e)
        {
            if (newPasswordConfirm_tb.Text.Trim() != newPassword_tb.Text.Trim()) {
                passwordOk_btn.Enabled = false;
                newPasswordConfirm_tb.BackColor = Color.Salmon;
                toolTip.SetToolTip(newPasswordConfirm_tb, "Пароли отличаются");
                passwordConfirmWrong = true;
            } else {
                newPasswordConfirm_tb.BackColor = SystemColors.Window;
                toolTip.SetToolTip(newPasswordConfirm_tb, null);
                passwordConfirmWrong = false;
            }
            PasswordFieldsValidating(sender, e);
        }

        private void passwordOk_btn_Click(object sender, EventArgs e)
        {
            if (oldPassword_tb.Text.Trim() != user.password.Trim()) {
                MessageBox.Show("Старый пароль неверный");
                return;
            }
            user.login = login_tb.Text.Trim();
            user.password = newPassword_tb.Text.Trim();
            user.UpdateUserInDB();
        }
    }
}
