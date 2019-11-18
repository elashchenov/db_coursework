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
    public partial class HomeworkTeacher : Form
    {
        private Panel parentPanel_;
        public HomeworkTeacher(Panel parentPanel)
        {
            parentPanel_ = parentPanel;
            InitializeComponent();
            mainContainer_tbl.AutoScroll = false;
            mainContainer_tbl.MinimumSize = new Size(0, mainContainer_tbl.GetRowHeights().Sum());
        }

        public TableLayoutPanel getContainer()
        {
            return mainContainer_tbl;
        }

        private void homeworkCheck_sc_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (this.homeworkCheck_sc.CanFocus) {
                this.homeworkCheck_sc.ActiveControl = this.homeworkList_lb;
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
            homeworkList_lb.Items.RemoveAt(homeworkList_lb.SelectedIndex);
        }
    }
}
