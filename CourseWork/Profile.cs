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
    public partial class Profile : Form
    {
        private Panel parentPanel_;
        private List<FlowLayoutPanel> personDataList_flp = new List<FlowLayoutPanel>();
        private List<ComboBox> personDataList_cb = new List<ComboBox>();
        private string personDataPrevVal;

        public TableLayoutPanel getContainer()
        {
            return userProfile_tbl;
        }
        public Profile(Panel parentPanel)
        {
            parentPanel_ = parentPanel;
            InitializeComponent();
            int[] years = new int[101];
            for (int i = 2019; i > 1918; i--)
            {
                birthYear_cb.Items.Add(i);
            }
            userProfile_tbl.AutoScroll = false;
            userProfile_tbl.MinimumSize = new Size(0, userProfile_tbl.GetRowHeights().Sum());
            
            //wrapper.VerticalScroll.Visible = false;
            //wrapper.VerticalScroll.Maximum = 0;
            //class_lbl.Visible = false;
            //class_tb.Visible = false;
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

            if (idxRowForDelete == 5)
            {
                //MessageBox.Show("here");
                idxRowForDelete++;
                userInfo_table.SetRow(personDataAdd_lbl, userInfo_table.GetRow(personDataAdd_lbl) - 1);
            }

            for (int i = idxRowForDelete + 1; i < userInfo_table.RowCount; i++)
            {
                for (int j = 0; j < userInfo_table.ColumnCount; j++)
                {
                    var control = userInfo_table.GetControlFromPosition(j, i);
                    if (control != null)
                    {
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

        private void addPersonDataRow()
        {
            RowStyle newRow = new RowStyle(SizeType.Absolute, 40);
            userInfo_table.RowStyles.Add(newRow);
            userInfo_table.RowCount += 1;
            userInfo_table.SetRow(personalInfoOk_btn, userInfo_table.RowCount - 1);
            userInfo_table.SetRow(personDataAdd_lbl, userInfo_table.GetRow(personDataAdd_lbl) + 1);
            resizePersonalInfoTableHeight(40);

            ComboBox comboBox = new ComboBox();
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox.DropDownHeight = 200;
            comboBox.Width = 320;
            string[] items = { "one", "second", "third", "tt", "tt1", "tt2", "tt3", "tt4", "tt5" };
            comboBox.Items.AddRange(items);
            comboBox.Font = new Font("Comic Sans MS", 10);
            comboBox.TextUpdate += new EventHandler(personData_cb_TextUpdate);
            comboBox.Enter += new EventHandler(personData_cb_Enter);
            comboBox.SelectedValueChanged += new EventHandler(personData_cb_SelectedValueChanged);
            comboBox.Validating += new CancelEventHandler(personData_cb_Validating);

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
        }

        private void resizePersonalInfoTableHeight(int onHeight)
        {
            personalInfo_gb.MinimumSize = new Size(personalInfo_gb.Width, personalInfo_gb.Height + onHeight);
            personalInfo_gb.MaximumSize = new Size(personalInfo_gb.Width, personalInfo_gb.Height + onHeight);
            userProfile_tbl.RowStyles[1].Height += onHeight;
            userProfile_tbl.Height += onHeight;
            userInfo_table.Height += onHeight;

            int sum = 0;
            for(int i = 0; i < userProfile_tbl.RowCount; i++)
            {
                sum += (int) userProfile_tbl.RowStyles[i].Height;
            }
            parentPanel_.AutoScrollMinSize = new Size(0, sum);
        }

        void personData_cb_TextUpdate(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.FindString(comboBox.Text) == -1)
            {
                comboBox.TextUpdate -= new EventHandler(personData_cb_TextUpdate);
                comboBox.Text = comboBox.Text.Substring(0, comboBox.Text.Length - 1);
                comboBox.Select(comboBox.Text.Length, 0);
                comboBox.TextUpdate += new EventHandler(personData_cb_TextUpdate);
            }
        }

        void personData_cb_Enter(object sender, EventArgs e)
        {
            ComboBox focusedComboBox = (ComboBox)sender;
            if (focusedComboBox.SelectedItem != null)
                personDataPrevVal = focusedComboBox.SelectedItem.ToString();
            else
                personDataPrevVal = (string)focusedComboBox.SelectedItem;
        }

        private void personData_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("selected idx is " + ((ComboBox)sender).SelectedIndex);
            //ComboBox comboBox = (ComboBox)sender;
            //if (comboBox.FindStringExact(comboBox.Text) == -1)
            //{
            //    comboBox.TextUpdate -= new EventHandler(personData_cb_TextUpdate);
            //    comboBox.SelectedValue = personDataPrevVal;
            //    comboBox.TextUpdate += new EventHandler(personData_cb_TextUpdate);
            //}
        }

        private void personData_cb_Validating(object sender, CancelEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.FindStringExact(comboBox.Text) == -1)
            {
                comboBox.TextUpdate -= new EventHandler(personData_cb_TextUpdate);
                comboBox.SelectedItem = personDataPrevVal;
                comboBox.Text = personDataPrevVal;
                comboBox.TextUpdate += new EventHandler(personData_cb_TextUpdate);
                //MessageBox.Show("here akjda " + comboBox.SelectedItem + comboBox.SelectedIndex);
            }

        }

        private void personDataAdd_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            addPersonDataRow();
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
            removePersonDataRow((FlowLayoutPanel) pictureBox.Parent);
        }
    }
}
