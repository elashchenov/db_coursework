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
    public partial class AcademicPerformance : Form
    {
        private Panel parentPanel;
        private List<SubjectDB> subjectsForClass = new List<SubjectDB>();
        private List<FlowLayoutPanel> subjectMarks_flp = new List<FlowLayoutPanel>();
        private PupleDB puple;

        public AcademicPerformance(Panel parentPanel, UserDB user)
        {
            this.parentPanel = parentPanel;
            InitializeComponent();
            mainContainer_tbl.AutoScroll = false;
            mainContainer_tbl.MinimumSize = new Size(0, mainContainer_tbl.GetRowHeights().Sum());
            if (user.user_type == 1) {
                puple = (PupleDB)user;
                puple_cb.Hide();
                puple_lbl.Hide();
                loadMarks(puple);
            } else {
                puple_cb.Items.AddRange(((ParentDB)user).puples.ToArray());
            }
        }

        public TableLayoutPanel getContainer()
        {
            return mainContainer_tbl;
        }

        public void loadMarks(PupleDB puple)
        {
            foreach (SheduleDB shedule in SheduleDB.loadSheduleByClass(puple.classDB)) {
                subjectsForClass.Add(shedule.subject);
            }
            subjectsForClass = subjectsForClass.Distinct().ToList();
            subjectsForClass.Sort((p1, p2) => string.Compare(p1.name, p2.name));
            clearTable();
            foreach (SubjectDB subject in subjectsForClass) {
                addSubjectRow(subject);
            }
            int sum = 0;
            foreach (RowStyle row in marks_tbl.RowStyles) {
                sum += (int)row.Height;
            }
            parentPanel.AutoScrollMinSize = new Size(0, sum);
        }

        private void addSubjectRow(SubjectDB subject)
        {
            Label label = new Label();
            label.Anchor = AnchorStyles.Left;
            label.AutoSize = true;
            label.Margin = new Padding(3, 0, 3, 0);
            label.Text = subject.name;
            label.Font = new Font("Comic Sans MS", 10);

            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.Dock = DockStyle.Fill;
            flp.Margin = new Padding(0);

            List<MarkLabel> marks = new List<MarkLabel>();
            foreach (MarkDB mark in MarkDB.loadMarks().FindAll(m => m.puple.puple_id == puple.puple_id
            && m.subject.subject_id == subject.subject_id)) {
                MarkLabel markLabel = new MarkLabel(mark, subjectMarks_flp, 0);
                markLabel.toolTip.SetToolTip(markLabel, mark.workName);
                markLabel.toolTip.ToolTipTitle = mark.workType;
                marks.Add(markLabel);
            }
            flp.Controls.AddRange(marks.ToArray());

            RowStyle newRow = new RowStyle(SizeType.Absolute, 30);
            marks_tbl.RowStyles.Add(newRow);
            marks_tbl.RowCount += 1;
            resizeMarksTableHeight(30);

            marks_tbl.Controls.Add(flp, 1, subjectMarks_flp.Count);
            marks_tbl.Controls.Add(label, 0, subjectMarks_flp.Count);
            subjectMarks_flp.Add(flp);
        }

        private void clearTable()
        {
            resizeMarksTableHeight(-30 * subjectMarks_flp.Count());
            subjectMarks_flp.Clear();
            TableLayoutPanel table = new TableLayoutPanel();
            table.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            table.Margin = new Padding(0);
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
            mainContainer_tbl.MinimumSize = new Size(0, sum - 28);
            parentPanel.AutoScrollMinSize = new Size(0, sum - 28);
        }

        private void puple_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            puple = (PupleDB)puple_cb.SelectedItem;
            loadMarks((PupleDB)puple_cb.SelectedItem);
        }
    }
}
