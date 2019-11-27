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
    public partial class GradingTeacher : Form
    {
        Panel parentPanel_;
        ContextMenuStrip addMarks_cm;
        FlowLayoutPanel cmOwner;
        TeacherDB teacher;
        List<PupleDB> puplesInClass;
        private List<FlowLayoutPanel> pupleMarks_flp = new List<FlowLayoutPanel>();

        public GradingTeacher(Panel parentPanel, TeacherDB teacher)
        {
            this.teacher = teacher;
            parentPanel_ = parentPanel;
            InitializeComponent();
            mainContainer_tbl.AutoScroll = false;
            mainContainer_tbl.MinimumSize = new Size(0, mainContainer_tbl.GetRowHeights().Sum());
            createContextMenu();
            //flowLayoutPanel1.ContextMenuStrip = addMarks_cm;

            subject_cb.Items.AddRange(teacher.subjects.ToArray());
            class_cb.Items.AddRange(ClassDB.loadClasses().ToArray());
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
            MarkDB newMark = new MarkDB();
            newMark.subject = (SubjectDB)subject_cb.SelectedItem;
            newMark.puple = puplesInClass[pupleMarks_flp.IndexOf(cmOwner)];
            GradeCreating gradeCreating = new GradeCreating(newMark, puplesInClass);
            gradeCreating.ShowDialog();
            if (newMark.mark_id != -1) {
                ToolStripItem menuItem = sender as ToolStripItem;
                MarkLabel ml = new MarkLabel(newMark, pupleMarks_flp, 1);
                ml.toolTip.SetToolTip(ml, newMark.workName);
                ml.toolTip.ToolTipTitle = newMark.workType;
                pupleMarks_flp[puplesInClass.IndexOf(newMark.puple)].Controls.Add(ml);
            }
            Refresh();
        }

        private void markLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subject_cb.SelectedIndex != -1 && class_cb.SelectedIndex != -1) {
                puplesInClass = PupleDB.loadPuples().FindAll(
                    p => p.classDB.class_id == ((ClassDB)class_cb.SelectedItem).class_id
                    );
                puplesInClass.Sort((p1, p2) => string.Compare(p1.fio, p2.fio));
                clearTable();
                foreach (PupleDB puple in puplesInClass) {
                    addPupleRow(puple);
                }
            }
        }

        private void addPupleRow(PupleDB puple)
        {
            Label label = new Label();
            label.Anchor = AnchorStyles.Left;
            label.AutoSize = true;
            label.Margin = new Padding(3, 0, 3, 0);
            label.Text = puple.fio;
            label.Font = new Font("Comic Sans MS", 10);

            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.Dock = DockStyle.Fill;
            flp.Margin = new Padding(0);
            flp.ContextMenuStrip = addMarks_cm;

            List<MarkLabel> marks = new List<MarkLabel>();
            foreach (MarkDB mark in MarkDB.loadMarks().FindAll(m => m.puple.puple_id == puple.puple_id 
            && m.subject.subject_id == ((SubjectDB)subject_cb.SelectedItem).subject_id)) {
                MarkLabel markLabel = new MarkLabel(mark, pupleMarks_flp, 1);
                markLabel.toolTip.SetToolTip(markLabel, mark.workName);
                markLabel.toolTip.ToolTipTitle = mark.workType;
                marks.Add(markLabel);
            }
            flp.Controls.AddRange(marks.ToArray());

            RowStyle newRow = new RowStyle(SizeType.Absolute, 30);
            marks_tbl.RowStyles.Add(newRow);
            marks_tbl.RowCount += 1;
            resizeMarksTableHeight(30);

            marks_tbl.Controls.Add(flp, 1, pupleMarks_flp.Count);
            marks_tbl.Controls.Add(label, 0, pupleMarks_flp.Count);
            pupleMarks_flp.Add(flp);
        }

        private void clearTable()
        {
            resizeMarksTableHeight(-30 * pupleMarks_flp.Count());
            pupleMarks_flp.Clear();
            TableLayoutPanel table = new TableLayoutPanel();
            table.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            ColumnStyle names = new ColumnStyle(SizeType.Absolute, 250);
            ColumnStyle marks = new ColumnStyle(SizeType.Percent, 100);
            table.ColumnStyles.Add(names);
            table.ColumnStyles.Add(marks);
            table.ColumnCount += 2;
            RowStyle row = new RowStyle(SizeType.Absolute, 30);
            table.RowStyles.Add(row);
            table.RowCount += 1;
            table.Size = new Size(800, 30);
            mainContainer_tbl.Controls.Remove(marks_tbl);
            marks_tbl.Dispose();
            marks_tbl = table;
            mainContainer_tbl.Controls.Add(marks_tbl, 0, 2);
        }

        private void resizeMarksTableHeight(int onHeight)
        {
            mainContainer_tbl.RowStyles[2].Height += onHeight;
            marks_tbl.Height += onHeight;

            int sum = 0;
            for (int i = 0; i < mainContainer_tbl.RowCount; i++) {
                sum += (int)mainContainer_tbl.RowStyles[i].Height;
            }
            parentPanel_.AutoScrollMinSize = new Size(0, sum);
        }
    }
}
