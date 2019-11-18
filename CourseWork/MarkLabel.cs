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
        private Panel parentLayout_;
        private int changeMode_;

        Dictionary<char, Color> markColors = new Dictionary<char, Color>
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
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить оценку");
            deleteMenuItem.Click += new EventHandler(deleteMark);
            ToolStripMenuItem[] mark = new ToolStripMenuItem[4];
            for (int i = 2; i <= 5; i++) {
                mark[i - 2] = new ToolStripMenuItem(i.ToString());
                mark[i - 2].Click += new EventHandler(myContextMenuStrip_Click);
            }
            changeMenuItem.DropDownItems.AddRange(mark);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { changeMenuItem, deleteMenuItem });

            return contextMenuStrip;
        }


        private void myContextMenuStrip_Click(object sender, EventArgs e)
        {
            ToolStripItem item = (ToolStripMenuItem) sender;
            _BackColor = markColors[item.Text[0]];
            mark_ = item.Text[0];
            Text = item.Text;
            Refresh();
        }

        private void deleteMark(object sender, EventArgs e)
        {
            parentLayout_.Controls.Remove(this);
            this.Dispose();
        }

        public MarkLabel(char mark, Panel parentLayout, int changeMode = 1)
        {
            mark_ = mark;
            changeMode_ = changeMode;
            parentLayout_ = parentLayout;
            this.DoubleBuffered = true;
            ForeColor = SystemColors.Window;
            ContextMenuStrip = getContextMenu();
            //Validating += new CancelEventHandler(MarkLabel_Validating);
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
