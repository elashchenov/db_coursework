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
using System.IO;

namespace CourseWork
{
    public partial class HomeworkTeacher : Form
    {
        private Panel parentPanel_;
        private string personDataPrevVal;
        private List<ClassDB> classes = ClassDB.loadClasses();
        private List<SubjectDB> subjects = SubjectDB.loadSubjects();
        private List<AnswerDB> answers = new List<AnswerDB>();
        private List<LinkLabel> attachments_ll = new List<LinkLabel>();
        private TeacherDB teacher;

        public HomeworkTeacher(Panel parentPanel, TeacherDB teacher)
        {
            this.teacher = teacher;
            parentPanel_ = parentPanel;
            InitializeComponent();
            mainContainer_tbl.AutoScroll = false;
            mainContainer_tbl.MinimumSize = new Size(0, mainContainer_tbl.GetRowHeights().Sum());

            classCreate_cb.Items.AddRange(classes.ToArray());
            subjectCreate_cb.Items.AddRange(teacher.subjects.ToArray());
            answers = AnswerDB.loadAnswers().FindAll(p => p.teacher.teacher_id == teacher.teacher_id);
            answerList_lb.Items.AddRange(answers.ToArray());
        }

        public TableLayoutPanel getContainer()
        {
            return mainContainer_tbl;
        }

        private void Fields_Validating(object sender, EventArgs e)
        {
            if (classCreate_cb.SelectedIndex == -1 ||
                subjectCreate_cb.SelectedIndex == -1 ||
                homeworkCreate_tb.Text.Trim().Count() == 0) {
                publish_btn.Enabled = false;
            } else {
                publish_btn.Enabled = true;
            }
        }

        private void homeworkCheck_sc_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (this.homeworkCheck_sc.CanFocus) {
                this.homeworkCheck_sc.ActiveControl = this.answerList_lb;
            }
        }

        private void mainContainer_tbl_Resize(object sender, EventArgs e)
        {
            int margin = (checkHomeworkLayout_tbl.Width - sendedHomework_gb.Width) / 2;
            sendedHomework_gb.Margin = new Padding(margin, 0, margin, 3);
            gradeHomework_gb.Margin = new Padding(margin, 0, margin, 3);

            int margin1 = (createHomeworkLayout_tbl.Width - createHomework_gb.Width) / 2;
            createHomework_gb.Margin = new Padding(margin1, 0, margin1, 3);
        }

