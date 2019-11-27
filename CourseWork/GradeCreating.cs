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
    public partial class GradeCreating : Form
    {
        string prevVal;
        List<PupleDB> puplesInClass;
        public MarkDB mark { get; private set; }

        public GradeCreating(MarkDB mark, List<PupleDB> puplesInClass)
        {
            this.mark = mark;
            this.puplesInClass = puplesInClass;
            InitializeComponent();
            puple_cb.Items.AddRange(puplesInClass.ToArray());
            puple_cb.SelectedItem = mark.puple;

            if (mark.mark_id != -1) {
                workType_cb.SelectedItem = mark.workType;
                workName_tb.Text = mark.workName;
                mark_cb.SelectedItem = mark.mark.ToString();
                markComment_rtb.Text = mark.teacherNote;
            }
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
                prevVal = focusedComboBox.SelectedItem.ToString();
            else
                prevVal = (string)focusedComboBox.SelectedItem;
        }
        

        private void comboBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.FindStringExact(comboBox.Text) == -1) {
                comboBox.TextUpdate -= new EventHandler(comboBox_TextUpdate);
                comboBox.SelectedItem = prevVal;
                comboBox.Text = prevVal;
                comboBox.TextUpdate += new EventHandler(comboBox_TextUpdate);
            }
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (puple_cb.SelectedIndex == -1 ||
                workType_cb.SelectedIndex == -1 ||
                workName_tb.Text.Count() == 0 ||
                mark_cb.SelectedIndex == -1) {
                MessageBox.Show("Не все поля заполнены!");
            }

            mark.puple = (PupleDB) puple_cb.SelectedItem;
            mark.workType = (string)workType_cb.SelectedItem;
            mark.workName = workName_tb.Text;
            mark.mark = Convert.ToInt32(mark_cb.SelectedItem);
            mark.teacherNote = markComment_rtb.Text;

            if (mark.mark_id == -1) {
                mark.addNewMark();
            } else {
                mark.UpdateMarkInDB();
            }

            this.Close();
        }
    }
}
