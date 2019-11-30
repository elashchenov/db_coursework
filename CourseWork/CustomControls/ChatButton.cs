using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.CustomControls;
using CourseWork.DBClasses;

namespace CourseWork
{
    public partial class ChatButton : UserControl
    {
        public UserDB recipientUser;
        public UserDB senderUser;
        private int unread;

        public ChatButton()
        {
            InitializeComponent();
            ToolTip deleteChatBtn_tt = new ToolTip();
            deleteChatBtn_tt.SetToolTip(deleteChat_btn, "Удалить чат");
        }

        public void setText(string text)
        {
            message_lbl.Text = text;
        }

        public void markAsRead()
        {
            unreadMsgIcon.Visible = false;
            unreadMsgIcon.Text = "0";
        }

        public ChatButton(MessageDB topMsg, UserDB user) : this()
        {
            senderUser = user;
            if (user.user_id == topMsg.recipient.user_id) {
                recipientUser = topMsg.sender;
                unread = MessageDB.getUnreadCount(recipientUser, senderUser);
            } else {
                recipientUser = topMsg.recipient;
            }
            //MessageBox.Show("Recipient: " + recipientUser.fio + " Sender: " + senderUser.fio);
            name_lbl.Text = recipientUser.ToString();
            message_lbl.Text = topMsg.message;
            if (DateTime.Now.Date != topMsg.time.Date)
                time_lbl.Text = topMsg.time.Date.ToString().Substring(0, 5);
            else
                time_lbl.Text = topMsg.time.TimeOfDay.ToString().Substring(0, 5);
                
            if (unread == 0) {
                unreadMsgIcon.Visible = false;
            } else {
                unreadMsgIcon.Visible = true;
                unreadMsgIcon.Text = unread.ToString();
            }
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

        private void mainChatLayout_tbl_Click(object sender, EventArgs e)
        {
           
            Messages.instance_.chatButton_Click(sender, e, this);

        }

        private void deleteChat_btn_Click(object sender, EventArgs e)
        {
            Messages.instance_.delete_chatButton(this);
        }
    }
}
