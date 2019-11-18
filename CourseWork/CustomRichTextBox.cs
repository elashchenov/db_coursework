using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class CustomRichTextBox : RichTextBox
    {
        //public CustomRichTextBox()
        //{
        //    InitializeComponent();
        //}

        protected override void WndProc(ref Message m)
        {
            const int WM_MOUSEWHEEL = 0x020A;

            if (m.Msg == WM_MOUSEWHEEL) {
                // find the first scrollable parent control
                Control p = this;
                do {
                    p = p.Parent;
                } while (p != null && !(p is ScrollableControl));

                // rewrite the destination handle of the message
                if (p != null)
                    m.HWnd = p.Handle;
            }
            base.WndProc(ref m);
        }
    }
}
