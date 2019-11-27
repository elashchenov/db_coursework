using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using CourseWork.DBClasses;

namespace CourseWork
{

    public partial class MarkLabel : Label
    {
        [Browsable(true)]
        public Color _BackColor { get; set; }
        public ToolTip toolTip { get; set; } = new ToolTip();
        public MarkDB mark { get; set; }
        private List<FlowLayoutPanel> pupleLayouts;
        private List<PupleDB> puplesInClass;
        private int changeMode_;


        private Dictionary<int, Color> markColors = new Dictionary<int, Color>
        {
            { 2, Color.FromArgb(255, 34, 0) },
            { 3, Color.FromArgb(255, 187, 0) },
            { 4, Color.FromArgb(170, 255, 0) },
            { 5, Color.FromArgb(85, 255, 68) }
        };

        private void myContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (changeMode_ == 0)
                e.Cancel = true;
        }

        private ContextMenuStrip getContextMenu()
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.Opening += new CancelEventHandler(myContextMenuStrip_Opening);
            ToolStripMenuItem changeMenuItem = new ToolStripMenuItem("Изменить оценку");
            changeMenuItem.Click += new EventHandler(myContextMenuStrip_Click);
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить оценку");
            deleteMenuItem.Click += new EventHandler(deleteMark);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { changeMenuItem, deleteMenuItem });

            return contextMenuStrip;
        }


        private void myContextMenuStrip_Click(object sender, EventArgs e)
        {
            PupleDB pupleBeforeChange = mark.puple;
            GradeCreating gradeCreating = new GradeCreating(mark, puplesInClass);
            gradeCreating.ShowDialog();
            _BackColor = markColors[mark.mark];
            Text = mark.mark.ToString();
            if (pupleBeforeChange != mark.puple) {
                pupleLayouts[puplesInClass.IndexOf(pupleBeforeChange)].Controls.Remove(this);
                pupleLayouts[puplesInClass.IndexOf(mark.puple)].Controls.Add(this);
            }
            toolTip.SetToolTip(this, mark.workName);
            toolTip.ToolTipTitle = mark.workType;
            Refresh();
        }

        public void deleteMark(object sender, EventArgs e)
        {
            pupleLayouts[puplesInClass.IndexOf(mark.puple)].Controls.Remove(this);
            mark.deleteMark();
            this.Dispose();
        }

        public MarkLabel(MarkDB mark, List<FlowLayoutPanel> pupleLayouts, int changeMode)
        {
            InitializeComponent();
            this.mark = mark;
            changeMode_ = changeMode;
            this.pupleLayouts = pupleLayouts;
            this.DoubleBuffered = true;
            ForeColor = SystemColors.Window;
            _BackColor = markColors[mark.mark];
            //MessageBox.Show(mark.mark.ToString());
            Text = Convert.ToString(mark.mark);
            Size = new Size(20, 20);
            ContextMenuStrip = getContextMenu();
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            Anchor = System.Windows.Forms.AnchorStyles.Left;
            Margin = new Padding(4, 5, 0, 0);

            puplesInClass = PupleDB.loadPuples().FindAll(
                    p => p.classDB.class_id == mark.puple.classDB.class_id
                    );
            puplesInClass.Sort((p1, p2) => string.Compare(p1.fio, p2.fio));
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var graphicsPath = _getRoundRectangle(this.ClientRectangle)) {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var brush = new SolidBrush(_BackColor))
                    e.Graphics.FillPath(brush, graphicsPath);
                using (var pen = new Pen(_BackColor, 1.0f))
                    e.Graphics.DrawPath(pen, graphicsPath);
                TextRenderer.DrawText(e.Graphics, Text, this.Font, this.ClientRectangle, this.ForeColor);
            }
        }

        private GraphicsPath _getRoundRectangle(Rectangle rectangle)
        {
            int cornerRadius = 8; // change this value according to your needs
            int diminisher = 1;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rectangle.X, rectangle.Y, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(rectangle.X + rectangle.Width - cornerRadius - diminisher, rectangle.Y, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(rectangle.X + rectangle.Width - cornerRadius - diminisher, rectangle.Y + rectangle.Height - cornerRadius - diminisher, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - cornerRadius - diminisher, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();
            return path;
        }
    }
}
