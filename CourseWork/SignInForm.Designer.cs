namespace CourseWork
{
    partial class SignInForm
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
            this.logPswTable = new System.Windows.Forms.TableLayoutPanel();
            this.psw_label = new System.Windows.Forms.Label();
            this.login_tb = new System.Windows.Forms.TextBox();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.signIn_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logPswTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // logPswTable
            // 
            this.logPswTable.ColumnCount = 2;
            this.logPswTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.15531F));
            this.logPswTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.84469F));
            this.logPswTable.Controls.Add(this.psw_label, 0, 1);
            this.logPswTable.Controls.Add(this.login_tb, 1, 0);
            this.logPswTable.Controls.Add(this.pass_tb, 1, 1);
            this.logPswTable.Controls.Add(this.login_label, 0, 0);
            this.logPswTable.Location = new System.Drawing.Point(48, 52);
            this.logPswTable.Margin = new System.Windows.Forms.Padding(2);
            this.logPswTable.Name = "logPswTable";
            this.logPswTable.RowCount = 2;
            this.logPswTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.logPswTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.logPswTable.Size = new System.Drawing.Size(228, 63);
            this.logPswTable.TabIndex = 0;
            // 
            // psw_label
            // 
            this.psw_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.psw_label.AutoSize = true;
            this.psw_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.psw_label.Location = new System.Drawing.Point(3, 31);
            this.psw_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.psw_label.Name = "psw_label";
            this.psw_label.Size = new System.Drawing.Size(61, 32);
            this.psw_label.TabIndex = 1;
            this.psw_label.Text = "Пароль:";
            // 
            // login_tb
            // 
            this.login_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_tb.Location = new System.Drawing.Point(66, 3);
            this.login_tb.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(162, 24);
            this.login_tb.TabIndex = 2;
            // 
            // pass_tb
            // 
            this.pass_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pass_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_tb.Location = new System.Drawing.Point(66, 34);
            this.pass_tb.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(162, 24);
            this.pass_tb.TabIndex = 3;
            this.pass_tb.UseSystemPasswordChar = true;
            // 
            // login_label
            // 
            this.login_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(10, 6);
            this.login_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(54, 18);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "Логин:";
            // 
            // signIn_btn
            // 
            this.signIn_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signIn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signIn_btn.Location = new System.Drawing.Point(201, 120);
            this.signIn_btn.Name = "signIn_btn";
            this.signIn_btn.Size = new System.Drawing.Size(75, 30);
            this.signIn_btn.TabIndex = 1;
            this.signIn_btn.Text = "Войти";
            this.signIn_btn.UseVisualStyleBackColor = true;
            this.signIn_btn.Click += new System.EventHandler(this.signIn_btn_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вход в учетную запись";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Еще нет аккаунта ?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 266);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signIn_btn);
            this.Controls.Add(this.logPswTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignInForm";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.logPswTable.ResumeLayout(false);
            this.logPswTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel logPswTable;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label psw_label;
        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.Button signIn_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

