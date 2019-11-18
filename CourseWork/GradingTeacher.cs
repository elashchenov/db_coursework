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
    public partial class GradingTeacher : Form
    {
        Panel parentPanel_;
        ContextMenuStrip addMarks_cm;
        FlowLayoutPanel cmOwner;

        public GradingTeacher(Panel parentPanel)
        {
            parentPanel_ = parentPanel;
            InitializeComponent();
            mainContainer_tbl.AutoScroll = false;
            mainContainer_tbl.MinimumSize = new Size(0, mainContainer_tbl.GetRowHeights().Sum());
            createContextMenu();
            flowLayoutPanel1.ContextMenuStrip = addMarks_cm;
        }

        public TableLayoutPanel getContainer()
        {
            return mainContainer_tbl;
        }

        private void createContextMenu()
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.Opening += new CancelEventHandler(contextMenuStrip_Opening);
            ToolStripMenuItem addMarkMenuItem = new ToolStripMenuItem("Добавить оценку");
            addMarkMenuItem.Click += new EventHandler(myContextMenuStrip_Click);
            contextMenuStrip.Items.Add(addMarkMenuItem);
            addMarks_cm = contextMenuStrip;
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            cmOwner = (FlowLayoutPanel)((ContextMenuStrip)sender).SourceControl;
        }

        private void myContextMenuStrip_Click(object sender, EventArgs e)
        {
            GradeCreating gradeCreating = new GradeCreating();
            gradeCreating.ShowDialog();
            ToolStripItem menuItem = sender as ToolStripItem;
            if (gradeCreating.getMark().Count() != 0) {
                MarkLabel ml = new MarkLabel(gradeCreating.getMark()[0], cmOwner, 1);
                cmOwner.Controls.Add(ml);
            }
            Refresh();
        }

        private void markLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
