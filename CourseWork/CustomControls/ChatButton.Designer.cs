namespace CourseWork
{
    partial class ChatButton
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainChatLayout_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.deleteChat_btn = new System.Windows.Forms.PictureBox();
            this.user_time_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.time_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.message_lbl = new System.Windows.Forms.Label();
            this.unreadMsgIcon = new CourseWork.CustomControls.UnreadMsgIcon();
            this.mainChatLayout_tbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteChat_btn)).BeginInit();
            this.user_time_tbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainChatLayout_tbl
            // 
            this.mainChatLayout_tbl.ColumnCount = 2;
            this.mainChatLayout_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainChatLayout_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainChatLayout_tbl.Controls.Add(this.deleteChat_btn, 1, 0);
            this.mainChatLayout_tbl.Controls.Add(this.user_time_tbl, 0, 0);
            this.mainChatLayout_tbl.Controls.Add(this.message_lbl, 0, 1);
            this.mainChatLayout_tbl.Controls.Add(this.unreadMsgIcon, 1, 1);
            this.mainChatLayout_tbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainChatLayout_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainChatLayout_tbl.Location = new System.Drawing.Point(0, 0);
            this.mainChatLayout_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.mainChatLayout_tbl.MaximumSize = new System.Drawing.Size(500, 60);
            this.mainChatLayout_tbl.MinimumSize = new System.Drawing.Size(500, 60);
            this.mainChatLayout_tbl.Name = "mainChatLayout_tbl";
            this.mainChatLayout_tbl.RowCount = 2;
            this.mainChatLayout_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainChatLayout_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainChatLayout_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainChatLayout_tbl.Size = new System.Drawing.Size(500, 60);
            this.mainChatLayout_tbl.TabIndex = 0;
            this.mainChatLayout_tbl.Click += new System.EventHandler(this.mainChatLayout_tbl_Click);
            this.mainChatLayout_tbl.MouseEnter += new System.EventHandler(this.mainChatLayout_tbl_MouseEnter);
            this.mainChatLayout_tbl.MouseLeave += new System.EventHandler(this.mainChatLayout_tbl_MouseLeave);
            this.mainChatLayout_tbl.MouseHover += new System.EventHandler(this.mainChatLayout_tbl_MouseEnter);
            // 
            // deleteChat_btn
            // 
            this.deleteChat_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteChat_btn.Location = new System.Drawing.Point(479, 12);
            this.deleteChat_btn.Margin = new System.Windows.Forms.Padding(9, 12, 9, 10);
            this.deleteChat_btn.Name = "deleteChat_btn";
            this.deleteChat_btn.Size = new System.Drawing.Size(12, 8);
            this.deleteChat_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deleteChat_btn.TabIndex = 4;
            this.deleteChat_btn.TabStop = false;
            this.deleteChat_btn.WaitOnLoad = true;
            this.deleteChat_btn.Click += new System.EventHandler(this.deleteChat_btn_Click);
            this.deleteChat_btn.MouseEnter += new System.EventHandler(this.deleteChat_btn_MouseEnter);
            this.deleteChat_btn.MouseLeave += new System.EventHandler(this.deleteChat_btn_MouseLeave);
            // 
            // user_time_tbl
            // 
            this.user_time_tbl.ColumnCount = 2;
            this.user_time_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.user_time_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.user_time_tbl.Controls.Add(this.time_lbl, 1, 0);
            this.user_time_tbl.Controls.Add(this.name_lbl, 0, 0);
            this.user_time_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_time_tbl.Location = new System.Drawing.Point(0, 0);
            this.user_time_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.user_time_tbl.Name = "user_time_tbl";
            this.user_time_tbl.RowCount = 1;
            this.user_time_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.user_time_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.user_time_tbl.Size = new System.Drawing.Size(470, 30);
            this.user_time_tbl.TabIndex = 0;
            this.user_time_tbl.MouseEnter += new System.EventHandler(this.mainChatLayout_tbl_MouseEnter);
            this.user_time_tbl.MouseLeave += new System.EventHandler(this.mainChatLayout_tbl_MouseLeave);
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time_lbl.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_lbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.time_lbl.Location = new System.Drawing.Point(410, 0);
            this.time_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.time_lbl.Size = new System.Drawing.Size(60, 30);
            this.time_lbl.TabIndex = 0;
            this.time_lbl.Text = "18:12";
            this.time_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.time_lbl.Click += new System.EventHandler(this.mainChatLayout_tbl_Click);
            this.time_lbl.MouseEnter += new System.EventHandler(this.mainChatLayout_tbl_MouseEnter);
            this.time_lbl.MouseLeave += new System.EventHandler(this.mainChatLayout_tbl_MouseLeave);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_lbl.Location = new System.Drawing.Point(0, 0);
            this.name_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(410, 30);
            this.name_lbl.TabIndex = 1;
            this.name_lbl.Text = "Иванов Иван Иванович";
            this.name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.name_lbl.Click += new System.EventHandler(this.mainChatLayout_tbl_Click);
            this.name_lbl.MouseEnter += new System.EventHandler(this.mainChatLayout_tbl_MouseEnter);
            this.name_lbl.MouseLeave += new System.EventHandler(this.mainChatLayout_tbl_MouseLeave);
            // 
            // message_lbl
            // 
            this.message_lbl.AutoEllipsis = true;
            this.message_lbl.AutoSize = true;
            this.message_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.message_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.message_lbl.Location = new System.Drawing.Point(0, 30);
            this.message_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.message_lbl.Name = "message_lbl";
            this.message_lbl.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.message_lbl.Size = new System.Drawing.Size(470, 30);
            this.message_lbl.TabIndex = 1;
            this.message_lbl.Text = "Наш курс подходит к концу! Сегодня вам доступен экзамен по модулю 2. Срок сдачи к" +
    "онтрольного испытания – 9 декабря (03:00 МСК).";
            this.message_lbl.UseCompatibleTextRendering = true;
            this.message_lbl.Click += new System.EventHandler(this.mainChatLayout_tbl_Click);
            this.message_lbl.MouseEnter += new System.EventHandler(this.mainChatLayout_tbl_MouseEnter);
            this.message_lbl.MouseLeave += new System.EventHandler(this.mainChatLayout_tbl_MouseLeave);
            // 
            // unreadMsgIcon
            // 
            this.unreadMsgIcon._BackColor = System.Drawing.SystemColors.Highlight;
            this.unreadMsgIcon.AutoEllipsis = true;
            this.unreadMsgIcon.AutoSize = true;
            this.unreadMsgIcon.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unreadMsgIcon.ForeColor = System.Drawing.SystemColors.Window;
            this.unreadMsgIcon.Location = new System.Drawing.Point(475, 30);
            this.unreadMsgIcon.Margin = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.unreadMsgIcon.MaximumSize = new System.Drawing.Size(18, 18);
            this.unreadMsgIcon.MinimumSize = new System.Drawing.Size(18, 18);
            this.unreadMsgIcon.Name = "unreadMsgIcon";
            this.unreadMsgIcon.Size = new System.Drawing.Size(18, 18);
            this.unreadMsgIcon.TabIndex = 5;
            this.unreadMsgIcon.Text = "1";
            this.unreadMsgIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.unreadMsgIcon.UseCompatibleTextRendering = true;
            this.unreadMsgIcon.Click += new System.EventHandler(this.mainChatLayout_tbl_Click);
            this.unreadMsgIcon.MouseEnter += new System.EventHandler(this.mainChatLayout_tbl_MouseEnter);
            this.unreadMsgIcon.MouseLeave += new System.EventHandler(this.deleteChat_btn_MouseLeave);
            // 
            // ChatButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainChatLayout_tbl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(500, 60);
            this.Name = "ChatButton";
            this.Size = new System.Drawing.Size(500, 60);
            this.mainChatLayout_tbl.ResumeLayout(false);
            this.mainChatLayout_tbl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteChat_btn)).EndInit();
            this.user_time_tbl.ResumeLayout(false);
            this.user_time_tbl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainChatLayout_tbl;
        private System.Windows.Forms.TableLayoutPanel user_time_tbl;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label message_lbl;
        private System.Windows.Forms.PictureBox deleteChat_btn;
        private CustomControls.UnreadMsgIcon unreadMsgIcon;
    }
}
