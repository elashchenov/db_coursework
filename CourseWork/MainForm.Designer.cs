namespace CourseWork
{
    partial class MainForm
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
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.user_split = new System.Windows.Forms.SplitContainer();
            this.userMenu_wrapper = new System.Windows.Forms.TableLayoutPanel();
            this.actionsMenu_table = new System.Windows.Forms.TableLayoutPanel();
            this.messages_lbl = new System.Windows.Forms.LinkLabel();
            this.logOut_lbl = new System.Windows.Forms.LinkLabel();
            this.acadPerform_lbl = new System.Windows.Forms.LinkLabel();
            this.profile_lbl = new System.Windows.Forms.LinkLabel();
            this.shedule_lbl = new System.Windows.Forms.LinkLabel();
            this.homework_lbl = new System.Windows.Forms.LinkLabel();
            this.wrapper = new CourseWork.CustomPanel();
            this.menu_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.user_split)).BeginInit();
            this.user_split.Panel1.SuspendLayout();
            this.user_split.Panel2.SuspendLayout();
            this.user_split.SuspendLayout();
            this.userMenu_wrapper.SuspendLayout();
            this.actionsMenu_table.SuspendLayout();
            this.wrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // user_split
            // 
            this.user_split.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.user_split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_split.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.user_split.IsSplitterFixed = true;
            this.user_split.Location = new System.Drawing.Point(0, 0);
            this.user_split.Name = "user_split";
            // 
            // user_split.Panel1
            // 
            this.user_split.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.user_split.Panel1.Controls.Add(this.userMenu_wrapper);
            // 
            // user_split.Panel2
            // 
            this.user_split.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.user_split.Panel2.Controls.Add(this.wrapper);
            this.user_split.Size = new System.Drawing.Size(824, 441);
            this.user_split.SplitterDistance = 169;
            this.user_split.SplitterWidth = 1;
            this.user_split.TabIndex = 0;
            this.user_split.TabStop = false;
            // 
            // userMenu_wrapper
            // 
            this.userMenu_wrapper.ColumnCount = 1;
            this.userMenu_wrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userMenu_wrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userMenu_wrapper.Controls.Add(this.actionsMenu_table, 0, 0);
            this.userMenu_wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userMenu_wrapper.Location = new System.Drawing.Point(0, 0);
            this.userMenu_wrapper.Name = "userMenu_wrapper";
            this.userMenu_wrapper.RowCount = 1;
            this.userMenu_wrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userMenu_wrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userMenu_wrapper.Size = new System.Drawing.Size(169, 441);
            this.userMenu_wrapper.TabIndex = 1;
            // 
            // actionsMenu_table
            // 
            this.actionsMenu_table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionsMenu_table.ColumnCount = 1;
            this.actionsMenu_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.actionsMenu_table.Controls.Add(this.messages_lbl, 0, 4);
            this.actionsMenu_table.Controls.Add(this.logOut_lbl, 0, 4);
            this.actionsMenu_table.Controls.Add(this.acadPerform_lbl, 0, 3);
            this.actionsMenu_table.Controls.Add(this.profile_lbl, 0, 0);
            this.actionsMenu_table.Controls.Add(this.shedule_lbl, 0, 1);
            this.actionsMenu_table.Controls.Add(this.homework_lbl, 0, 2);
            this.actionsMenu_table.Location = new System.Drawing.Point(0, 0);
            this.actionsMenu_table.Margin = new System.Windows.Forms.Padding(0);
            this.actionsMenu_table.Name = "actionsMenu_table";
            this.actionsMenu_table.RowCount = 6;
            this.actionsMenu_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.actionsMenu_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.actionsMenu_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.actionsMenu_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.actionsMenu_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.actionsMenu_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.actionsMenu_table.Size = new System.Drawing.Size(169, 180);
            this.actionsMenu_table.TabIndex = 1;
            // 
            // messages_lbl
            // 
            this.messages_lbl.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.messages_lbl.AutoSize = true;
            this.messages_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.messages_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messages_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messages_lbl.LinkArea = new System.Windows.Forms.LinkArea(0, 9);
            this.messages_lbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.messages_lbl.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.messages_lbl.Location = new System.Drawing.Point(0, 120);
            this.messages_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.messages_lbl.Name = "messages_lbl";
            this.messages_lbl.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.messages_lbl.Size = new System.Drawing.Size(169, 30);
            this.messages_lbl.TabIndex = 6;
            this.messages_lbl.TabStop = true;
            this.messages_lbl.Text = "Сообщения";
            this.messages_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.messages_lbl.VisitedLinkColor = System.Drawing.Color.CornflowerBlue;
            this.messages_lbl.MouseEnter += new System.EventHandler(this.mainMenuLable_MouseEnter);
            this.messages_lbl.MouseLeave += new System.EventHandler(this.mainMenuLable_MouseLeave);
            // 
            // logOut_lbl
            // 
            this.logOut_lbl.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.logOut_lbl.AutoSize = true;
            this.logOut_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logOut_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logOut_lbl.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
            this.logOut_lbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.logOut_lbl.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.logOut_lbl.Location = new System.Drawing.Point(0, 150);
            this.logOut_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.logOut_lbl.Name = "logOut_lbl";
            this.logOut_lbl.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.logOut_lbl.Size = new System.Drawing.Size(169, 30);
            this.logOut_lbl.TabIndex = 5;
            this.logOut_lbl.TabStop = true;
            this.logOut_lbl.Text = "Выйти";
            this.logOut_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOut_lbl.VisitedLinkColor = System.Drawing.Color.CornflowerBlue;
            this.logOut_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logOut_lbl_LinkClicked);
            this.logOut_lbl.MouseEnter += new System.EventHandler(this.mainMenuLable_MouseEnter);
            this.logOut_lbl.MouseLeave += new System.EventHandler(this.mainMenuLable_MouseLeave);
            // 
            // acadPerform_lbl
            // 
            this.acadPerform_lbl.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.acadPerform_lbl.AutoSize = true;
            this.acadPerform_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acadPerform_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acadPerform_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acadPerform_lbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.acadPerform_lbl.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.acadPerform_lbl.Location = new System.Drawing.Point(0, 90);
            this.acadPerform_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.acadPerform_lbl.Name = "acadPerform_lbl";
            this.acadPerform_lbl.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.acadPerform_lbl.Size = new System.Drawing.Size(169, 30);
            this.acadPerform_lbl.TabIndex = 4;
            this.acadPerform_lbl.TabStop = true;
            this.acadPerform_lbl.Text = "Успеваемость";
            this.acadPerform_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.acadPerform_lbl.VisitedLinkColor = System.Drawing.Color.CornflowerBlue;
            this.acadPerform_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.acadPerform_lbl_LinkClicked);
            this.acadPerform_lbl.Click += new System.EventHandler(this.acadPerform_lbl_LinkClicked);
            this.acadPerform_lbl.MouseEnter += new System.EventHandler(this.mainMenuLable_MouseEnter);
            this.acadPerform_lbl.MouseLeave += new System.EventHandler(this.mainMenuLable_MouseLeave);
            // 
            // profile_lbl
            // 
            this.profile_lbl.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.profile_lbl.AutoSize = true;
            this.profile_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profile_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profile_lbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.profile_lbl.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.profile_lbl.Location = new System.Drawing.Point(0, 0);
            this.profile_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.profile_lbl.Name = "profile_lbl";
            this.profile_lbl.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.profile_lbl.Size = new System.Drawing.Size(169, 30);
            this.profile_lbl.TabIndex = 1;
            this.profile_lbl.TabStop = true;
            this.profile_lbl.Text = "Профиль";
            this.profile_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profile_lbl.VisitedLinkColor = System.Drawing.Color.CornflowerBlue;
            this.profile_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.profile_lbl_LinkClicked);
            this.profile_lbl.Click += new System.EventHandler(this.profile_lbl_LinkClicked);
            this.profile_lbl.MouseEnter += new System.EventHandler(this.mainMenuLable_MouseEnter);
            this.profile_lbl.MouseLeave += new System.EventHandler(this.mainMenuLable_MouseLeave);
            // 
            // shedule_lbl
            // 
            this.shedule_lbl.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.shedule_lbl.AutoSize = true;
            this.shedule_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shedule_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shedule_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shedule_lbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.shedule_lbl.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.shedule_lbl.Location = new System.Drawing.Point(0, 30);
            this.shedule_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.shedule_lbl.Name = "shedule_lbl";
            this.shedule_lbl.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.shedule_lbl.Size = new System.Drawing.Size(169, 30);
            this.shedule_lbl.TabIndex = 2;
            this.shedule_lbl.TabStop = true;
            this.shedule_lbl.Text = "Расписание";
            this.shedule_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shedule_lbl.VisitedLinkColor = System.Drawing.Color.CornflowerBlue;
            this.shedule_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.shedule_lbl_LinkClicked);
            this.shedule_lbl.Click += new System.EventHandler(this.shedule_lbl_LinkClicked);
            this.shedule_lbl.MouseEnter += new System.EventHandler(this.mainMenuLable_MouseEnter);
            this.shedule_lbl.MouseLeave += new System.EventHandler(this.mainMenuLable_MouseLeave);
            // 
            // homework_lbl
            // 
            this.homework_lbl.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.homework_lbl.AutoSize = true;
            this.homework_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homework_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homework_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homework_lbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.homework_lbl.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.homework_lbl.Location = new System.Drawing.Point(0, 60);
            this.homework_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.homework_lbl.Name = "homework_lbl";
            this.homework_lbl.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.homework_lbl.Size = new System.Drawing.Size(169, 30);
            this.homework_lbl.TabIndex = 3;
            this.homework_lbl.TabStop = true;
            this.homework_lbl.Text = "Домашнее задание";
            this.homework_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homework_lbl.VisitedLinkColor = System.Drawing.Color.CornflowerBlue;
            this.homework_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homework_lbl_LinkClicked);
            this.homework_lbl.Click += new System.EventHandler(this.homework_lbl_LinkClicked);
            this.homework_lbl.MouseEnter += new System.EventHandler(this.mainMenuLable_MouseEnter);
            this.homework_lbl.MouseLeave += new System.EventHandler(this.mainMenuLable_MouseLeave);
            // 
            // wrapper
            // 
            this.wrapper.AutoScroll = true;
            this.wrapper.Controls.Add(this.menu_btn);
            this.wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapper.Location = new System.Drawing.Point(0, 0);
            this.wrapper.Name = "wrapper";
            this.wrapper.Size = new System.Drawing.Size(654, 441);
            this.wrapper.TabIndex = 1;
            // 
            // menu_btn
            // 
            this.menu_btn.BackColor = System.Drawing.SystemColors.Control;
            this.menu_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_btn.Image = ((System.Drawing.Image)(resources.GetObject("menu_btn.Image")));
            this.menu_btn.Location = new System.Drawing.Point(3, 3);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(35, 30);
            this.menu_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu_btn.TabIndex = 2;
            this.menu_btn.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(824, 441);
            this.Controls.Add(this.user_split);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(840, 194);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.user_split.Panel1.ResumeLayout(false);
            this.user_split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_split)).EndInit();
            this.user_split.ResumeLayout(false);
            this.userMenu_wrapper.ResumeLayout(false);
            this.actionsMenu_table.ResumeLayout(false);
            this.actionsMenu_table.PerformLayout();
            this.wrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer user_split;
        private System.Windows.Forms.TableLayoutPanel userMenu_wrapper;
        private System.Windows.Forms.TableLayoutPanel actionsMenu_table;
        private System.Windows.Forms.LinkLabel logOut_lbl;
        private System.Windows.Forms.LinkLabel acadPerform_lbl;
        private System.Windows.Forms.LinkLabel profile_lbl;
        private System.Windows.Forms.LinkLabel shedule_lbl;
        private System.Windows.Forms.LinkLabel homework_lbl;
        private System.Windows.Forms.PictureBox menu_btn;
        private CustomPanel wrapper;
        private System.Windows.Forms.LinkLabel messages_lbl;
    }
}