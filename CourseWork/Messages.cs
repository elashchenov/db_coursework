using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.CustomControls;

namespace CourseWork
{
    public partial class Messages : Form
    {
        public static Messages instance_;
        private Panel parentPanel_;
        private TableLayoutPanel msgContainer;

        public TableLayoutPanel getContainer()
        {
            return mainContainer_tbl;
        }
        public Messages(Panel parentPanel)
        {
            parentPanel_ = parentPanel;
            InitializeComponent();
            instance_ = this;
        }

        private void mainContainer_tbl_Resize(object sender, EventArgs e)
        {
            int margin = (mainContainer_tbl.Width - chatBtns_tbl.Width) / 2;
            messagesTopLayout_tbl.Margin = new Padding(margin - 3, 0, margin - 3, 0);
            //sendMessage_rtb.Height = 40;
        }

        public void chatButton_Click(object sender, EventArgs e)
        {
            back_btn.Visible = true;
            sendMessage_tbl.Visible = true;
            chatBtns_tbl.Hide();

            msgContainer = new TableLayoutPanel();
            msgContainer.Margin = new Padding(0);
            msgContainer.Padding = new Padding(0, 0, 0, 7);
            msgContainer.Anchor = AnchorStyles.Bottom;
            msgContainer.AutoSize = true;
            msgContainer.BackColor = SystemColors.GradientActiveCaption;
            //msgContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            msgContainer.MinimumSize = new Size(500, 0);
            //msgContainer.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;


            string text = "If you have ever needed transparency in a TextBox or RichTextBox for any reason, and have tried to attempt it yourself, you know what a pain it can be. Well... now av";
            string text1 = "test message";

            addMessage(new string[] { text }, 0);
            addMessage(new string[] { text1 }, 1);

            messagesTopLayout_tbl.Controls.Add(msgContainer, 0, 0);
        }

        private void addMessage(string[] lines, int senderType)
        {
            ChatMessage chatMessage = new ChatMessage(lines, senderType);
            RowStyle msgRow = new RowStyle(SizeType.AutoSize);
            msgContainer.RowStyles.Add(msgRow);
            msgContainer.RowCount += 1;
            msgContainer.Controls.Add(chatMessage, 0, msgContainer.RowCount - 1);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(messagesTopLayout_tbl.GetControlFromPosition(0, 1).Name.ToString());
            messagesTopLayout_tbl.Controls.Remove(msgContainer);
            chatBtns_tbl.Show();
            back_btn.Visible = false;
            sendMessage_tbl.Visible = false;
        }

        private void sendMessage_rtb_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            sendMessage_icon.Visible = sendMessage_rtb.Text != "";
            if (e.NewRectangle.Height < 100) {
                sendMessage_rtb.Height = e.NewRectangle.Height;
                //MessageBox.Show(e.NewRectangle.Height.ToString());
                int margHeight = (sendMessage_tbl.Height - sendMessage_rtb.Height) / 2;
                //MessageBox.Show(margHeight.ToString());

                sendMessage_rtb.Margin = new Padding(5, margHeight, 0, margHeight);
            } else {
                sendMessage_rtb.Height = 100;
                sendMessage_rtb.Margin = new Padding(5, 5, 0, 5);
            }
        }

        private void sendMessage_icon_Click(object sender, EventArgs e)
        {
            addMessage(sendMessage_rtb.Lines, 0);
            sendMessage_rtb.Clear();
        }
    }
}
