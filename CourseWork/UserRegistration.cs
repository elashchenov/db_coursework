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

    public partial class UserRegistration : Form
    {
        private List<FlowLayoutPanel> personDataList_flp = new List<FlowLayoutPanel>();
        public List<ComboBox> personDataList_cb = new List<ComboBox>();
        private string personDataPrevVal;
        private List<string> internalMails = new List<string>();
        private List<UserDB> users;
        private List<ClassDB> classes;
        //private List<PupleDB> puples;
        //private List<ParentDB> parents;
        //private List<SubjectDB> subjects;
        private bool internalMailWrong;
        private int userType_;
        private ToolTip toolTip = new ToolTip();
        private List<int> days = new List<int>(new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14,
            15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28});

        public UserRegistration()
        {
            InitializeComponent();
            mainContainer_tbl.HorizontalScroll.Enabled = false;
            mainContainer_tbl.HorizontalScroll.Visible = false;

            for (int i = 1919; i <= 2019; i++) {
                birthYear_cb.Items.Add(i);
            }

            birthMonth_cb.SelectedIndex = 0;
            birthDay_cb.SelectedIndex = 0;
            birthYear_cb.SelectedIndex = 100;

            //puples = PupleDB.loadPuples();
            //parents = ParentDB.loadParents();
            //subjects = SubjectDB.loadSubjects();
            users = UserDB.loadUsers();
            foreach (UserDB user in users) {
                internalMails.Add(user.internal_mail);
            }
            this.classes = ClassDB.loadClasses();
            class_cb.Items.AddRange(classes.ToArray());

        }

        public TableLayoutPanel getContainer()
        {
            return mainContainer_tbl;
        }

        public void chooseUserType(int userType)
        {
            if (userType_ != userType) {
                //MessageBox.Show(personDataList_flp.Count().ToString());
                for (int i = personDataList_flp.Count() - 1; i >= 0; i--) {
                    removePersonDataRow(personDataList_flp[i]);
                }
            }
            userType_ = userType;
            switch (userType) {
                case 0:
                    class_tbl.Show();
                    personData_lbl.Text = "Добавьте преподаваемые предметы:";
                    break;
                case 1:
                    class_tbl.Show();
                    personData_lbl.Text = "Добавьте родителей:";
                    break;
                case 2:
                    class_tbl.Hide();
                    personData_lbl.Text = "Добавьте детей:";
                    break;
            }
        }

        private void addPersonDataRow()
        {
            RowStyle newRow = new RowStyle(SizeType.AutoSize);
            personData_tbl.RowStyles.Add(newRow);
            personData_tbl.RowCount += 1;
            personData_tbl.SetRow(personDataAdd_lbl, personData_tbl.GetRow(personDataAdd_lbl) + 1);
            resizePersonalInfoTableHeight(44);

            ComboBox comboBox = new CustomComboBox();
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox.Sorted = true;
            comboBox.DropDownHeight = 200;
            comboBox.Width = 500;
            comboBox.Margin = new Padding(0, 0, 0, 0);

            object[] items = null;
            switch (userType_) {
                case 0:
                    items = SubjectDB.loadSubjects().ToArray();
                    break;
                case 1:
                    items = ParentDB.loadParents().ToArray();
                    break;
                case 2:
                    items = PupleDB.loadPuples().ToArray();
                    break;
            }

            comboBox.Items.AddRange(items);
            comboBox.Font = new Font("Comic Sans MS", 14);
            comboBox.TextUpdate += new EventHandler(comboBox_TextUpdate);
            comboBox.Enter += new EventHandler(comboBox_Enter);
            //comboBox.SelectedValueChanged += new EventHandler(personData_cb_SelectedValueChanged);
            comboBox.Validating += new CancelEventHandler(comboBox_Validating);

            PictureBox closeBtn = new PictureBox();
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            closeBtn.Margin = new Padding(8, 0, 0, 0);
            closeBtn.Image = Properties.Resources.close_btn;
            closeBtn.Size = new Size(12, 12);
            closeBtn.Anchor = AnchorStyles.Left;
            closeBtn.MouseHover += new EventHandler(close_btn_MouseHover);
            closeBtn.MouseLeave += new EventHandler(close_btn_MouseLeave);
            closeBtn.Click += new EventHandler(close_btn_Click);

            FlowLayoutPanel flowLayout = new FlowLayoutPanel();
            flowLayout.AutoSize = true;
            flowLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayout.Margin = new Padding(0, 0, 0, 10);
            flowLayout.Padding = new Padding(0);
            flowLayout.Width = 500;
            flowLayout.WrapContents = false;

            personData_tbl.Controls.Add(flowLayout, 0, 1 + personDataList_flp.Count);
            flowLayout.Controls.Add(comboBox);
            flowLayout.Controls.Add(closeBtn);
            personDataList_cb.Add(comboBox);
            personDataList_flp.Add(flowLayout);
        }

        private void removePersonDataRow(FlowLayoutPanel flowLayoutRow)
        {
            int idxRowForDelete = personData_tbl.GetRow(flowLayoutRow);
            personDataList_cb.Remove((ComboBox)flowLayoutRow.Controls[0]);
            personDataList_flp.Remove(flowLayoutRow);
            personData_tbl.Controls.Remove(flowLayoutRow);
            flowLayoutRow.Dispose();

            personData_tbl.RowStyles.RemoveAt(idxRowForDelete);

            personData_tbl.RowCount--;
            resizePersonalInfoTableHeight(-44);
        }

        private void resizePersonalInfoTableHeight(int onHeight)
        {
            userRegistration_tbl.MinimumSize = new Size(userRegistration_tbl.Width, userRegistration_tbl.Height + onHeight);
            userRegistration_tbl.MaximumSize = new Size(userRegistration_tbl.Width, userRegistration_tbl.Height + onHeight);
            mainContainer_tbl.AutoScroll = false;
            mainContainer_tbl.AutoScrollMinSize = new Size(0, userRegistration_tbl.Height + 10);
        }

        void comboBox_TextUpdate(object sender, EventArgs e)
        {
            //ComboBox comboBox = (ComboBox)sender;
            //if (comboBox.FindString(comboBox.Text) == -1) {
            //    comboBox.TextUpdate -= new EventHandler(comboBox_TextUpdate);
            //    comboBox.Text = comboBox.Text.Substring(0, comboBox.Text.Length - 1);
            //    comboBox.Select(comboBox.Text.Length, 0);
            //    comboBox.TextUpdate += new EventHandler(comboBox_TextUpdate);
            //}
        }

        void comboBox_Enter(object sender, EventArgs e)
        {
            ComboBox focusedComboBox = (ComboBox)sender;
            if (focusedComboBox.SelectedItem != null)
                personDataPrevVal = focusedComboBox.SelectedItem.ToString();
            else
                personDataPrevVal = (string)focusedComboBox.SelectedItem;
        }


        private void comboBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.FindStringExact(comboBox.Text) == -1) {
                comboBox.TextUpdate -= new EventHandler(comboBox_TextUpdate);
                comboBox.SelectedItem = personDataPrevVal;
                comboBox.Text = personDataPrevVal;
                comboBox.TextUpdate += new EventHandler(comboBox_TextUpdate);
            }
        }

        private void close_btn_MouseHover(object sender, EventArgs e)
        {
            PictureBox close_btn = (PictureBox)sender;
            Image myImage = Properties.Resources.close_btn_hover;
            close_btn.Image = myImage;
        }

        private void close_btn_MouseLeave(object sender, EventArgs e)
        {
            PictureBox close_btn = (PictureBox)sender;
            Image myImage = Properties.Resources.close_btn;
            close_btn.Image = myImage;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            removePersonDataRow((FlowLayoutPanel)pictureBox.Parent);
        }

        private void personDataAdd_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addPersonDataRow();
        }

        private void userRegistration_tbl_Resize(object sender, EventArgs e)
        {
            //MessageBox.Show("table was resized" + userRegistration_tbl.Size);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            RegistrationForm.getInstance().backBtn_click(sender, e);
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            RegistrationForm.getInstance().signUp_btn_Click(this);
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

        public void fields_Validating(object sender, EventArgs e)
        {
            if (gender_cb.SelectedIndex == -1 ||
                birthDay_cb.SelectedIndex == -1 ||
                birthMonth_cb.SelectedIndex == -1 ||
                birthYear_cb.SelectedIndex == -1 ||
                internalMail_tb.Text.Count() == 0 ||
                internalMailWrong ||
                class_cb.Text.Count() == 0 && userType_ == 1)
                signUp_btn.Enabled = false;
            else
                signUp_btn.Enabled = true;
        }

        private void internalMail_tb_TextChanged(object sender, EventArgs e)
        {
            if (internalMails.Any(s => s.Contains(internalMail_tb.Text) && internalMail_tb.Text.Count() == s.Trim().Length)
                && (internalMail_tb.Text.Count() != 0)) {
                signUp_btn.Enabled = false;
                internalMail_tb.BackColor = Color.Salmon;
                toolTip.SetToolTip(internalMail_tb, "Такая почта уже существует");
                internalMailWrong = true;
            } else {
                internalMail_tb.BackColor = SystemColors.Window;
                toolTip.SetToolTip(internalMail_tb, null);
                internalMailWrong = false;
            }
            fields_Validating(sender, e);
        }
    }
}
