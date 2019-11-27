namespace CourseWork
{
    partial class GradeCreating
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.gradeCreate_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.markComment_lbl = new System.Windows.Forms.Label();
            this.workType_lbl = new System.Windows.Forms.Label();
            this.puple_lbl = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.mark_lbl = new System.Windows.Forms.Label();
            this.workName = new System.Windows.Forms.Label();
            this.workName_tb = new System.Windows.Forms.TextBox();
            this.puple_cb = new CourseWork.CustomComboBox();
            this.workType_cb = new CourseWork.CustomComboBox();
            this.markComment_rtb = new CourseWork.CustomRichTextBox();
            this.mark_cb = new CourseWork.CustomComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gradeCreate_tbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.title_lbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gradeCreate_tbl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 401);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.title_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title_lbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_lbl.Location = new System.Drawing.Point(0, 0);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(530, 40);
            this.title_lbl.TabIndex = 8;
            this.title_lbl.Text = "Настройка оценки";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradeCreate_tbl
            // 
            this.gradeCreate_tbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gradeCreate_tbl.ColumnCount = 2;
            this.gradeCreate_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.81818F));
            this.gradeCreate_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.18182F));
            this.gradeCreate_tbl.Controls.Add(this.markComment_lbl, 0, 4);
            this.gradeCreate_tbl.Controls.Add(this.workType_lbl, 0, 1);
            this.gradeCreate_tbl.Controls.Add(this.puple_lbl, 0, 0);
            this.gradeCreate_tbl.Controls.Add(this.puple_cb, 1, 0);
            this.gradeCreate_tbl.Controls.Add(this.workType_cb, 1, 1);
            this.gradeCreate_tbl.Controls.Add(this.markComment_rtb, 1, 4);
            this.gradeCreate_tbl.Controls.Add(this.confirm_btn, 1, 5);
            this.gradeCreate_tbl.Controls.Add(this.mark_lbl, 0, 3);
            this.gradeCreate_tbl.Controls.Add(this.workName, 0, 2);
            this.gradeCreate_tbl.Controls.Add(this.mark_cb, 1, 3);
            this.gradeCreate_tbl.Controls.Add(this.workName_tb, 1, 2);
            this.gradeCreate_tbl.Location = new System.Drawing.Point(0, 60);
            this.gradeCreate_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.gradeCreate_tbl.Name = "gradeCreate_tbl";
            this.gradeCreate_tbl.RowCount = 6;
            this.gradeCreate_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.gradeCreate_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.gradeCreate_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.gradeCreate_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.gradeCreate_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.gradeCreate_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.gradeCreate_tbl.Size = new System.Drawing.Size(530, 320);
            this.gradeCreate_tbl.TabIndex = 9;
            // 
            // markComment_lbl
            // 
            this.markComment_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.markComment_lbl.AutoSize = true;
            this.markComment_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markComment_lbl.Location = new System.Drawing.Point(11, 171);
            this.markComment_lbl.Margin = new System.Windows.Forms.Padding(3, 11, 3, 0);
            this.markComment_lbl.Name = "markComment_lbl";
            this.markComment_lbl.Size = new System.Drawing.Size(154, 18);
            this.markComment_lbl.TabIndex = 21;
            this.markComment_lbl.Text = "Комментарий к работе:";
            // 
            // workType_lbl
            // 
            this.workType_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.workType_lbl.AutoSize = true;
            this.workType_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workType_lbl.Location = new System.Drawing.Point(79, 51);
            this.workType_lbl.Name = "workType_lbl";
            this.workType_lbl.Size = new System.Drawing.Size(86, 18);
            this.workType_lbl.TabIndex = 16;
            this.workType_lbl.Text = "Тип работы:";
            // 
            // puple_lbl
            // 
            this.puple_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.puple_lbl.AutoSize = true;
            this.puple_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.puple_lbl.Location = new System.Drawing.Point(110, 11);
            this.puple_lbl.Name = "puple_lbl";
            this.puple_lbl.Size = new System.Drawing.Size(55, 18);
            this.puple_lbl.TabIndex = 1;
            this.puple_lbl.Text = "Ученик:";
            // 
            // confirm_btn
            // 
            this.confirm_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm_btn.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirm_btn.Location = new System.Drawing.Point(379, 283);
            this.confirm_btn.Margin = new System.Windows.Forms.Padding(0, 3, 38, 5);
            this.confirm_btn.MinimumSize = new System.Drawing.Size(0, 35);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(113, 35);
            this.confirm_btn.TabIndex = 22;
            this.confirm_btn.Text = "Подтвердить";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // mark_lbl
            // 
            this.mark_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mark_lbl.AutoSize = true;
            this.mark_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mark_lbl.Location = new System.Drawing.Point(108, 131);
            this.mark_lbl.Name = "mark_lbl";
            this.mark_lbl.Size = new System.Drawing.Size(57, 18);
            this.mark_lbl.TabIndex = 18;
            this.mark_lbl.Text = "Оценка:";
            // 
            // workName
            // 
            this.workName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.workName.AutoSize = true;
            this.workName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workName.Location = new System.Drawing.Point(45, 91);
            this.workName.Name = "workName";
            this.workName.Size = new System.Drawing.Size(120, 18);
            this.workName.TabIndex = 23;
            this.workName.Text = "Название работы:";
            // 
            // workName_tb
            // 
            this.workName_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.workName_tb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workName_tb.Location = new System.Drawing.Point(171, 87);
            this.workName_tb.Name = "workName_tb";
            this.workName_tb.Size = new System.Drawing.Size(320, 26);
            this.workName_tb.TabIndex = 24;
            // 
            // puple_cb
            // 
            this.puple_cb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.puple_cb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.puple_cb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.puple_cb.DropDownHeight = 200;
            this.puple_cb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.puple_cb.FormattingEnabled = true;
            this.puple_cb.IntegralHeight = false;
            this.puple_cb.Location = new System.Drawing.Point(171, 7);
            this.puple_cb.Name = "puple_cb";
            this.puple_cb.Size = new System.Drawing.Size(320, 26);
            this.puple_cb.TabIndex = 15;
            this.puple_cb.TextUpdate += new System.EventHandler(this.comboBox_TextUpdate);
            this.puple_cb.Enter += new System.EventHandler(this.comboBox_Enter);
            this.puple_cb.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            // 
            // workType_cb
            // 
            this.workType_cb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.workType_cb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.workType_cb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.workType_cb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workType_cb.FormattingEnabled = true;
            this.workType_cb.Items.AddRange(new object[] {
            "Ответ на уроке",
            "Контрольная работа",
            "Самостоятельная работа",
            "Домашняя работа",
            "Тест"});
            this.workType_cb.Location = new System.Drawing.Point(171, 47);
            this.workType_cb.Name = "workType_cb";
            this.workType_cb.Size = new System.Drawing.Size(320, 26);
            this.workType_cb.TabIndex = 17;
            // 
            // markComment_rtb
            // 
            this.markComment_rtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.markComment_rtb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markComment_rtb.Location = new System.Drawing.Point(171, 163);
            this.markComment_rtb.Name = "markComment_rtb";
            this.markComment_rtb.Size = new System.Drawing.Size(320, 114);
            this.markComment_rtb.TabIndex = 20;
            this.markComment_rtb.Text = "";
            // 
            // mark_cb
            // 
            this.mark_cb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mark_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mark_cb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mark_cb.FormattingEnabled = true;
            this.mark_cb.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.mark_cb.Location = new System.Drawing.Point(171, 127);
            this.mark_cb.Name = "mark_cb";
            this.mark_cb.Size = new System.Drawing.Size(320, 26);
            this.mark_cb.TabIndex = 19;
            // 
            // GradeCreating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 401);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GradeCreating";
            this.Text = "GradeCreating";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gradeCreate_tbl.ResumeLayout(false);
            this.gradeCreate_tbl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TableLayoutPanel gradeCreate_tbl;
        private System.Windows.Forms.Label puple_lbl;
        private CustomComboBox puple_cb;
        private System.Windows.Forms.Label workType_lbl;
        private CustomComboBox workType_cb;
        private System.Windows.Forms.Label mark_lbl;
        private CustomComboBox mark_cb;
        private CustomRichTextBox markComment_rtb;
        private System.Windows.Forms.Label markComment_lbl;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Label workName;
        private System.Windows.Forms.TextBox workName_tb;
    }
}