        private void homework_tc_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainContainer_tbl_Resize(sender, e);
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            ((AnswerDB)answerList_lb.Items[answerList_lb.SelectedIndex]).deleteAnswer();
            answerList_lb.Items.RemoveAt(answerList_lb.SelectedIndex);
            clearForm();
        }

        private void refreshMenuItem_Click(object sender, EventArgs e)
        {
            answers = AnswerDB.loadAnswers().FindAll(p => p.teacher.teacher_id == teacher.teacher_id);
            answerList_lb.Items.Clear();
            answerList_lb.Items.AddRange(answers.ToArray());
        }


        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.FindStringExact(comboBox.Text) == -1) {
                comboBox.SelectedItem = personDataPrevVal;
                comboBox.Text = personDataPrevVal;
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            ComboBox focusedComboBox = (ComboBox)sender;
            if (focusedComboBox.SelectedItem != null)
                personDataPrevVal = focusedComboBox.SelectedItem.ToString();
            else
                personDataPrevVal = (string)focusedComboBox.SelectedItem;
        }

        private void publish_btn_Click(object sender, EventArgs e)
        {
            HomeworkDB homework = new HomeworkDB();
            homework.addNewHomeworkIntoDB(
                (SubjectDB)subjectCreate_cb.SelectedItem,
                (ClassDB)classCreate_cb.SelectedItem,
                (TeacherDB) teacher,
                homeworkCreate_tb.Text.Trim(),
                homeworkDescr_rtb.Text.Trim());
            MessageBox.Show("Домашнее задание опубликовано!");
            homeworkCreate_tb.Clear();
            homeworkDescr_rtb.Clear();
        }

        private void homeworkList_lb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (answerList_lb.SelectedIndex == -1) {
                return;
            }
            AnswerDB answer = (AnswerDB)answerList_lb.SelectedItem;
            subject_tb.Text = answer.subject.name;
            homework_tb.Text = answer.homework.name;
            pupleNote_rtb.Text = answer.pupleNote;

            this.SuspendLayout();
            clearFilenameDataRows();
            foreach (string filename in answer.homework_attachments) {
                addFilenameDataRow(filename);
            }
            this.ResumeLayout();
        }

        private void clearFilenameDataRows()
        {
            if (attachments_ll.Count() == 0) {
                return;
            }
            for (int i = attachments_ll.Count() - 1; i >= 0; i--) {

                if (i != 0) {
                    int idxForDelete = sendedHomework_tbl.GetRow(attachments_ll[i]);
                    sendedHomework_tbl.RowStyles.RemoveAt(idxForDelete);
                    sendedHomework_tbl.RowCount -= 1;
                    resizeSendedHomeworkTableHeight(-30);
                }
                sendedHomework_tbl.Controls.Remove(attachments_ll[i]);
                attachments_ll.RemoveAt(i);
            }
        }

        private void addFilenameDataRow(string filename)
        {
            if (attachments_ll.Count() != 0) {
                RowStyle newRow = new RowStyle(SizeType.Absolute, 30);
                sendedHomework_tbl.RowStyles.Add(newRow);
                sendedHomework_tbl.RowCount += 1;
                resizeSendedHomeworkTableHeight(30);
            }

            LinkLabel linkLabel = new LinkLabel();
            linkLabel.LinkColor = SystemColors.Highlight;
            linkLabel.ActiveLinkColor = SystemColors.Highlight;
            linkLabel.VisitedLinkColor = Color.MediumPurple;
            linkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel.Anchor = AnchorStyles.Left;
            linkLabel.Margin = new Padding(3, 5, 3, 3);
            linkLabel.Text = filename;
            linkLabel.Font = new Font("Comic Sans MS", 10);
            linkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(saveFile);

            sendedHomework_tbl.Controls.Add(linkLabel, 1, sendedHomework_tbl.RowCount - 1);
            attachments_ll.Add(linkLabel);
        }

        void saveFile(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int idx = attachments_ll.IndexOf((LinkLabel)sender);
            AnswerDB answer = ((AnswerDB)answerList_lb.SelectedItem);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save File";
            saveFile.Filter = "Original Extension|*" + Path.GetExtension(answer.homework_attachments[idx]) + "|All Files|*.*";
            saveFile.FilterIndex = 1;
            DialogResult result = saveFile.ShowDialog();
            if (result == DialogResult.OK) {
                MessageBox.Show(saveFile.FileName);
                answer.databaseFileRead(saveFile.FileName);
            }
        }

        private void resizeSendedHomeworkTableHeight(int onHeight)
        {
            sendedHomework_gb.MinimumSize = new Size(sendedHomework_gb.Width, sendedHomework_gb.Height + onHeight);
            sendedHomework_gb.MaximumSize = new Size(sendedHomework_gb.Width, sendedHomework_gb.Height + onHeight);
            mainContainer_tbl.MinimumSize = new Size(mainContainer_tbl.Width, mainContainer_tbl.Height + onHeight);
            mainContainer_tbl.RowStyles[1].Height += onHeight;
            homework_tc.MinimumSize = new Size(homework_tc.Width, homework_tc.Height + onHeight);
            checkHomeworkLayout_tbl.RowStyles[0].Height += onHeight;
            checkHomeworkLayout_tbl.Height += onHeight;

            sendedHomework_tbl.Height += onHeight;


            int sum = 0;
            for (int i = 0; i < mainContainer_tbl.RowCount; i++) {
                sum += (int)mainContainer_tbl.RowStyles[i].Height;
            }
            parentPanel_.AutoScrollMinSize = new Size(mainContainer_tbl.Width, sum);
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            if (mark_cb.SelectedIndex == -1) {
                MessageBox.Show("Поставьте оценку");
            }
            AnswerDB answer = (AnswerDB)answerList_lb.SelectedItem;
            new MarkDB().addNewMark(answer.puple, answer.subject, "Домашняя работа", answer.homework.name, Convert.ToInt32(mark_cb.SelectedItem), markComment_rtb.Text);
            MessageBox.Show("Работа успешно оценена!");
            deleteMenuItem_Click(sender, e);
            clearForm();
        }

        private void clearForm()
        {
            subject_tb.Text = string.Empty;
            homework_tb.Text = string.Empty;
            pupleNote_rtb.Text = string.Empty;
            clearFilenameDataRows();
            mark_cb.SelectedIndex = -1;
            markComment_rtb.Text = string.Empty;
            answerList_lb.SelectedIndex = -1;
            refreshMenuItem_Click(null, null);
        }
    }
}
