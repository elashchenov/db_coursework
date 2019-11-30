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
            this.buttons_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.back_btn = new System.Windows.Forms.Button();
            this.newDialog_btn = new System.Windows.Forms.Button();
            this.name_lbl = new System.Windows.Forms.Label();
            this.sendMessage_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.sendMessage_rtb = new System.Windows.Forms.RichTextBox();
            this.sendMessage_icon = new System.Windows.Forms.PictureBox();
            this.mainContainer_tbl.SuspendLayout();
            this.messagesTopLayout_tbl.SuspendLayout();
            this.buttons_flp.SuspendLayout();
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
            this.mainContainer_tbl.Controls.Add(this.buttons_flp, 0, 1);
            this.mainContainer_tbl.Controls.Add(this.sendMessage_tbl, 0, 3);
            this.mainContainer_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer_tbl.Location = new System.Drawing.Point(0, 0);
            this.mainContainer_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.mainContainer_tbl.Name = "mainContainer_tbl";
            this.mainContainer_tbl.RowCount = 4;
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainContainer_tbl.Size = new System.Drawing.Size(584, 411);
            this.mainContainer_tbl.TabIndex = 0;
            this.mainContainer_tbl.Paint += new System.Windows.Forms.PaintEventHandler(this.mainContainer_tbl_Paint);
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
            this.title_lbl.MinimumSize = new System.Drawing.Size(0, 70);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(584, 70);
            this.title_lbl.TabIndex = 8;
            this.title_lbl.Text = "Сообщения";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // messagesTopLayout_tbl
            // 
            this.messagesTopLayout_tbl.AutoScroll = true;
            this.messagesTopLayout_tbl.AutoSize = true;
            this.messagesTopLayout_tbl.ColumnCount = 1;
            this.messagesTopLayout_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messagesTopLayout_tbl.Controls.Add(this.chatBtns_tbl, 0, 0);
            this.messagesTopLayout_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesTopLayout_tbl.Location = new System.Drawing.Point(0, 113);
            this.messagesTopLayout_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.messagesTopLayout_tbl.Name = "messagesTopLayout_tbl";
            this.messagesTopLayout_tbl.RowCount = 1;
            this.messagesTopLayout_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.messagesTopLayout_tbl.Size = new System.Drawing.Size(584, 258);
            this.messagesTopLayout_tbl.TabIndex = 9;
            // 
            // chatBtns_tbl
            // 
            this.chatBtns_tbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chatBtns_tbl.AutoScroll = true;
            this.chatBtns_tbl.AutoSize = true;
            this.chatBtns_tbl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.chatBtns_tbl.ColumnCount = 1;
            this.chatBtns_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chatBtns_tbl.Location = new System.Drawing.Point(41, 0);
            this.chatBtns_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.chatBtns_tbl.MinimumSize = new System.Drawing.Size(502, 0);
            this.chatBtns_tbl.Name = "chatBtns_tbl";
            this.chatBtns_tbl.RowCount = 1;
            this.chatBtns_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.chatBtns_tbl.Size = new System.Drawing.Size(502, 2);
            this.chatBtns_tbl.TabIndex = 10;
            // 
            // buttons_flp
            // 
            this.buttons_flp.AutoSize = true;
            this.buttons_flp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttons_flp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttons_flp.Controls.Add(this.back_btn);
            this.buttons_flp.Controls.Add(this.newDialog_btn);
            this.buttons_flp.Controls.Add(this.name_lbl);
            this.buttons_flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttons_flp.Location = new System.Drawing.Point(0, 70);
            this.buttons_flp.Margin = new System.Windows.Forms.Padding(0);
            this.buttons_flp.Name = "buttons_flp";
            this.buttons_flp.Size = new System.Drawing.Size(584, 43);
            this.buttons_flp.TabIndex = 10;
            this.buttons_flp.Scroll += new System.Windows.Forms.ScrollEventHandler(this.backBtn_flp_Scroll);
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
            // newDialog_btn
            // 
            this.newDialog_btn.AutoSize = true;
            this.newDialog_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newDialog_btn.Location = new System.Drawing.Point(90, 5);
            this.newDialog_btn.Margin = new System.Windows.Forms.Padding(5);
            this.newDialog_btn.Name = "newDialog_btn";
            this.newDialog_btn.Size = new System.Drawing.Size(131, 33);
            this.newDialog_btn.TabIndex = 12;
            this.newDialog_btn.Text = "Новый диалог";
            this.newDialog_btn.UseVisualStyleBackColor = true;
            this.newDialog_btn.Click += new System.EventHandler(this.newDialog_btn_Click);
            // 
            // name_lbl
            // 
            this.name_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_lbl.Location = new System.Drawing.Point(226, 10);
            this.name_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(114, 23);
            this.name_lbl.TabIndex = 13;
            this.name_lbl.Text = "Какое-то Имя";
            this.name_lbl.Visible = false;
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
            this.sendMessage_rtb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sendMessage_rtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(116)))), ((int)(((byte)(142)))));
            this.sendMessage_rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sendMessage_rtb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendMessage_rtb.ForeColor = System.Drawing.SystemColors.Window;
            this.sendMessage_rtb.Location = new System.Drawing.Point(5, 11);
            this.sendMessage_rtb.Margin = new System.Windows.Forms.Padding(5, 11, 0, 11);
            this.sendMessage_rtb.Name = "sendMessage_rtb";
            this.sendMessage_rtb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sendMessage_rtb.Size = new System.Drawing.Size(455, 18);
            this.sendMessage_rtb.TabIndex = 0;
            this.sendMessage_rtb.Text = "";
            this.sendMessage_rtb.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.sendMessage_rtb_ContentsResized);
            this.sendMessage_rtb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendMessage_rtb_KeyDown);
            this.sendMessage_rtb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sendMessage_rtb_KeyUp);
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
            this.buttons_flp.ResumeLayout(false);
            this.buttons_flp.PerformLayout();
            this.sendMessage_tbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sendMessage_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainContainer_tbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TableLayoutPanel messagesTopLayout_tbl;
        private System.Windows.Forms.TableLayoutPanel chatBtns_tbl;
        private System.Windows.Forms.FlowLayoutPanel buttons_flp;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TableLayoutPanel sendMessage_tbl;
        private System.Windows.Forms.RichTextBox sendMessage_rtb;
        private System.Windows.Forms.PictureBox sendMessage_icon;
        private System.Windows.Forms.Button newDialog_btn;
        private System.Windows.Forms.Label name_lbl;
    }
}