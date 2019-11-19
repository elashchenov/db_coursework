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

namespace CourseWork
{

    public partial class MarkLabel : Label
    {
        [Browsable(true)]
        public Color _BackColor { get; set; }
        private char mark_;
        private string teacherNote_;
        private Panel parentLayout_;
        private int changeMode_;

        private Dictionary<char, Color> markColors = new Dictionary<char, Color>
        {
            { '2', Color.FromArgb(255, 34, 0) },
            { '3', Color.FromArgb(255, 187, 0) },
            { '4', Color.FromArgb(170, 255, 0) },
            { '5', Color.FromArgb(85, 255, 68) }
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
            GradeCreating gradeCreating = new GradeCreating();
            gradeCreating.ShowDialog();
            if (gradeCreating.getMark().Count() != 0) {
                _BackColor = markColors[gradeCreating.getMark()[0]];
                mark_ = gradeCreating.getMark()[0];
                Text = gradeCreating.getMark();
            }
            Refresh();
        }

        private void deleteMark(object sender, EventArgs e)
        {
            parentLayout_.Controls.Remove(this);
            this.Dispose();
        }

        public MarkLabel() : this('3', null, 0)
        {
        }

        public MarkLabel(char mark, Panel parentLayout, int changeMode)
        {
            InitializeComponent();
            mark_ = mark;
            changeMode_ = changeMode;
            parentLayout_ = parentLayout;
            this.DoubleBuffered = true;
            ForeColor = SystemColors.Window;
            _BackColor = markColors[mark];
            Text = mark.ToString();
            Size = new Size(20, 20);
            ContextMenuStrip = getContextMenu();
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            Anchor = System.Windows.Forms.AnchorStyles.Left;
            Margin = new Padding(4, 5, 0, 0);
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this, "Hello");
            ToolTip1.ToolTipTitle = "Title";
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
