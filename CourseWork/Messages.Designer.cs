namespace CourseWork
{
    partial class Messages
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainContainer_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.messagesTopLayout_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.chatBtns_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.chatButton1 = new CourseWork.ChatButton();
            this.chatButton2 = new CourseWork.ChatButton();
            this.backBtn_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.back_btn = new System.Windows.Forms.Button();
            this.sendMessage_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.sendMessage_rtb = new System.Windows.Forms.RichTextBox();
            this.sendMessage_icon = new System.Windows.Forms.PictureBox();
            this.mainContainer_tbl.SuspendLayout();
            this.messagesTopLayout_tbl.SuspendLayout();
            this.chatBtns_tbl.SuspendLayout();
            this.backBtn_flp.SuspendLayout();
            this.sendMessage_tbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendMessage_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer_tbl
            // 
            this.mainContainer_tbl.ColumnCount = 1;
            this.mainContainer_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer_tbl.Controls.Add(this.title_lbl, 0, 0);
            this.mainContainer_tbl.Controls.Add(this.messagesTopLayout_tbl, 0, 2);
            this.mainContainer_tbl.Controls.Add(this.backBtn_flp, 0, 1);
            this.mainContainer_tbl.Controls.Add(this.sendMessage_tbl, 0, 3);
            this.mainContainer_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer_tbl.Location = new System.Drawing.Point(0, 0);
            this.mainContainer_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.mainContainer_tbl.Name = "mainContainer_tbl";
            this.mainContainer_tbl.RowCount = 4;
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainContainer_tbl.Size = new System.Drawing.Size(584, 411);
            this.mainContainer_tbl.TabIndex = 0;
            this.mainContainer_tbl.Resize += new System.EventHandler(this.mainContainer_tbl_Resize);
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.title_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title_lbl.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_lbl.Location = new System.Drawing.Point(0, 0);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(584, 70);
            this.title_lbl.TabIndex = 8;
            this.title_lbl.Text = "Сообщения";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // messagesTopLayout_tbl
            // 
            this.messagesTopLayout_tbl.AutoScroll = true;
            this.messagesTopLayout_tbl.ColumnCount = 1;
            this.messagesTopLayout_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messagesTopLayout_tbl.Controls.Add(this.chatBtns_tbl, 0, 0);
            this.messagesTopLayout_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesTopLayout_tbl.Location = new System.Drawing.Point(0, 113);
            this.messagesTopLayout_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.messagesTopLayout_tbl.Name = "messagesTopLayout_tbl";
            this.messagesTopLayout_tbl.RowCount = 1;
            this.messagesTopLayout_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messagesTopLayout_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 258F));
            this.messagesTopLayout_tbl.Size = new System.Drawing.Size(584, 258);
            this.messagesTopLayout_tbl.TabIndex = 9;
            // 
            // chatBtns_tbl
            // 
            this.chatBtns_tbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chatBtns_tbl.AutoSize = true;
            this.chatBtns_tbl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.chatBtns_tbl.ColumnCount = 1;
            this.chatBtns_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chatBtns_tbl.Controls.Add(this.chatButton1, 0, 0);
            this.chatBtns_tbl.Controls.Add(this.chatButton2, 0, 1);
            this.chatBtns_tbl.Location = new System.Drawing.Point(41, 0);
            this.chatBtns_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.chatBtns_tbl.MinimumSize = new System.Drawing.Size(502, 0);
            this.chatBtns_tbl.Name = "chatBtns_tbl";
            this.chatBtns_tbl.RowCount = 2;
            this.chatBtns_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.chatBtns_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.chatBtns_tbl.Size = new System.Drawing.Size(502, 123);
            this.chatBtns_tbl.TabIndex = 10;
            // 
            // chatButton1
            // 
            this.chatButton1.AutoSize = true;
            this.chatButton1.Location = new System.Drawing.Point(1, 1);
            this.chatButton1.Margin = new System.Windows.Forms.Padding(0);
            this.chatButton1.MinimumSize = new System.Drawing.Size(500, 60);
            this.chatButton1.Name = "chatButton1";
            this.chatButton1.Size = new System.Drawing.Size(500, 60);
            this.chatButton1.TabIndex = 0;
            // 
            // chatButton2
            // 
            this.chatButton2.Location = new System.Drawing.Point(1, 62);
            this.chatButton2.Margin = new System.Windows.Forms.Padding(0);
            this.chatButton2.MinimumSize = new System.Drawing.Size(500, 60);
            this.chatButton2.Name = "chatButton2";
            this.chatButton2.Size = new System.Drawing.Size(500, 60);
            this.chatButton2.TabIndex = 1;
            // 
            // backBtn_flp
            // 
            this.backBtn_flp.AutoSize = true;
            this.backBtn_flp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn_flp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.backBtn_flp.Controls.Add(this.back_btn);
            this.backBtn_flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backBtn_flp.Location = new System.Drawing.Point(0, 70);
            this.backBtn_flp.Margin = new System.Windows.Forms.Padding(0);
            this.backBtn_flp.Name = "backBtn_flp";
            this.backBtn_flp.Size = new System.Drawing.Size(584, 43);
            this.backBtn_flp.TabIndex = 10;
            // 
            // back_btn
            // 
            this.back_btn.AutoSize = true;
            this.back_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_btn.Location = new System.Drawing.Point(5, 5);
            this.back_btn.Margin = new System.Windows.Forms.Padding(5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 33);
            this.back_btn.TabIndex = 11;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Visible = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // sendMessage_tbl
            // 
            this.sendMessage_tbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sendMessage_tbl.AutoSize = true;
            this.sendMessage_tbl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendMessage_tbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(116)))), ((int)(((byte)(142)))));
            this.sendMessage_tbl.ColumnCount = 2;
            this.sendMessage_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sendMessage_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.sendMessage_tbl.Controls.Add(this.sendMessage_rtb, 0, 0);
            this.sendMessage_tbl.Controls.Add(this.sendMessage_icon, 1, 0);
            this.sendMessage_tbl.Location = new System.Drawing.Point(42, 371);
            this.sendMessage_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.sendMessage_tbl.MaximumSize = new System.Drawing.Size(500, 100);
            this.sendMessage_tbl.MinimumSize = new System.Drawing.Size(500, 40);
            this.sendMessage_tbl.Name = "sendMessage_tbl";
            this.sendMessage_tbl.RowCount = 1;
            this.sendMessage_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sendMessage_tbl.Size = new System.Drawing.Size(500, 40);
            this.sendMessage_tbl.TabIndex = 11;
            this.sendMessage_tbl.Visible = false;
            // 
            // sendMessage_rtb
            // 
            this.sendMessage_rtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendMessage_rtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(116)))), ((int)(((byte)(142)))));
            this.sendMessage_rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sendMessage_rtb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendMessage_rtb.ForeColor = System.Drawing.SystemColors.Window;
            this.sendMessage_rtb.Location = new System.Drawing.Point(0, 0);
            this.sendMessage_rtb.Margin = new System.Windows.Forms.Padding(0);
            this.sendMessage_rtb.Name = "sendMessage_rtb";
            this.sendMessage_rtb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sendMessage_rtb.Size = new System.Drawing.Size(460, 40);
            this.sendMessage_rtb.TabIndex = 0;
            this.sendMessage_rtb.Text = "";
            this.sendMessage_rtb.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.sendMessage_rtb_ContentsResized);
            // 
            // sendMessage_icon
            // 
            this.sendMessage_icon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sendMessage_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendMessage_icon.Image = global::CourseWork.Properties.Resources.send_msg;
            this.sendMessage_icon.Location = new System.Drawing.Point(465, 5);
            this.sendMessage_icon.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.sendMessage_icon.Name = "sendMessage_icon";
            this.sendMessage_icon.Size = new System.Drawing.Size(30, 30);
            this.sendMessage_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sendMessage_icon.TabIndex = 1;
            this.sendMessage_icon.TabStop = false;
            this.sendMessage_icon.Visible = false;
            this.sendMessage_icon.Click += new System.EventHandler(this.sendMessage_icon_Click);
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.mainContainer_tbl);
            this.Name = "Messages";
            this.Text = "Messages";
            this.mainContainer_tbl.ResumeLayout(false);
            this.mainContainer_tbl.PerformLayout();
            this.messagesTopLayout_tbl.ResumeLayout(false);
            this.messagesTopLayout_tbl.PerformLayout();
            this.chatBtns_tbl.ResumeLayout(false);
            this.chatBtns_tbl.PerformLayout();
            this.backBtn_flp.ResumeLayout(false);
            this.backBtn_flp.PerformLayout();
            this.sendMessage_tbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sendMessage_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainContainer_tbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TableLayoutPanel messagesTopLayout_tbl;
        private System.Windows.Forms.TableLayoutPanel chatBtns_tbl;
        private ChatButton chatButton1;
        private ChatButton chatButton2;
        private System.Windows.Forms.FlowLayoutPanel backBtn_flp;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TableLayoutPanel sendMessage_tbl;
        private System.Windows.Forms.RichTextBox sendMessage_rtb;
        private System.Windows.Forms.PictureBox sendMessage_icon;
    }
}