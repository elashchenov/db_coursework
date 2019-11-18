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
            this.userProfile_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.loginSettings_gb = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.login_lbl = new System.Windows.Forms.Label();
            this.oldPassword_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newPasswordConfirm_lbl = new System.Windows.Forms.Label();
            this.oldPassword_tb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.login_tb = new System.Windows.Forms.TextBox();
            this.personalInfo_gb = new System.Windows.Forms.GroupBox();
            this.userInfo_table = new System.Windows.Forms.TableLayoutPanel();
            this.name_lbl = new System.Windows.Forms.Label();
            this.gender_lbl = new System.Windows.Forms.Label();
            this.birthday_lbl = new System.Windows.Forms.Label();
            this.fio_tb = new System.Windows.Forms.TextBox();
            this.birthday_flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.birthDay_cb = new CourseWork.CustomComboBox();
            this.birthMonth_cb = new CourseWork.CustomComboBox();
            this.birthYear_cb = new CourseWork.CustomComboBox();
            this.personalInfoOk_btn = new System.Windows.Forms.Button();
            this.email_lbl = new System.Windows.Forms.Label();
            this.class_lbl = new System.Windows.Forms.Label();
            this.class_tb = new System.Windows.Forms.TextBox();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.personData_lbl = new System.Windows.Forms.Label();
            this.personDataAdd_lbl = new System.Windows.Forms.LinkLabel();
            this.gender_comboBox = new CourseWork.CustomComboBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.userProfile_tbl.SuspendLayout();
            this.loginSettings_gb.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.personalInfo_gb.SuspendLayout();
            this.userInfo_table.SuspendLayout();
            this.birthday_flowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userProfile_tbl
            // 
            this.userProfile_tbl.AutoScroll = true;
            this.userProfile_tbl.ColumnCount = 1;
            this.userProfile_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.userProfile_tbl.Controls.Add(this.loginSettings_gb, 0, 2);
            this.userProfile_tbl.Controls.Add(this.personalInfo_gb, 0, 1);
            this.userProfile_tbl.Controls.Add(this.title_lbl, 0, 0);
            this.userProfile_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userProfile_tbl.Location = new System.Drawing.Point(0, 0);
            this.userProfile_tbl.Name = "userProfile_tbl";
            this.userProfile_tbl.RowCount = 4;
            this.userProfile_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.userProfile_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.userProfile_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.userProfile_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.userProfile_tbl.Size = new System.Drawing.Size(607, 395);
            this.userProfile_tbl.TabIndex = 3;
            this.userProfile_tbl.Resize += new System.EventHandler(this.userProfile_tbl_Resize);
            // 
            // loginSettings_gb
            // 
            this.loginSettings_gb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loginSettings_gb.Controls.Add(this.tableLayoutPanel1);
            this.loginSettings_gb.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginSettings_gb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginSettings_gb.Location = new System.Drawing.Point(0, 423);
            this.loginSettings_gb.Margin = new System.Windows.Forms.Padding(0, 20, 0, 3);
            this.loginSettings_gb.MaximumSize = new System.Drawing.Size(530, 230);
            this.loginSettings_gb.MinimumSize = new System.Drawing.Size(530, 230);
            this.loginSettings_gb.Name = "loginSettings_gb";
            this.loginSettings_gb.Padding = new System.Windows.Forms.Padding(10, 3, 10, 5);
            this.loginSettings_gb.Size = new System.Drawing.Size(530, 230);
            this.loginSettings_gb.TabIndex = 1;
            this.loginSettings_gb.TabStop = false;
            this.loginSettings_gb.Text = "Вход в аккаунт:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.login_lbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.oldPassword_lbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.newPasswordConfirm_lbl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.oldPassword_tb, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.login_tb, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(510, 199);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // login_lbl
            // 
            this.login_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.login_lbl.AutoSize = true;
            this.login_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_lbl.Location = new System.Drawing.Point(150, 10);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(51, 18);
            this.login_lbl.TabIndex = 12;
            this.login_lbl.Text = "Логин:";
            // 
            // oldPassword_lbl
            // 
            this.oldPassword_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.oldPassword_lbl.AutoSize = true;
            this.oldPassword_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPassword_lbl.Location = new System.Drawing.Point(95, 49);
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
            this.label2.Location = new System.Drawing.Point(98, 88);
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
            this.newPasswordConfirm_lbl.Location = new System.Drawing.Point(13, 127);
            this.newPasswordConfirm_lbl.Name = "newPasswordConfirm_lbl";
            this.newPasswordConfirm_lbl.Size = new System.Drawing.Size(188, 18);
            this.newPasswordConfirm_lbl.TabIndex = 2;
            this.newPasswordConfirm_lbl.Text = "Подтвердите новый пароль:";
            // 
            // oldPassword_tb
            // 
            this.oldPassword_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.oldPassword_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPassword_tb.Location = new System.Drawing.Point(207, 47);
            this.oldPassword_tb.Name = "oldPassword_tb";
            this.oldPassword_tb.Size = new System.Drawing.Size(269, 22);
            this.oldPassword_tb.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(364, 159);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 3, 33, 5);
            this.button2.MinimumSize = new System.Drawing.Size(0, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Подтвердить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(207, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(207, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(269, 22);
            this.textBox3.TabIndex = 11;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // login_tb
            // 
            this.login_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.login_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_tb.Location = new System.Drawing.Point(207, 8);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(269, 22);
            this.login_tb.TabIndex = 13;
            // 
            // personalInfo_gb
            // 
            this.personalInfo_gb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.personalInfo_gb.Controls.Add(this.userInfo_table);
            this.personalInfo_gb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalInfo_gb.Location = new System.Drawing.Point(0, 100);
            this.personalInfo_gb.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.personalInfo_gb.MaximumSize = new System.Drawing.Size(530, 310);
            this.personalInfo_gb.MinimumSize = new System.Drawing.Size(530, 310);
            this.personalInfo_gb.Name = "personalInfo_gb";
            this.personalInfo_gb.Padding = new System.Windows.Forms.Padding(10, 3, 10, 5);
            this.personalInfo_gb.Size = new System.Drawing.Size(530, 310);
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
            this.userInfo_table.Controls.Add(this.fio_tb, 1, 0);
            this.userInfo_table.Controls.Add(this.birthday_flowPanel, 1, 2);
            this.userInfo_table.Controls.Add(this.personalInfoOk_btn, 1, 6);
            this.userInfo_table.Controls.Add(this.email_lbl, 0, 3);
            this.userInfo_table.Controls.Add(this.class_lbl, 0, 4);
            this.userInfo_table.Controls.Add(this.class_tb, 1, 4);
            this.userInfo_table.Controls.Add(this.email_tb, 1, 3);
            this.userInfo_table.Controls.Add(this.personData_lbl, 0, 5);
            this.userInfo_table.Controls.Add(this.personDataAdd_lbl, 1, 5);
            this.userInfo_table.Controls.Add(this.gender_comboBox, 1, 1);
            this.userInfo_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInfo_table.Location = new System.Drawing.Point(10, 26);
            this.userInfo_table.Name = "userInfo_table";
            this.userInfo_table.RowCount = 7;
            this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.userInfo_table.Size = new System.Drawing.Size(510, 279);
            this.userInfo_table.TabIndex = 2;
            // 
            // name_lbl
            // 
            this.name_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_lbl.Location = new System.Drawing.Point(110, 11);
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
            this.gender_lbl.Location = new System.Drawing.Point(110, 51);
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
            this.birthday_lbl.Location = new System.Drawing.Point(43, 91);
            this.birthday_lbl.Name = "birthday_lbl";
            this.birthday_lbl.Size = new System.Drawing.Size(107, 18);
            this.birthday_lbl.TabIndex = 2;
            this.birthday_lbl.Text = "Дата рождения:";
            // 
            // fio_tb
            // 
            this.fio_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fio_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_tb.Location = new System.Drawing.Point(156, 9);
            this.fio_tb.Name = "fio_tb";
            this.fio_tb.Size = new System.Drawing.Size(320, 22);
            this.fio_tb.TabIndex = 4;
            // 
            // birthday_flowPanel
            // 
            this.birthday_flowPanel.Controls.Add(this.birthDay_cb);
            this.birthday_flowPanel.Controls.Add(this.birthMonth_cb);
            this.birthday_flowPanel.Controls.Add(this.birthYear_cb);
            this.birthday_flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthday_flowPanel.Location = new System.Drawing.Point(153, 80);
            this.birthday_flowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.birthday_flowPanel.Name = "birthday_flowPanel";
            this.birthday_flowPanel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.birthday_flowPanel.Size = new System.Drawing.Size(357, 40);
            this.birthday_flowPanel.TabIndex = 7;
            // 
            // birthDay_cb
            // 
            this.birthDay_cb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.birthDay_cb.DropDownHeight = 200;
            this.birthDay_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birthDay_cb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDay_cb.FormattingEnabled = true;
            this.birthDay_cb.IntegralHeight = false;
            this.birthDay_cb.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.birthDay_cb.Location = new System.Drawing.Point(3, 7);
            this.birthDay_cb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.birthDay_cb.Name = "birthDay_cb";
            this.birthDay_cb.Size = new System.Drawing.Size(85, 26);
            this.birthDay_cb.TabIndex = 15;
            // 
            // birthMonth_cb
            // 
            this.birthMonth_cb.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.birthMonth_cb.Location = new System.Drawing.Point(94, 7);
            this.birthMonth_cb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.birthMonth_cb.Name = "birthMonth_cb";
            this.birthMonth_cb.Size = new System.Drawing.Size(138, 26);
            this.birthMonth_cb.TabIndex = 16;
            // 
            // birthYear_cb
            // 
            this.birthYear_cb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.birthYear_cb.DropDownHeight = 200;
            this.birthYear_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birthYear_cb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthYear_cb.FormattingEnabled = true;
            this.birthYear_cb.IntegralHeight = false;
            this.birthYear_cb.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.birthYear_cb.Location = new System.Drawing.Point(238, 7);
            this.birthYear_cb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.birthYear_cb.Name = "birthYear_cb";
            this.birthYear_cb.Size = new System.Drawing.Size(85, 26);
            this.birthYear_cb.TabIndex = 17;
            // 
            // personalInfoOk_btn
            // 
            this.personalInfoOk_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personalInfoOk_btn.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalInfoOk_btn.Location = new System.Drawing.Point(364, 243);
            this.personalInfoOk_btn.Margin = new System.Windows.Forms.Padding(0, 3, 33, 0);
            this.personalInfoOk_btn.Name = "personalInfoOk_btn";
            this.personalInfoOk_btn.Size = new System.Drawing.Size(113, 35);
            this.personalInfoOk_btn.TabIndex = 9;
            this.personalInfoOk_btn.Text = "Изменить";
            this.personalInfoOk_btn.UseVisualStyleBackColor = true;
            // 
            // email_lbl
            // 
            this.email_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.Location = new System.Drawing.Point(28, 131);
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
            this.class_lbl.Location = new System.Drawing.Point(101, 171);
            this.class_lbl.Name = "class_lbl";
            this.class_lbl.Size = new System.Drawing.Size(49, 18);
            this.class_lbl.TabIndex = 3;
            this.class_lbl.Text = "Класс:";
            // 
            // class_tb
            // 
            this.class_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.class_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.class_tb.Location = new System.Drawing.Point(156, 169);
            this.class_tb.Name = "class_tb";
            this.class_tb.ReadOnly = true;
            this.class_tb.Size = new System.Drawing.Size(320, 22);
            this.class_tb.TabIndex = 8;
            // 
            // email_tb
            // 
            this.email_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.email_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_tb.Location = new System.Drawing.Point(156, 129);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(320, 22);
            this.email_tb.TabIndex = 11;
            // 
            // personData_lbl
            // 
            this.personData_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.personData_lbl.AutoSize = true;
            this.personData_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personData_lbl.Location = new System.Drawing.Point(78, 211);
            this.personData_lbl.Name = "personData_lbl";
            this.personData_lbl.Size = new System.Drawing.Size(72, 18);
            this.personData_lbl.TabIndex = 12;
            this.personData_lbl.Text = "Родители:";
            // 
            // personDataAdd_lbl
            // 
            this.personDataAdd_lbl.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.personDataAdd_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.personDataAdd_lbl.AutoSize = true;
            this.personDataAdd_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personDataAdd_lbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.personDataAdd_lbl.LinkColor = System.Drawing.SystemColors.Highlight;
            this.personDataAdd_lbl.Location = new System.Drawing.Point(156, 211);
            this.personDataAdd_lbl.Name = "personDataAdd_lbl";
            this.personDataAdd_lbl.Size = new System.Drawing.Size(62, 17);
            this.personDataAdd_lbl.TabIndex = 13;
            this.personDataAdd_lbl.TabStop = true;
            this.personDataAdd_lbl.Text = "Добавить";
            this.personDataAdd_lbl.VisitedLinkColor = System.Drawing.SystemColors.Highlight;
            this.personDataAdd_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.personDataAdd_lbl_LinkClicked);
            // 
            // gender_comboBox
            // 
            this.gender_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gender_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_comboBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gender_comboBox.FormattingEnabled = true;
            this.gender_comboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.gender_comboBox.Location = new System.Drawing.Point(156, 49);
            this.gender_comboBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.gender_comboBox.Name = "gender_comboBox";
            this.gender_comboBox.Size = new System.Drawing.Size(320, 26);
            this.gender_comboBox.TabIndex = 14;
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
            this.title_lbl.Size = new System.Drawing.Size(607, 70);
            this.title_lbl.TabIndex = 2;
            this.title_lbl.Text = "Профиль";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 395);
            this.Controls.Add(this.userProfile_tbl);
            this.Name = "Profile";
            this.Text = "Профиль пользователя";
            this.userProfile_tbl.ResumeLayout(false);
            this.userProfile_tbl.PerformLayout();
            this.loginSettings_gb.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.personalInfo_gb.ResumeLayout(false);
            this.userInfo_table.ResumeLayout(false);
            this.userInfo_table.PerformLayout();
            this.birthday_flowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel userProfile_tbl;
        private System.Windows.Forms.GroupBox loginSettings_gb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label oldPassword_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label newPasswordConfirm_lbl;
        private System.Windows.Forms.TextBox oldPassword_tb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.GroupBox personalInfo_gb;
        private System.Windows.Forms.TableLayoutPanel userInfo_table;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label gender_lbl;
        private System.Windows.Forms.Label birthday_lbl;
        private System.Windows.Forms.TextBox fio_tb;
        private System.Windows.Forms.FlowLayoutPanel birthday_flowPanel;
        private System.Windows.Forms.Button personalInfoOk_btn;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label class_lbl;
        private System.Windows.Forms.TextBox class_tb;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label personData_lbl;
        private System.Windows.Forms.LinkLabel personDataAdd_lbl;
        private CustomComboBox birthDay_cb;
        private CustomComboBox birthMonth_cb;
        private CustomComboBox birthYear_cb;
        private CustomComboBox gender_comboBox;
    }
}