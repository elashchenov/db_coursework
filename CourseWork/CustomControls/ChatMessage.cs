using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.DBClasses;

namespace CourseWork.CustomControls
{
    public partial class ChatMessage : UserControl
    {
        [Browsable(true)]
        public Color _BackColor { get; set; }

        [Browsable(true)]
        [Category("Data")]
        [Description("asdf")]
        public int _senderType { get; set; }

        [Category("Data")]
        [Description("asdf")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string[] _Lines
        {
            get { return text_rtb.Lines; }
            set { text_rtb.Lines = value; }
        }
        public ChatMessage()
        {
            InitializeComponent();
            _senderType = 0;
            Margin = new Padding(0, 3, 0, 0);
            CheckForIllegalCrossThreadCalls = false;
        }

        public ChatMessage(MessageDB message, int senderType) : this()
        {
            _senderType = senderType;
            time_lbl.Text = message.time.ToString();
            text_rtb.Text = message.message;
            if (_senderType == 0) {
                _BackColor = Color.FromArgb(43, 82, 121);
                text_rtb.BackColor = Color.FromArgb(43, 82, 121);
                Anchor = AnchorStyles.Right;
            } else {
                _BackColor = Color.FromArgb(60, 111, 150);
                text_rtb.BackColor = Color.FromArgb(60, 111, 150);
                Anchor = AnchorStyles.Left;
            }
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
            int cornerRadius = 15; // change this value according to your needs
            int diminisher = 1;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rectangle.X, rectangle.Y, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(rectangle.X + rectangle.Width - cornerRadius - diminisher, rectangle.Y, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(rectangle.X + rectangle.Width - cornerRadius - diminisher, rectangle.Y + rectangle.Height - cornerRadius - diminisher, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - cornerRadius - diminisher, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();
            return path;
        }

        private void text_rtb_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            text_rtb.Height = e.NewRectangle.Height;
            message_tbl.RowStyles[0].Height = text_rtb.Height + 10;
        }

        private void fitWidthToText()
        {
            SizeF mySize = new SizeF();
            Font myFont = new Font(this.text_rtb.Font.FontFamily, this.text_rtb.Font.Size);
            float maxWidth = 0;
            foreach (string line in text_rtb.Lines) {
                mySize = TextRenderer.MeasureText(line, myFont);
                if (mySize.Width > maxWidth)
                    maxWidth = mySize.Width;
            }
            if (maxWidth > 0 && maxWidth < 400) {
                this.text_rtb.Width = (int)Math.Round(maxWidth, 0);
                if (text_rtb.Width > 150)
                    this.MaximumSize = new Size(text_rtb.Width + 10, 0);
                else
                    this.MaximumSize = new Size(150, 0);

                //MessageBox.Show("here");
            }
        }

        private void text_rtb_TextChanged(object sender, EventArgs e)
        {
            fitWidthToText();
        }

        private void ChatMessage_Load(object sender, EventArgs e)
        {
            fitWidthToText();
        }
    }
}
