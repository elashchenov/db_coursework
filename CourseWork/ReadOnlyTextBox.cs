using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;



namespace CourseWork
{
    public class ReadOnlyTextBox : TextBox
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public ReadOnlyTextBox()
        {
            this.ReadOnly = true;
            this.GotFocus += TextBoxGotFocus;
            this.Cursor = Cursors.Arrow;
        }

        private void TextBoxGotFocus(object sender, EventArgs args)
        {
            if (this.ReadOnly) {
                HideCaret(this.Handle);
                this.Cursor = Cursors.Arrow;
            } else {
                this.Cursor = Cursors.IBeam;
            }

        }

        protected override void WndProc(ref Message m)
        {
            // Send WM_MOUSEWHEEL messages to the parent
            if (m.Msg == 0x20a) SendMessage(this.Parent.Handle, m.Msg, m.WParam, m.LParam);
            else base.WndProc(ref m);
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
    }
}
