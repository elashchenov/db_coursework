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
    public partial class Messages : Form
    {
        private Panel parentPanel_;

        public TableLayoutPanel getContainer()
        {
            return mainContainer_tbl;
        }
        public Messages(Panel parentPanel)
        {
            parentPanel_ = parentPanel;
            InitializeComponent();
        }

        private void mainContainer_tbl_Resize(object sender, EventArgs e)
        {
            int margin = (mainContainer_tbl.Width - messages_tbl.Width) / 2;
            messagesTopLayout_tbl.Margin = new Padding(margin - 3, 0, margin - 3, 0);
        }
    }
}
