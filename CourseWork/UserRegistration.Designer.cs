namespace CourseWork
{
    partial class UserRegistration
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
            this.userRegistration_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.back_btn = new System.Windows.Forms.Button();
            this.signUp_btn = new System.Windows.Forms.Button();
            this.personData_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.personDataAdd_lbl = new System.Windows.Forms.LinkLabel();
            this.personData_lbl = new System.Windows.Forms.Label();
            this.class_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.class_lbl = new System.Windows.Forms.Label();
            this.class_cb = new CourseWork.CustomComboBox();
            this.internalMail_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.internalMail_lbl = new System.Windows.Forms.Label();
            this.internalMail_tb = new System.Windows.Forms.TextBox();
            this.birth_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.birth_lbl = new System.Windows.Forms.Label();
            this.birth_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.birthDay_cb = new CourseWork.CustomComboBox();
            this.birthMonth_cb = new CourseWork.CustomComboBox();
            this.birthYear_cb = new CourseWork.CustomComboBox();
            this.gender_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.gender_cb = new CourseWork.CustomComboBox();
            this.mainContainer_tbl.SuspendLayout();
            this.userRegistration_tbl.SuspendLayout();
            this.personData_tbl.SuspendLayout();
            this.class_tbl.SuspendLayout();
            this.internalMail_tbl.SuspendLayout();
            this.birth_tbl.SuspendLayout();
            this.birth_flp.SuspendLayout();
            this.gender_tbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer_tbl
            // 
            this.mainContainer_tbl.ColumnCount = 1;
            this.mainContainer_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainContainer_tbl.Controls.Add(this.userRegistration_tbl, 0, 0);
            this.mainContainer_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer_tbl.Location = new System.Drawing.Point(0, 0);
            this.mainContainer_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.mainContainer_tbl.Name = "mainContainer_tbl";
            this.mainContainer_tbl.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.mainContainer_tbl.RowCount = 1;
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainContainer_tbl.Size = new System.Drawing.Size(800, 450);
            this.mainContainer_tbl.TabIndex = 3;
            // 
            // userRegistration_tbl
            // 
            this.userRegistration_tbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userRegistration_tbl.AutoSize = true;
            this.userRegistration_tbl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userRegistration_tbl.ColumnCount = 1;
            this.userRegistration_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.userRegistration_tbl.Controls.Add(this.back_btn, 0, 6);
            this.userRegistration_tbl.Controls.Add(this.signUp_btn, 0, 5);
            this.userRegistration_tbl.Controls.Add(this.personData_tbl, 0, 4);
            this.userRegistration_tbl.Controls.Add(this.class_tbl, 0, 3);
            this.userRegistration_tbl.Controls.Add(this.internalMail_tbl, 0, 2);
            this.userRegistration_tbl.Controls.Add(this.birth_tbl, 0, 1);
            this.userRegistration_tbl.Controls.Add(this.gender_tbl, 0, 0);
            this.userRegistration_tbl.Location = new System.Drawing.Point(135, 10);
            this.userRegistration_tbl.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.userRegistration_tbl.MinimumSize = new System.Drawing.Size(520, 308);
            this.userRegistration_tbl.Name = "userRegistration_tbl";
            this.userRegistration_tbl.RowCount = 7;
            this.userRegistration_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.userRegistration_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.userRegistration_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.userRegistration_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.userRegistration_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.userRegistration_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.userRegistration_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.userRegistration_tbl.Size = new System.Drawing.Size(520, 425);
            this.userRegistration_tbl.TabIndex = 3;
            this.userRegistration_tbl.Resize += new System.EventHandler(this.userRegistration_tbl_Resize);
            // 
            // back_btn
            // 
            this.back_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.back_btn.AutoSize = true;
            this.back_btn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_btn.Location = new System.Drawing.Point(205, 370);
            this.back_btn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(109, 50);
            this.back_btn.TabIndex = 101;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // signUp_btn
            // 
            this.signUp_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signUp_btn.AutoSize = true;
            this.signUp_btn.Enabled = false;
            this.signUp_btn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUp_btn.Location = new System.Drawing.Point(106, 315);
            this.signUp_btn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.signUp_btn.Name = "signUp_btn";
            this.signUp_btn.Size = new System.Drawing.Size(307, 50);
            this.signUp_btn.TabIndex = 100;
            this.signUp_btn.Text = "Зарегистрироваться";
            this.signUp_btn.UseVisualStyleBackColor = true;
            this.signUp_btn.Click += new System.EventHandler(this.signUp_btn_Click);
            // 
            // personData_tbl
            // 
            this.personData_tbl.AutoSize = true;
            this.personData_tbl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.personData_tbl.ColumnCount = 1;
            this.personData_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.personData_tbl.Controls.Add(this.personDataAdd_lbl, 0, 1);
            this.personData_tbl.Controls.Add(this.personData_lbl, 0, 0);
            this.personData_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personData_tbl.Location = new System.Drawing.Point(0, 262);
            this.personData_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.personData_tbl.Name = "personData_tbl";
            this.personData_tbl.RowCount = 2;
            this.personData_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.personData_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.personData_tbl.Size = new System.Drawing.Size(520, 53);
            this.personData_tbl.TabIndex = 4;
            // 
            // personDataAdd_lbl
            // 
            this.personDataAdd_lbl.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.personDataAdd_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.personDataAdd_lbl.AutoSize = true;
            this.personDataAdd_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personDataAdd_lbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.personDataAdd_lbl.LinkColor = System.Drawing.SystemColors.Highlight;
            this.personDataAdd_lbl.Location = new System.Drawing.Point(3, 26);
            this.personDataAdd_lbl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.personDataAdd_lbl.Name = "personDataAdd_lbl";
            this.personDataAdd_lbl.Size = new System.Drawing.Size(62, 17);
            this.personDataAdd_lbl.TabIndex = 99;
            this.personDataAdd_lbl.TabStop = true;
            this.personDataAdd_lbl.Text = "Добавить";
            this.personDataAdd_lbl.VisitedLinkColor = System.Drawing.SystemColors.Highlight;
            this.personDataAdd_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.personDataAdd_lbl_LinkClicked);
            // 
            // personData_lbl
            // 
            this.personData_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.personData_lbl.AutoSize = true;
            this.personData_lbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personData_lbl.Location = new System.Drawing.Point(0, 0);
            this.personData_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.personData_lbl.Name = "personData_lbl";
            this.personData_lbl.Size = new System.Drawing.Size(170, 23);
            this.personData_lbl.TabIndex = 0;
            this.personData_lbl.Text = "Добавьте родителей:";
            // 
            // class_tbl
            // 
            this.class_tbl.AutoSize = true;
            this.class_tbl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.class_tbl.ColumnCount = 1;
            this.class_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.class_tbl.Controls.Add(this.class_lbl, 0, 0);
            this.class_tbl.Controls.Add(this.class_cb, 0, 1);
            this.class_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.class_tbl.Location = new System.Drawing.Point(0, 197);
            this.class_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.class_tbl.Name = "class_tbl";
            this.class_tbl.RowCount = 2;
            this.class_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.class_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.class_tbl.Size = new System.Drawing.Size(520, 65);
            this.class_tbl.TabIndex = 3;
            // 
            // class_lbl
            // 
            this.class_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.class_lbl.AutoSize = true;
            this.class_lbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.class_lbl.Location = new System.Drawing.Point(0, 0);
            this.class_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.class_lbl.Name = "class_lbl";
            this.class_lbl.Size = new System.Drawing.Size(158, 23);
            this.class_lbl.TabIndex = 0;
            this.class_lbl.Text = "Укажите ваш класс:";
            // 
            // class_cb
            // 
            this.class_cb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.class_cb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.class_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.class_cb.FormattingEnabled = true;
            this.class_cb.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.class_cb.ItemHeight = 24;
            this.class_cb.Location = new System.Drawing.Point(0, 23);
            this.class_cb.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.class_cb.Name = "class_cb";
            this.class_cb.Size = new System.Drawing.Size(500, 32);
            this.class_cb.TabIndex = 6;
            this.class_cb.SelectedIndexChanged += new System.EventHandler(this.fields_Validating);
            this.class_cb.TextUpdate += new System.EventHandler(this.comboBox_TextUpdate);
            this.class_cb.Enter += new System.EventHandler(this.comboBox_Enter);
            this.class_cb.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            // 
            // internalMail_tbl
            // 
            this.internalMail_tbl.AutoSize = true;
            this.internalMail_tbl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.internalMail_tbl.ColumnCount = 1;
            this.internalMail_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.internalMail_tbl.Controls.Add(this.internalMail_lbl, 0, 0);
            this.internalMail_tbl.Controls.Add(this.internalMail_tb, 0, 1);
            this.internalMail_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.internalMail_tbl.Location = new System.Drawing.Point(0, 130);
            this.internalMail_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.internalMail_tbl.Name = "internalMail_tbl";
            this.internalMail_tbl.RowCount = 2;
            this.internalMail_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.internalMail_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.internalMail_tbl.Size = new System.Drawing.Size(520, 67);
            this.internalMail_tbl.TabIndex = 2;
            // 
            // internalMail_lbl
            // 
            this.internalMail_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.internalMail_lbl.AutoSize = true;
            this.internalMail_lbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.internalMail_lbl.Location = new System.Drawing.Point(0, 0);
            this.internalMail_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.internalMail_lbl.Name = "internalMail_lbl";
            this.internalMail_lbl.Size = new System.Drawing.Size(236, 23);
            this.internalMail_lbl.TabIndex = 0;
            this.internalMail_lbl.Text = "Создайте внутреннюю почту:";
            // 
            // internalMail_tb
            // 
            this.internalMail_tb.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.internalMail_tb.Location = new System.Drawing.Point(0, 23);
            this.internalMail_tb.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.internalMail_tb.Name = "internalMail_tb";
            this.internalMail_tb.Size = new System.Drawing.Size(500, 34);
            this.internalMail_tb.TabIndex = 5;
            this.internalMail_tb.TextChanged += new System.EventHandler(this.internalMail_tb_TextChanged);
            // 
            // birth_tbl
            // 
            this.birth_tbl.AutoSize = true;
            this.birth_tbl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.birth_tbl.ColumnCount = 1;
            this.birth_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.birth_tbl.Controls.Add(this.birth_lbl, 0, 0);
            this.birth_tbl.Controls.Add(this.birth_flp, 0, 1);
            this.birth_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birth_tbl.Location = new System.Drawing.Point(0, 65);
            this.birth_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.birth_tbl.Name = "birth_tbl";
            this.birth_tbl.RowCount = 2;
            this.birth_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.birth_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.birth_tbl.Size = new System.Drawing.Size(520, 65);
            this.birth_tbl.TabIndex = 1;
            // 
            // birth_lbl
            // 
            this.birth_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.birth_lbl.AutoSize = true;
            this.birth_lbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birth_lbl.Location = new System.Drawing.Point(0, 0);
            this.birth_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.birth_lbl.Name = "birth_lbl";
            this.birth_lbl.Size = new System.Drawing.Size(193, 23);
            this.birth_lbl.TabIndex = 0;
            this.birth_lbl.Text = "Задайте дату рождения:";
            // 
            // birth_flp
            // 
            this.birth_flp.AutoSize = true;
            this.birth_flp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.birth_flp.Controls.Add(this.birthDay_cb);
            this.birth_flp.Controls.Add(this.birthMonth_cb);
            this.birth_flp.Controls.Add(this.birthYear_cb);
            this.birth_flp.Location = new System.Drawing.Point(0, 23);
            this.birth_flp.Margin = new System.Windows.Forms.Padding(0);
            this.birth_flp.Name = "birth_flp";
            this.birth_flp.Size = new System.Drawing.Size(500, 42);
            this.birth_flp.TabIndex = 1;
            this.birth_flp.WrapContents = false;
            // 
            // birthDay_cb
            // 
            this.birthDay_cb.DropDownHeight = 200;
            this.birthDay_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birthDay_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDay_cb.FormattingEnabled = true;
            this.birthDay_cb.IntegralHeight = false;
            this.birthDay_cb.Location = new System.Drawing.Point(0, 0);
            this.birthDay_cb.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.birthDay_cb.Name = "birthDay_cb";
            this.birthDay_cb.Size = new System.Drawing.Size(125, 32);
            this.birthDay_cb.TabIndex = 2;
            this.birthDay_cb.SelectedIndexChanged += new System.EventHandler(this.fields_Validating);
            // 
            // birthMonth_cb
            // 
            this.birthMonth_cb.DropDownHeight = 200;
            this.birthMonth_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birthMonth_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.birthMonth_cb.Location = new System.Drawing.Point(130, 0);
            this.birthMonth_cb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 10);
            this.birthMonth_cb.Name = "birthMonth_cb";
            this.birthMonth_cb.Size = new System.Drawing.Size(240, 32);
            this.birthMonth_cb.TabIndex = 3;
            this.birthMonth_cb.SelectedIndexChanged += new System.EventHandler(this.fields_Validating);
            this.birthMonth_cb.SelectedValueChanged += new System.EventHandler(this.birthMonth_cb_SelectedValueChanged);
            // 
            // birthYear_cb
            // 
            this.birthYear_cb.DropDownHeight = 200;
            this.birthYear_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birthYear_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthYear_cb.FormattingEnabled = true;
            this.birthYear_cb.IntegralHeight = false;
            this.birthYear_cb.Location = new System.Drawing.Point(375, 0);
            this.birthYear_cb.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.birthYear_cb.Name = "birthYear_cb";
            this.birthYear_cb.Size = new System.Drawing.Size(125, 32);
            this.birthYear_cb.TabIndex = 4;
            this.birthYear_cb.SelectedValueChanged += new System.EventHandler(this.fields_Validating);
            // 
            // gender_tbl
            // 
            this.gender_tbl.AutoSize = true;
            this.gender_tbl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gender_tbl.ColumnCount = 1;
            this.gender_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gender_tbl.Controls.Add(this.label2, 0, 0);
            this.gender_tbl.Controls.Add(this.gender_cb, 0, 1);
            this.gender_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gender_tbl.Location = new System.Drawing.Point(0, 0);
            this.gender_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.gender_tbl.Name = "gender_tbl";
            this.gender_tbl.RowCount = 2;
            this.gender_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gender_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gender_tbl.Size = new System.Drawing.Size(520, 65);
            this.gender_tbl.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Укажите пол:";
            // 
            // gender_cb
            // 
            this.gender_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gender_cb.FormattingEnabled = true;
            this.gender_cb.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.gender_cb.Location = new System.Drawing.Point(0, 23);
            this.gender_cb.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.gender_cb.Name = "gender_cb";
            this.gender_cb.Size = new System.Drawing.Size(500, 32);
            this.gender_cb.TabIndex = 1;
            this.gender_cb.TextUpdate += new System.EventHandler(this.fields_Validating);
            this.gender_cb.SelectedValueChanged += new System.EventHandler(this.fields_Validating);
            // 
            // UserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainContainer_tbl);
            this.Name = "UserRegistration";
            this.Text = "UserRegistration";
            this.mainContainer_tbl.ResumeLayout(false);
            this.mainContainer_tbl.PerformLayout();
            this.userRegistration_tbl.ResumeLayout(false);
            this.userRegistration_tbl.PerformLayout();
            this.personData_tbl.ResumeLayout(false);
            this.personData_tbl.PerformLayout();
            this.class_tbl.ResumeLayout(false);
            this.class_tbl.PerformLayout();
            this.internalMail_tbl.ResumeLayout(false);
            this.internalMail_tbl.PerformLayout();
            this.birth_tbl.ResumeLayout(false);
            this.birth_tbl.PerformLayout();
            this.birth_flp.ResumeLayout(false);
            this.gender_tbl.ResumeLayout(false);
            this.gender_tbl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainContainer_tbl;
        private System.Windows.Forms.TableLayoutPanel userRegistration_tbl;
        private System.Windows.Forms.TableLayoutPanel birth_tbl;
        private System.Windows.Forms.Label birth_lbl;
        private System.Windows.Forms.TableLayoutPanel gender_tbl;
        private System.Windows.Forms.Label label2;
        public CustomComboBox gender_cb;
        private System.Windows.Forms.FlowLayoutPanel birth_flp;
        public CustomComboBox birthDay_cb;
        public CustomComboBox birthMonth_cb;
        public CustomComboBox birthYear_cb;
        private System.Windows.Forms.TableLayoutPanel internalMail_tbl;
        private System.Windows.Forms.Label internalMail_lbl;
        public System.Windows.Forms.TextBox internalMail_tb;
        private System.Windows.Forms.TableLayoutPanel class_tbl;
        private System.Windows.Forms.Label class_lbl;
        public CustomComboBox class_cb;
        private System.Windows.Forms.TableLayoutPanel personData_tbl;
        private System.Windows.Forms.Label personData_lbl;
        private System.Windows.Forms.LinkLabel personDataAdd_lbl;
        private System.Windows.Forms.Button signUp_btn;
        private System.Windows.Forms.Button back_btn;
    }
}