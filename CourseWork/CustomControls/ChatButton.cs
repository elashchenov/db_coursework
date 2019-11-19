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
    public partial class ChatButton : UserControl
    {
        public ChatButton()
        {
            InitializeComponent();
            ToolTip deleteChatBtn_tt = new ToolTip();
            deleteChatBtn_tt.SetToolTip(deleteChat_btn, "Удалить чат");

        }

        private void deleteChat_btn_MouseEnter(object sender, EventArgs e)
        {
            mainChatLayout_tbl.BackColor = SystemColors.GradientInactiveCaption;
            deleteChat_btn.Image = Properties.Resources.close_btn_hover;
        }

        private void deleteChat_btn_MouseLeave(object sender, EventArgs e)
        {
            mainChatLayout_tbl.BackColor = SystemColors.GradientInactiveCaption;
            deleteChat_btn.Image = Properties.Resources.close_btn;
        }

        private void mainChatLayout_tbl_MouseEnter(object sender, EventArgs e)
        {
            mainChatLayout_tbl.BackColor = SystemColors.GradientInactiveCaption;
            deleteChat_btn.Image = Properties.Resources.close_btn;
        }

        private void mainChatLayout_tbl_MouseLeave(object sender, EventArgs e)
        {
            mainChatLayout_tbl.BackColor = SystemColors.Control;
            deleteChat_btn.Image = null;
        }

        private void deleteChat_btn_Click(object sender, MouseEventArgs e)
        {
            MessageBox.Show("delete clicked");
        }
    }
}
