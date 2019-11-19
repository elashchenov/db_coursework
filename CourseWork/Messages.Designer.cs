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
            this.messages_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.chatButton1 = new CourseWork.ChatButton();
            this.chatButton2 = new CourseWork.ChatButton();
            this.mainContainer_tbl.SuspendLayout();
            this.messagesTopLayout_tbl.SuspendLayout();
            this.messages_tbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer_tbl
            // 
            this.mainContainer_tbl.ColumnCount = 1;
            this.mainContainer_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer_tbl.Controls.Add(this.title_lbl, 0, 0);
            this.mainContainer_tbl.Controls.Add(this.messagesTopLayout_tbl, 0, 1);
            this.mainContainer_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer_tbl.Location = new System.Drawing.Point(0, 0);
            this.mainContainer_tbl.Name = "mainContainer_tbl";
            this.mainContainer_tbl.RowCount = 2;
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainContainer_tbl.Size = new System.Drawing.Size(584, 450);
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
            this.messagesTopLayout_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.messagesTopLayout_tbl.Controls.Add(this.messages_tbl, 0, 0);
            this.messagesTopLayout_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesTopLayout_tbl.Location = new System.Drawing.Point(0, 70);
            this.messagesTopLayout_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.messagesTopLayout_tbl.Name = "messagesTopLayout_tbl";
            this.messagesTopLayout_tbl.RowCount = 1;
            this.messagesTopLayout_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.messagesTopLayout_tbl.Size = new System.Drawing.Size(584, 380);
            this.messagesTopLayout_tbl.TabIndex = 9;
            // 
            // messages_tbl
            // 
            this.messages_tbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.messages_tbl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.messages_tbl.ColumnCount = 1;
            this.messages_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messages_tbl.Controls.Add(this.chatButton1, 0, 0);
            this.messages_tbl.Controls.Add(this.chatButton2, 0, 1);
            this.messages_tbl.Location = new System.Drawing.Point(41, 0);
            this.messages_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.messages_tbl.MinimumSize = new System.Drawing.Size(502, 0);
            this.messages_tbl.Name = "messages_tbl";
            this.messages_tbl.RowCount = 2;
            this.messages_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.messages_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.messages_tbl.Size = new System.Drawing.Size(502, 123);
            this.messages_tbl.TabIndex = 10;
            // 
            // chatButton1
            // 
            this.chatButton1.Location = new System.Drawing.Point(1, 1);
            this.chatButton1.Margin = new System.Windows.Forms.Padding(0);
            this.chatButton1.MaximumSize = new System.Drawing.Size(500, 60);
            this.chatButton1.MinimumSize = new System.Drawing.Size(500, 60);
            this.chatButton1.Name = "chatButton1";
            this.chatButton1.Size = new System.Drawing.Size(500, 60);
            this.chatButton1.TabIndex = 0;
            // 
            // chatButton2
            // 
            this.chatButton2.Location = new System.Drawing.Point(1, 62);
            this.chatButton2.Margin = new System.Windows.Forms.Padding(0);
            this.chatButton2.MaximumSize = new System.Drawing.Size(500, 60);
            this.chatButton2.MinimumSize = new System.Drawing.Size(500, 60);
            this.chatButton2.Name = "chatButton2";
            this.chatButton2.Size = new System.Drawing.Size(500, 60);
            this.chatButton2.TabIndex = 1;
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.mainContainer_tbl);
            this.Name = "Messages";
            this.Text = "Messages";
            this.mainContainer_tbl.ResumeLayout(false);
            this.mainContainer_tbl.PerformLayout();
            this.messagesTopLayout_tbl.ResumeLayout(false);
            this.messages_tbl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainContainer_tbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TableLayoutPanel messagesTopLayout_tbl;
        private System.Windows.Forms.TableLayoutPanel messages_tbl;
        private ChatButton chatButton1;
        private ChatButton chatButton2;
    }
}