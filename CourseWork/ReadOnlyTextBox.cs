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
    }
}
