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
using CourseWork.DBClasses;

namespace CourseWork
{
    public partial class Messages : Form
    {
        public static Messages instance_;
        private Panel parentPanel_;
        private TableLayoutPanel msgContainer;
        private PictureBox menu_btn;
        private string prevVal;
        private ComboBox userSelecting_cb;
        private UserDB senderUser;
        private UserDB recipientUser;
        private ChatButton openedChat;

        public TableLayoutPanel getContainer()
        {
            return mainContainer_tbl;
        }
        public Messages(Panel parentPanel, PictureBox menu_btn, UserDB user)
        {
            senderUser = user;
            this.menu_btn = menu_btn;
            parentPanel_ = parentPanel;
            InitializeComponent();
            instance_ = this;
            mainContainer_tbl.RowStyles[1].Height = 0;
            mainContainer_tbl.MinimumSize = new Size(0, mainContainer_tbl.GetRowHeights().Sum());
            buttons_flp.FlowDirection = FlowDirection.RightToLeft;
            loadUserChats();
        }

        private void loadUserChats()
        {
            List<MessageDB> topMessages = MessageDB.loadTopChatMessages(senderUser);
            topMessages.Sort((p1, p2) => p1.time.CompareTo(p2.time));
            topMessages.Reverse();

            //chatBtns_tbl.RowStyles.RemoveAt(0);
            //chatBtns_tbl = new TableLayoutPanel();
            //chatBtns_tbl.Anchor = AnchorStyles.Top;
            //chatBtns_tbl.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            //chatBtns_tbl.AutoSize = true;
            //chatBtns_tbl.MinimumSize = new Size(502, 0);
            //chatBtns_tbl.Margin = new Padding(0);
            //MessageBox.Show(chatBtns_tbl.RowCount.ToString());
            foreach (MessageDB message in topMessages) {
                addChatButton(message);
            }
            messagesTopLayout_tbl.AutoScroll = false;
            messagesTopLayout_tbl.AutoScrollMinSize = new Size(0, chatBtns_tbl.Height);
            messagesTopLayout_tbl.Refresh();
        }

        private void mainContainer_tbl_Resize(object sender, EventArgs e)
        {
            int margin = (mainContainer_tbl.Width - chatBtns_tbl.Width) / 2;
            messagesTopLayout_tbl.Padding = new Padding(margin, 0, margin, 0);
            //sendMessage_rtb.Height = 40;
        }

        public void chatButton_Click(object sender, EventArgs e, ChatButton chatButton)
        {
            recipientUser = chatButton.recipientUser;
            openedChat = chatButton;
            MessageDB.markAsRead(senderUser, recipientUser);
            openedChat.markAsRead();
            //MessageBox.Show(recipientUser.fio);
            createMessagingFlow();
        }

        private void createMessagingFlow()
        {
            back_btn.Visible = true;
            newDialog_btn.Visible = false;
            sendMessage_tbl.Visible = true;
            buttons_flp.FlowDirection = FlowDirection.LeftToRight;
            chatBtns_tbl.Hide();
            title_lbl.Hide();
            menu_btn.Hide();
            name_lbl.Visible = true;
            name_lbl.Text = recipientUser.fio;

            msgContainer = new TableLayoutPanel();
            msgContainer.Margin = new Padding(0);
            msgContainer.Padding = new Padding(0, 0, 0, 7);
            msgContainer.Anchor = AnchorStyles.Bottom;
            msgContainer.AutoSize = true;
            msgContainer.MinimumSize = new Size(500, 0);
            
            messagesTopLayout_tbl.AutoScroll = false;
            messagesTopLayout_tbl.Controls.Add(msgContainer, 0, 0);

            List<MessageDB> messages = MessageDB.loadMessagesForChat(senderUser, recipientUser);
            messages.Reverse();
            foreach (MessageDB message in  messages) {
                int senderType = message.sender.user_id == senderUser.user_id ? 0 : 1;
                addMessage(message, senderType);
            }

            mainContainer_tbl.BackColor = SystemColors.GradientActiveCaption;
        }

        public void ScrollToBottom(Panel p)
        {
            using (Control c = new Control() { Parent = p, Dock = DockStyle.Bottom }) {
                p.ScrollControlIntoView(c);
                c.Parent = null;
            }
        }

