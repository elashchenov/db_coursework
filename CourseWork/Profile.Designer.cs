namespace CourseWork
{
    partial class Profile
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
            this.wrapper = new System.Windows.Forms.TableLayoutPanel();
            this.password_gb = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.oldPassword_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newPasswordConfirm_lbl = new System.Windows.Forms.Label();
            this.oldPassword_tb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.personalInfo_gb = new System.Windows.Forms.GroupBox();
            this.userInfo_table = new System.Windows.Forms.TableLayoutPanel();
            this.name_lbl = new System.Windows.Forms.Label();
            this.gender_lbl = new System.Windows.Forms.Label();
            this.birthday_lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gender_comboBox = new System.Windows.Forms.ComboBox();
            this.birthday_flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.birthDay_cb = new System.Windows.Forms.ComboBox();
            this.birthMonth_cb = new System.Windows.Forms.ComboBox();
            this.birthYear_cb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.email_lbl = new System.Windows.Forms.Label();
            this.class_lbl = new System.Windows.Forms.Label();
            this.class_tb = new System.Windows.Forms.TextBox();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.wrapper.SuspendLayout();
            this.password_gb.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.personalInfo_gb.SuspendLayout();
            this.userInfo_table.SuspendLayout();
            this.birthday_flowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // wrapper
            // 
            this.wrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapper.ColumnCount = 1;
            this.wrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.wrapper.Controls.Add(this.password_gb, 0, 2);
            this.wrapper.Controls.Add(this.personalInfo_gb, 0, 1);
            this.wrapper.Controls.Add(this.title_lbl, 0, 0);
            this.wrapper.Location = new System.Drawing.Point(0, 0);
            this.wrapper.Name = "wrapper";
            this.wrapper.RowCount = 3;
            this.wrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.wrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.wrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.wrapper.Size = new System.Drawing.Size(564, 550);
            this.wrapper.TabIndex = 1;
            // 
            // password_gb
            // 
            this.password_gb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.password_gb.Controls.Add(this.tableLayoutPanel1);
            this.password_gb.Cursor = System.Windows.Forms.Cursors.Default;
            this.password_gb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_gb.Location = new System.Drawing.Point(20, 353);
            this.password_gb.Margin = new System.Windows.Forms.Padding(20, 20, 20, 3);
            this.password_gb.MaximumSize = new System.Drawing.Size(530, 180);
            this.password_gb.MinimumSize = new System.Drawing.Size(530, 180);
            this.password_gb.Name = "password_gb";
            this.password_gb.Padding = new System.Windows.Forms.Padding(10, 3, 10, 5);
            this.password_gb.Size = new System.Drawing.Size(530, 180);
            this.password_gb.TabIndex = 1;
            this.password_gb.TabStop = false;
            this.password_gb.Text = "Изменить пароль:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.oldPassword_lbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.newPasswordConfirm_lbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.oldPassword_tb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(510, 149);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // oldPassword_lbl
            // 
            this.oldPassword_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.oldPassword_lbl.AutoSize = true;
            this.oldPassword_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPassword_lbl.Location = new System.Drawing.Point(95, 9);
            this.oldPassword_lbl.Name = "oldPassword_lbl";
            this.oldPassword_lbl.Size = new System.Drawing.Size(106, 18);
            this.oldPassword_lbl.TabIndex = 0;
            this.oldPassword_lbl.Text = "Старый пароль:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(98, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Новый пароль:";
            // 
            // newPasswordConfirm_lbl
            // 
            this.newPasswordConfirm_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.newPasswordConfirm_lbl.AutoSize = true;
            this.newPasswordConfirm_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPasswordConfirm_lbl.Location = new System.Drawing.Point(13, 83);
            this.newPasswordConfirm_lbl.Name = "newPasswordConfirm_lbl";
            this.newPasswordConfirm_lbl.Size = new System.Drawing.Size(188, 18);
            this.newPasswordConfirm_lbl.TabIndex = 2;
            this.newPasswordConfirm_lbl.Text = "Подтвердите новый пароль:";
            // 
            // oldPassword_tb
            // 
            this.oldPassword_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.oldPassword_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPassword_tb.Location = new System.Drawing.Point(207, 7);
            this.oldPassword_tb.Name = "oldPassword_tb";
            this.oldPassword_tb.Size = new System.Drawing.Size(269, 22);
            this.oldPassword_tb.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(364, 114);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 3, 33, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Подтвердить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(207, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(207, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(269, 22);
            this.textBox3.TabIndex = 11;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // personalInfo_gb
            // 
            this.personalInfo_gb.Controls.Add(this.userInfo_table);
            this.personalInfo_gb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalInfo_gb.Location = new System.Drawing.Point(20, 70);
            this.personalInfo_gb.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.personalInfo_gb.MaximumSize = new System.Drawing.Size(530, 220);
            this.personalInfo_gb.MinimumSize = new System.Drawing.Size(530, 220);
            this.personalInfo_gb.Name = "personalInfo_gb";
            this.personalInfo_gb.Padding = new System.Windows.Forms.Padding(10, 3, 10, 5);
            this.personalInfo_gb.Size = new System.Drawing.Size(530, 220);
            this.personalInfo_gb.TabIndex = 0;
            this.personalInfo_gb.TabStop = false;
            this.personalInfo_gb.Text = "Сведения о пользователе:";
            // 
            // userInfo_table
            // 
            this.userInfo_table.ColumnCount = 2;
            this.userInfo_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.userInfo_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.userInfo_table.Controls.Add(this.name_lbl, 0, 0);
            this.userInfo_table.Controls.Add(this.gender_lbl, 0, 1);
            this.userInfo_table.Controls.Add(this.birthday_lbl, 0, 2);
            this.userInfo_table.Controls.Add(this.textBox1, 1, 0);
            this.userInfo_table.Controls.Add(this.gender_comboBox, 1, 1);
            this.userInfo_table.Controls.Add(this.birthday_flowPanel, 1, 2);
            this.userInfo_table.Controls.Add(this.button1, 1, 5);
            this.userInfo_table.Controls.Add(this.email_lbl, 0, 3);
            this.userInfo_table.Controls.Add(this.class_lbl, 0, 4);
            this.userInfo_table.Controls.Add(this.class_tb, 1, 4);
            this.userInfo_table.Controls.Add(this.email_tb, 1, 3);
            this.userInfo_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInfo_table.Location = new System.Drawing.Point(10, 26);
            this.userInfo_table.Name = "userInfo_table";
            this.userInfo_table.RowCount = 6;
            this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.userInfo_table.Size = new System.Drawing.Size(510, 189);
            this.userInfo_table.TabIndex = 2;
            // 
            // name_lbl
            // 
            this.name_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_lbl.Location = new System.Drawing.Point(110, 6);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(40, 18);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "ФИО:";
            // 
            // gender_lbl
            // 
            this.gender_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gender_lbl.AutoSize = true;
            this.gender_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gender_lbl.Location = new System.Drawing.Point(110, 37);
            this.gender_lbl.Name = "gender_lbl";
            this.gender_lbl.Size = new System.Drawing.Size(40, 18);
            this.gender_lbl.TabIndex = 1;
            this.gender_lbl.Text = "Пол:";
            // 
            // birthday_lbl
            // 
            this.birthday_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.birthday_lbl.AutoSize = true;
            this.birthday_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthday_lbl.Location = new System.Drawing.Point(43, 68);
            this.birthday_lbl.Name = "birthday_lbl";
            this.birthday_lbl.Size = new System.Drawing.Size(107, 18);
            this.birthday_lbl.TabIndex = 2;
            this.birthday_lbl.Text = "Дата рождения:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(156, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 22);
            this.textBox1.TabIndex = 4;
            // 
            // gender_comboBox
            // 
            this.gender_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_comboBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gender_comboBox.FormattingEnabled = true;
            this.gender_comboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.gender_comboBox.Location = new System.Drawing.Point(156, 34);
            this.gender_comboBox.Name = "gender_comboBox";
            this.gender_comboBox.Size = new System.Drawing.Size(320, 26);
            this.gender_comboBox.TabIndex = 5;
            // 
            // birthday_flowPanel
            // 
            this.birthday_flowPanel.Controls.Add(this.birthDay_cb);
            this.birthday_flowPanel.Controls.Add(this.birthMonth_cb);
            this.birthday_flowPanel.Controls.Add(this.birthYear_cb);
            this.birthday_flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthday_flowPanel.Location = new System.Drawing.Point(153, 62);
            this.birthday_flowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.birthday_flowPanel.Name = "birthday_flowPanel";
            this.birthday_flowPanel.Size = new System.Drawing.Size(357, 31);
            this.birthday_flowPanel.TabIndex = 7;
            // 
            // birthDay_cb
            // 
            this.birthDay_cb.DropDownHeight = 200;
            this.birthDay_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birthDay_cb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDay_cb.FormattingEnabled = true;
            this.birthDay_cb.IntegralHeight = false;
            this.birthDay_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.birthDay_cb.Location = new System.Drawing.Point(3, 3);
            this.birthDay_cb.Name = "birthDay_cb";
            this.birthDay_cb.Size = new System.Drawing.Size(85, 26);
            this.birthDay_cb.TabIndex = 6;
            // 
            // birthMonth_cb
            // 
            this.birthMonth_cb.DropDownHeight = 200;
            this.birthMonth_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birthMonth_cb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthMonth_cb.FormattingEnabled = true;
            this.birthMonth_cb.IntegralHeight = false;
            this.birthMonth_cb.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.birthMonth_cb.Location = new System.Drawing.Point(94, 3);
            this.birthMonth_cb.Name = "birthMonth_cb";
            this.birthMonth_cb.Size = new System.Drawing.Size(138, 26);
            this.birthMonth_cb.TabIndex = 7;
            // 
            // birthYear_cb
            // 
            this.birthYear_cb.DropDownHeight = 200;
            this.birthYear_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birthYear_cb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthYear_cb.FormattingEnabled = true;
            this.birthYear_cb.IntegralHeight = false;
            this.birthYear_cb.Location = new System.Drawing.Point(238, 3);
            this.birthYear_cb.Name = "birthYear_cb";
            this.birthYear_cb.Size = new System.Drawing.Size(85, 26);
            this.birthYear_cb.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(364, 155);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 33, 0);
            this.button1.MaximumSize = new System.Drawing.Size(113, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // email_lbl
            // 
            this.email_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.Location = new System.Drawing.Point(28, 99);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(122, 18);
            this.email_lbl.TabIndex = 10;
            this.email_lbl.Text = "Внутренняя почта:";
            // 
            // class_lbl
            // 
            this.class_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.class_lbl.AutoSize = true;
            this.class_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_lbl.Location = new System.Drawing.Point(101, 130);
            this.class_lbl.Name = "class_lbl";
            this.class_lbl.Size = new System.Drawing.Size(49, 18);
            this.class_lbl.TabIndex = 3;
            this.class_lbl.Text = "Класс:";
            // 
            // class_tb
            // 
            this.class_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.class_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.class_tb.Location = new System.Drawing.Point(156, 128);
            this.class_tb.Name = "class_tb";
            this.class_tb.ReadOnly = true;
            this.class_tb.Size = new System.Drawing.Size(320, 22);
            this.class_tb.TabIndex = 8;
            // 
            // email_tb
            // 
            this.email_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.email_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_tb.Location = new System.Drawing.Point(156, 97);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(320, 22);
            this.email_tb.TabIndex = 11;
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
            this.title_lbl.Size = new System.Drawing.Size(564, 70);
            this.title_lbl.TabIndex = 2;
            this.title_lbl.Text = "Профиль";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 561);
            this.Controls.Add(this.wrapper);
            this.Name = "Profile";
            this.Text = "Профиль пользователя";
            this.Resize += new System.EventHandler(this.Profile_Resize);
            this.wrapper.ResumeLayout(false);
            this.wrapper.PerformLayout();
            this.password_gb.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.personalInfo_gb.ResumeLayout(false);
            this.userInfo_table.ResumeLayout(false);
            this.userInfo_table.PerformLayout();
            this.birthday_flowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel wrapper;
        private System.Windows.Forms.GroupBox personalInfo_gb;
        private System.Windows.Forms.GroupBox password_gb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label oldPassword_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label newPasswordConfirm_lbl;
        private System.Windows.Forms.TextBox oldPassword_tb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TableLayoutPanel userInfo_table;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label gender_lbl;
        private System.Windows.Forms.Label birthday_lbl;
        private System.Windows.Forms.Label class_lbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox gender_comboBox;
        private System.Windows.Forms.FlowLayoutPanel birthday_flowPanel;
        private System.Windows.Forms.ComboBox birthDay_cb;
        private System.Windows.Forms.ComboBox birthMonth_cb;
        private System.Windows.Forms.ComboBox birthYear_cb;
        private System.Windows.Forms.TextBox class_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.TextBox email_tb;
    }
}