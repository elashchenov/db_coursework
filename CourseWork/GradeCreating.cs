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
    public partial class GradeCreating : Form
    {
        string prevVal;

        public string getMark()
        {
            return mark_cb.Text;
        }

        public string getTeacherNote()
        {
            return markComment_rtb.Text;
        }

        public GradeCreating()
        {
            InitializeComponent();
        }

        void comboBox_TextUpdate(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.FindString(comboBox.Text) == -1) {
                comboBox.TextUpdate -= new EventHandler(comboBox_TextUpdate);
                comboBox.Text = comboBox.Text.Substring(0, comboBox.Text.Length - 1);
                comboBox.Select(comboBox.Text.Length, 0);
                comboBox.TextUpdate += new EventHandler(comboBox_TextUpdate);
            }
        }

        void comboBox_Enter(object sender, EventArgs e)
        {
            ComboBox focusedComboBox = (ComboBox)sender;
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
            this.Close();
        }
    }
}