        private void addChatButton(MessageDB message)
        {
            ChatButton chatButton = new ChatButton(message, senderUser);
            if (chatBtns_tbl.Height >= 60) {
                RowStyle msgRow = new RowStyle(SizeType.AutoSize);
                chatBtns_tbl.RowStyles.Add(msgRow);
                chatBtns_tbl.RowCount += 1;
            }
            chatBtns_tbl.Controls.Add(chatButton, 0, chatBtns_tbl.RowCount - 1);
            chatBtns_tbl.Height += 60;
            //MessageBox.Show(chatBtns_tbl.RowCount.ToString());

        }

        public void delete_chatButton(ChatButton chatButton)
        {
            //MessageBox.Show(chatBtns_tbl.GetRow(chatButton).ToString());
            chatBtns_tbl.RowStyles.RemoveAt(chatBtns_tbl.GetRow(chatButton));
            chatBtns_tbl.Controls.Remove(chatButton);
            chatBtns_tbl.RowCount -= 1;
            MessageDB.deleteChatFromDB(chatButton.recipientUser, chatButton.senderUser);
            this.Refresh();
        }

        private void addMessage(MessageDB message, int senderType)
        {
            ChatMessage chatMessage = new ChatMessage(message, senderType);
            RowStyle msgRow = new RowStyle(SizeType.AutoSize);
            msgContainer.RowStyles.Add(msgRow);
            msgContainer.RowCount += 1;
            msgContainer.Controls.Add(chatMessage, 0, msgContainer.RowCount - 1);
            messagesTopLayout_tbl.AutoScrollMinSize = new Size(0, msgContainer.Height);
            ScrollToBottom(messagesTopLayout_tbl);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            messagesTopLayout_tbl.AutoScroll = false;
            mainContainer_tbl.BackColor = SystemColors.Control;
            messagesTopLayout_tbl.Controls.Remove(msgContainer);
            chatBtns_tbl.Show();
            back_btn.Visible = false;
            name_lbl.Visible = false;
            newDialog_btn.Visible = true;
            buttons_flp.FlowDirection = FlowDirection.RightToLeft;
            sendMessage_tbl.Visible = false;
            title_lbl.Show();
            menu_btn.Show();

            chatBtns_tbl.Controls.Remove(chatBtns_tbl.GetControlFromPosition(0, 0));
            //MessageBox.Show(chatBtns_tbl.RowCount.ToString());
            for (int i = chatBtns_tbl.RowCount - 1; i > 0 ; i--) {
                chatBtns_tbl.Controls.Remove(chatBtns_tbl.GetControlFromPosition(0, i));
                chatBtns_tbl.RowStyles.RemoveAt(i);
            }
            chatBtns_tbl.Height = 0;
            chatBtns_tbl.RowCount = 1;
            loadUserChats();
        }

        private void sendMessage_rtb_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            int initHeight = sendMessage_rtb.Height;
            sendMessage_icon.Visible = sendMessage_rtb.Text != "";
            
            if (e.NewRectangle.Height < 100) {
                sendMessage_rtb.Height = e.NewRectangle.Height;
                int margHeight = (sendMessage_tbl.Height - sendMessage_rtb.Height) / 2;
                if (sendMessage_rtb.Lines.Count() == 0) {
                    margHeight -= 1;
                }

                sendMessage_rtb.Margin = new Padding(5, margHeight, 0, margHeight);
            } else {
                sendMessage_rtb.Height = 100;
                sendMessage_rtb.Margin = new Padding(5, 5, 0, 5);
            }
            mainContainer_tbl.RowStyles[3].Height = sendMessage_rtb.Height > 40 ? sendMessage_rtb.Height : 40;
            if (initHeight < sendMessage_rtb.Height)
                ScrollToBottom(messagesTopLayout_tbl);

        }

        private void sendMessage_icon_Click(object sender, EventArgs e)
        {
            if (sendMessage_rtb.Text.Trim() == string.Empty) {
                return;
            }
            MessageDB message = new MessageDB();
            message.addNewMessage(senderUser, recipientUser, sendMessage_rtb.Text.Trim());
            addMessage(message, 0);
            if (openedChat != null)
                openedChat.setText(sendMessage_rtb.Text);
            sendMessage_rtb.Clear();
        }

