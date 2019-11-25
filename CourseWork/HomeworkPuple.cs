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
    public partial class HomeworkPuple : Form
    {
        Panel parentPanel_;
        string prevValue;
        private List<SubjectDB> subjects = SubjectDB.loadSubjects();
        private List<FlowLayoutPanel> attachedFileList_flp = new List<FlowLayoutPanel>();
        private List<Label> attachedFileList_cb = new List<Label>();
        private List<string> filePaths = new List<string>();
        private List<string> fileNames = new List<string>();
        private PupleDB puple;

        public HomeworkPuple(Panel parentPanel, PupleDB puple)
        {
            this.puple = puple;
            parentPanel_ = parentPanel;
            InitializeComponent();
            mainContainer_tbl.AutoScroll = false;
            mainContainer_tbl.MinimumSize = new Size(0, mainContainer_tbl.GetRowHeights().Sum());

            subject_cb.Items.AddRange(subjects.ToArray());
        }

        public TableLayoutPanel getContainer()
        {
            return mainContainer_tbl;
        }

        void comboBox_TextUpdate(object sender, EventArgs e)
        {
            //ComboBox comboBox = (ComboBox)sender;
            //if (comboBox.FindString(comboBox.Text) == -1)
            //{
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
                prevValue = focusedComboBox.SelectedItem.ToString();
            else
                prevValue = (string)focusedComboBox.SelectedItem;
            //MessageBox.Show("selected text is " + personDataPrevVal);
        }

        private void comboBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.FindStringExact(comboBox.Text) == -1) {
                comboBox.TextUpdate -= new EventHandler(comboBox_TextUpdate);
                comboBox.SelectedItem = prevValue;
                comboBox.Text = prevValue;
                comboBox.TextUpdate += new EventHandler(comboBox_TextUpdate);
                //MessageBox.Show("here akjda " + comboBox.SelectedItem + comboBox.SelectedIndex);
            }
        }

        private void mainContainer_tbl_Resize(object sender, EventArgs e)
        {
            int margin = (mainContainer_tbl.Width - selectHomework_gb.Width) / 2;
            selectHomework_gb.Margin = new Padding(margin, 0, margin, 3);

            int margin1 = (mainContainer_tbl.Width - sendHomework_gb.Width) / 2;
            sendHomework_gb.Margin = new Padding(margin1, 0, margin1, 3);
        }

        private void resizePersonalInfoTableHeight(int onHeight)
        {
            sendHomework_gb.MinimumSize = new Size(sendHomework_gb.Width, sendHomework_gb.Height + onHeight);
            sendHomework_gb.MaximumSize = new Size(sendHomework_gb.Width, sendHomework_gb.Height + onHeight);
            mainContainer_tbl.RowStyles[2].Height += onHeight;
            sendHomework_tbl.Height += onHeight;
            int sum = 0;
            for (int i = 0; i < mainContainer_tbl.RowCount; i++) {
                sum += (int)mainContainer_tbl.RowStyles[i].Height;
            }
            parentPanel_.AutoScrollMinSize = new Size(0, sum);
        }

        private void addAttachedFileRow(string filename)
        {
            RowStyle newRow = new RowStyle(SizeType.Absolute, 40);
            sendHomework_tbl.RowStyles.Add(newRow);
            sendHomework_tbl.RowCount += 1;

            sendHomework_tbl.SetRow(send_btn, sendHomework_tbl.GetRow(attachLink_lbl) + 3);
            sendHomework_tbl.SetRow(note_lbl, sendHomework_tbl.GetRow(attachLink_lbl) + 2);
            sendHomework_tbl.SetRow(note_rtb, sendHomework_tbl.GetRow(attachLink_lbl) + 2);
            sendHomework_tbl.SetRow(attachLink_lbl, sendHomework_tbl.GetRow(attachLink_lbl) + 1);

            resizePersonalInfoTableHeight(40);
            sendHomework_tbl.RowStyles[sendHomework_tbl.GetRow(attachLink_lbl)].Height = 40;
            sendHomework_tbl.RowStyles[sendHomework_tbl.GetRow(attachLink_lbl) + 1].Height = 120;

            Label file_lbl = new Label();
            //file_lbl.Width = 320;
            file_lbl.Margin = new Padding(0, 5, 0, 0);
            file_lbl.Anchor = AnchorStyles.Left;
            file_lbl.Text = filename;
            file_lbl.AutoSize = true;
            file_lbl.Font = new Font("Comic Sans MS", 10);

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
            flowLayout.Controls.Add(file_lbl);
            flowLayout.Controls.Add(closeBtn);

            sendHomework_tbl.Controls.Add(flowLayout, 1, attachedFileList_flp.Count);
            attachedFileList_cb.Add(file_lbl);
            attachedFileList_flp.Add(flowLayout);

        }

        private void removePersonDataRow(FlowLayoutPanel flowLayoutRow)
        {
            int idxRowForDelete = sendHomework_tbl.GetRow(flowLayoutRow);
            attachedFileList_cb.Remove((Label)flowLayoutRow.Controls[0]);
            attachedFileList_flp.Remove(flowLayoutRow);
            filePaths.RemoveAt(idxRowForDelete);
            fileNames.RemoveAt(idxRowForDelete);
            sendHomework_tbl.Controls.Remove(flowLayoutRow);
            flowLayoutRow.Dispose();

            if (idxRowForDelete == 0) {
                //MessageBox.Show("here");
                idxRowForDelete++;
                sendHomework_tbl.SetRow(attachLink_lbl, sendHomework_tbl.GetRow(attachLink_lbl) - 1);
            }

            for (int i = idxRowForDelete + 1; i < sendHomework_tbl.RowCount; i++) {
                for (int j = 0; j < sendHomework_tbl.ColumnCount; j++) {
                    var control = sendHomework_tbl.GetControlFromPosition(j, i);
                    if (control != null) {
                        sendHomework_tbl.SetRow(control, i - 1);
                        sendHomework_tbl.RowStyles[i - 1].Height = sendHomework_tbl.RowStyles[i].Height;
                    }
                }
            }

            var removeStyle = sendHomework_tbl.RowCount - 1;

            if (sendHomework_tbl.RowStyles.Count > removeStyle)
                sendHomework_tbl.RowStyles.RemoveAt(removeStyle);

            sendHomework_tbl.RowCount--;
            resizePersonalInfoTableHeight(-40);
        }

        private void attachLink_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Word|*.doc*|All|*.*";//your filter
            open.FilterIndex = 1;
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK) {
                string filename = open.SafeFileName;
                string path = open.FileName;
                if (filePaths.Any(s => s == path)) {
                    MessageBox.Show("Этот файл уже прикреплен");
                    return;
                }
                filePaths.Add(path);
                fileNames.Add(filename);
                addAttachedFileRow(filename);
            }

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

        private void subject_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (subject_cb.SelectedIndex != -1) {
                teacher_cb.Items.Clear();
                teacher_cb.Items.AddRange(
                    SubjectDB.loadTeachersBySubjectId(((SubjectDB)subject_cb.SelectedItem).subject_id).ToArray()
                    );
                homework_cb.Items.Clear();
                homework_cb.Items.AddRange(
                    HomeworkDB.loadHomeworks((SubjectDB)subject_cb.SelectedItem, puple.classDB).ToArray()
                    );
            }
        }

        private void homework_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (homework_cb.SelectedIndex != -1)
                homeworkDescr_rtb.Text = ((HomeworkDB)homework_cb.SelectedItem).description;
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            if (teacher_cb.SelectedIndex == -1) {
                MessageBox.Show("Выберите учителя!");
                return;
            }
            if (filePaths.Count() == 0) {
                MessageBox.Show("Прикрепите файлы!");
                return;
            }
            try {
                new AnswerDB().addNewAnswer(
                    (TeacherDB)teacher_cb.SelectedItem,
                    (SubjectDB)subject_cb.SelectedItem,
                    puple,
                    (HomeworkDB)homework_cb.SelectedItem,
                    note_rtb.Text,
                    filePaths, fileNames
                    );
            } catch (Exception exception) {
                MessageBox.Show(exception.Message);
                return;
            }
            MessageBox.Show("Домашнее задание отправлено!");
            clearForm();
        }

        private void clearForm()
        {
            note_rtb.Clear();
            for (int i = attachedFileList_flp.Count() - 1; i >= 0; i--) {
                removePersonDataRow(attachedFileList_flp[i]);
            }
            homeworkDescr_rtb.Clear();
            homework_cb.Items.Clear();
            teacher_cb.Items.Clear();
            teacher_cb.Text = string.Empty;
            subject_cb.SelectedIndex = -1;
        }
    }
}