        private void mainContainer_tbl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backBtn_flp_Scroll(object sender, ScrollEventArgs e)
        {
            //backBtn_flp.Location = new Point(0, 0);
        }

        private void sendMessage_rtb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers != Keys.Shift) {
                e.Handled = true;
                sendMessage_icon_Click(sender, e);
            }
        }

        private void sendMessage_rtb_KeyDown(object sender, KeyEventArgs e) { 
        
            if (e.KeyCode == Keys.Enter && e.Modifiers != Keys.Shift) {
                e.Handled = true;
            }
        }

        private void newDialog_btn_Click(object sender, EventArgs e)
        {
            back_btn.Visible = true;
            newDialog_btn.Visible = false;
            sendMessage_tbl.Visible = false;

            buttons_flp.FlowDirection = FlowDirection.LeftToRight;
            chatBtns_tbl.Hide();
            title_lbl.Hide();
            menu_btn.Hide();
            
            msgContainer = new TableLayoutPanel();
            msgContainer.Margin = new Padding(0);
            msgContainer.Padding = new Padding(0);
            msgContainer.Anchor = AnchorStyles.Top;
            msgContainer.AutoSize = true;
            msgContainer.MinimumSize = new Size(500, 0);
            //msgContainer.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            Label userSelecting = new Label();
            userSelecting.Text = "Выберите пользователя:";
            userSelecting.Font = new Font("Comic Sans MS", 12);
            userSelecting.AutoSize = true;
            userSelecting.Anchor = AnchorStyles.Bottom;
            RowStyle msgRow = new RowStyle(SizeType.Absolute, 30);
            msgContainer.RowStyles.Add(msgRow);
            msgContainer.RowCount += 1;
            msgContainer.Controls.Add(userSelecting, 0, msgContainer.RowCount - 1);

            userSelecting_cb = new ComboBox();
            userSelecting_cb.Font = new Font("Comic Sans MS", 12);
            userSelecting_cb.AutoSize = true;
            userSelecting_cb.Anchor = AnchorStyles.Top;
            userSelecting_cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            userSelecting_cb.AutoCompleteSource = AutoCompleteSource.ListItems;
            List<UserDB> users = UserDB.loadUsers();
            users.Sort((u1, u2) => string.Compare(u1.fio, u2.fio));
            userSelecting_cb.Items.AddRange(users.ToArray());
            userSelecting_cb.DropDownHeight = 200;
            userSelecting_cb.Width = 320;
            msgRow = new RowStyle(SizeType.Absolute, 40);
            msgContainer.RowStyles.Add(msgRow);
            msgContainer.RowCount += 1;
            msgContainer.Controls.Add(userSelecting_cb, 0, msgContainer.RowCount - 1);

            Button write_btn = new Button();
            write_btn.Text = "Написать";
            write_btn.Font = new Font("Comic Sans MS", 12);
            write_btn.AutoSize = true;
            write_btn.Margin = new Padding(0);
            write_btn.Anchor = AnchorStyles.Top;
            write_btn.Click += new EventHandler(write_btn_Click);
            msgRow = new RowStyle(SizeType.Absolute, 40);
            msgContainer.RowStyles.Add(msgRow);
            msgContainer.RowCount += 1;
            msgContainer.Controls.Add(write_btn, 0, msgContainer.RowCount - 1);

            messagesTopLayout_tbl.AutoScroll = false;
            messagesTopLayout_tbl.Controls.Add(msgContainer, 0, 0);
            mainContainer_tbl.BackColor = SystemColors.Control;
        }

        void write_btn_Click(object sender, EventArgs e)
        {
            if (userSelecting_cb.SelectedIndex == -1) {
                MessageBox.Show("Неверное имя пользователя");
                return;
            }
            msgContainer.Dispose();
            recipientUser = (UserDB)userSelecting_cb.SelectedItem;
            createMessagingFlow();
        }

        void comboBox_Enter(object sender, EventArgs e)
        {
            ComboBox focusedComboBox = (ComboBox)sender;
            if (focusedComboBox.SelectedItem != null)
                prevVal = focusedComboBox.SelectedItem.ToString();
            else
                prevVal = (string)focusedComboBox.SelectedItem;
        }

        private void comboBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.FindStringExact(comboBox.Text) == -1) {
                comboBox.SelectedItem = prevVal;
                comboBox.Text = prevVal;
            }
        }
    }
}
