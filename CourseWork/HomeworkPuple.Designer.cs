namespace CourseWork
{
    partial class HomeworkPuple
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
            this.mainContainer_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.sendHomework_gb = new System.Windows.Forms.GroupBox();
            this.sendHomework_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.send_btn = new System.Windows.Forms.Button();
            this.attachLink_lbl = new System.Windows.Forms.LinkLabel();
            this.note_lbl = new System.Windows.Forms.Label();
            this.attachment_lbl = new System.Windows.Forms.Label();
            this.note_rtb = new System.Windows.Forms.RichTextBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.selectHomework_gb = new System.Windows.Forms.GroupBox();
            this.selectHomework_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.homeworkDescr_lbl = new System.Windows.Forms.Label();
            this.homework_cb = new System.Windows.Forms.ComboBox();
            this.homework_lbl = new System.Windows.Forms.Label();
            this.teacher_cb = new System.Windows.Forms.ComboBox();
            this.teacher_lbl = new System.Windows.Forms.Label();
            this.subject_cb = new System.Windows.Forms.ComboBox();
            this.subject_lbl = new System.Windows.Forms.Label();
            this.homeworkDescr_rtb = new System.Windows.Forms.RichTextBox();
            this.mainContainer_tbl.SuspendLayout();
            this.sendHomework_gb.SuspendLayout();
            this.sendHomework_tbl.SuspendLayout();
            this.selectHomework_gb.SuspendLayout();
            this.selectHomework_tbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer_tbl
            // 
            this.mainContainer_tbl.AutoScroll = true;
            this.mainContainer_tbl.ColumnCount = 1;
            this.mainContainer_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer_tbl.Controls.Add(this.sendHomework_gb, 0, 2);
            this.mainContainer_tbl.Controls.Add(this.title_lbl, 0, 0);
            this.mainContainer_tbl.Controls.Add(this.selectHomework_gb, 0, 1);
            this.mainContainer_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer_tbl.Location = new System.Drawing.Point(0, 0);
            this.mainContainer_tbl.Name = "mainContainer_tbl";
            this.mainContainer_tbl.RowCount = 3;
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.mainContainer_tbl.Size = new System.Drawing.Size(567, 450);
            this.mainContainer_tbl.TabIndex = 0;
            this.mainContainer_tbl.Resize += new System.EventHandler(this.mainContainer_tbl_Resize);
            // 
            // sendHomework_gb
            // 
            this.sendHomework_gb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sendHomework_gb.Controls.Add(this.sendHomework_tbl);
            this.sendHomework_gb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendHomework_gb.Location = new System.Drawing.Point(3, 385);
            this.sendHomework_gb.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.sendHomework_gb.MaximumSize = new System.Drawing.Size(530, 230);
            this.sendHomework_gb.MinimumSize = new System.Drawing.Size(530, 230);
            this.sendHomework_gb.Name = "sendHomework_gb";
            this.sendHomework_gb.Size = new System.Drawing.Size(530, 230);
            this.sendHomework_gb.TabIndex = 7;
            this.sendHomework_gb.TabStop = false;
            this.sendHomework_gb.Text = "Отправить на проверку:";
            // 
            // sendHomework_tbl
            // 
            this.sendHomework_tbl.ColumnCount = 2;
            this.sendHomework_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.sendHomework_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.sendHomework_tbl.Controls.Add(this.send_btn, 1, 2);
            this.sendHomework_tbl.Controls.Add(this.attachLink_lbl, 1, 0);
            this.sendHomework_tbl.Controls.Add(this.note_lbl, 0, 1);
            this.sendHomework_tbl.Controls.Add(this.attachment_lbl, 0, 0);
            this.sendHomework_tbl.Controls.Add(this.note_rtb, 1, 1);
            this.sendHomework_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendHomework_tbl.Location = new System.Drawing.Point(3, 26);
            this.sendHomework_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.sendHomework_tbl.Name = "sendHomework_tbl";
            this.sendHomework_tbl.RowCount = 3;
            this.sendHomework_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.sendHomework_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.sendHomework_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.sendHomework_tbl.Size = new System.Drawing.Size(524, 201);
            this.sendHomework_tbl.TabIndex = 0;
            // 
            // send_btn
            // 
            this.send_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.send_btn.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.send_btn.Location = new System.Drawing.Point(368, 163);
            this.send_btn.Margin = new System.Windows.Forms.Padding(0, 3, 43, 0);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(113, 33);
            this.send_btn.TabIndex = 15;
            this.send_btn.Text = "Отправить";
            this.send_btn.UseVisualStyleBackColor = true;
            // 
            // attachLink_lbl
            // 
            this.attachLink_lbl.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.attachLink_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.attachLink_lbl.AutoSize = true;
            this.attachLink_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attachLink_lbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.attachLink_lbl.LinkColor = System.Drawing.SystemColors.Highlight;
            this.attachLink_lbl.Location = new System.Drawing.Point(160, 11);
            this.attachLink_lbl.Name = "attachLink_lbl";
            this.attachLink_lbl.Size = new System.Drawing.Size(79, 17);
            this.attachLink_lbl.TabIndex = 14;
            this.attachLink_lbl.TabStop = true;
            this.attachLink_lbl.Text = "Прикрепить";
            this.attachLink_lbl.VisitedLinkColor = System.Drawing.SystemColors.Highlight;
            this.attachLink_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.attachLink_lbl_LinkClicked);
            // 
            // note_lbl
            // 
            this.note_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.note_lbl.AutoSize = true;
            this.note_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.note_lbl.Location = new System.Drawing.Point(56, 51);
            this.note_lbl.Margin = new System.Windows.Forms.Padding(3, 11, 3, 0);
            this.note_lbl.Name = "note_lbl";
            this.note_lbl.Size = new System.Drawing.Size(98, 18);
            this.note_lbl.TabIndex = 11;
            this.note_lbl.Text = "Комментарий:";
            // 
            // attachment_lbl
            // 
            this.attachment_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.attachment_lbl.AutoSize = true;
            this.attachment_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attachment_lbl.Location = new System.Drawing.Point(19, 11);
            this.attachment_lbl.Name = "attachment_lbl";
            this.attachment_lbl.Size = new System.Drawing.Size(135, 18);
            this.attachment_lbl.TabIndex = 9;
            this.attachment_lbl.Text = "Прикрепить файлы:";
            // 
            // note_rtb
            // 
            this.note_rtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.note_rtb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.note_rtb.Location = new System.Drawing.Point(160, 43);
            this.note_rtb.Name = "note_rtb";
            this.note_rtb.Size = new System.Drawing.Size(320, 114);
            this.note_rtb.TabIndex = 12;
            this.note_rtb.Text = "";
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
            this.title_lbl.Size = new System.Drawing.Size(567, 70);
            this.title_lbl.TabIndex = 6;
            this.title_lbl.Text = "Домашнее задание";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectHomework_gb
            // 
            this.selectHomework_gb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectHomework_gb.Controls.Add(this.selectHomework_tbl);
            this.selectHomework_gb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectHomework_gb.Location = new System.Drawing.Point(3, 90);
            this.selectHomework_gb.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.selectHomework_gb.MaximumSize = new System.Drawing.Size(530, 270);
            this.selectHomework_gb.MinimumSize = new System.Drawing.Size(530, 270);
            this.selectHomework_gb.Name = "selectHomework_gb";
            this.selectHomework_gb.Size = new System.Drawing.Size(530, 270);
            this.selectHomework_gb.TabIndex = 5;
            this.selectHomework_gb.TabStop = false;
            this.selectHomework_gb.Text = "Выбрать домашнее задание:";
            // 
            // selectHomework_tbl
            // 
            this.selectHomework_tbl.ColumnCount = 2;
            this.selectHomework_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.selectHomework_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.selectHomework_tbl.Controls.Add(this.homeworkDescr_lbl, 0, 3);
            this.selectHomework_tbl.Controls.Add(this.homework_cb, 1, 2);
            this.selectHomework_tbl.Controls.Add(this.homework_lbl, 0, 2);
            this.selectHomework_tbl.Controls.Add(this.teacher_cb, 1, 1);
            this.selectHomework_tbl.Controls.Add(this.teacher_lbl, 0, 1);
            this.selectHomework_tbl.Controls.Add(this.subject_cb, 1, 0);
            this.selectHomework_tbl.Controls.Add(this.subject_lbl, 0, 0);
            this.selectHomework_tbl.Controls.Add(this.homeworkDescr_rtb, 1, 3);
            this.selectHomework_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectHomework_tbl.Location = new System.Drawing.Point(3, 26);
            this.selectHomework_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.selectHomework_tbl.Name = "selectHomework_tbl";
            this.selectHomework_tbl.RowCount = 4;
            this.selectHomework_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.selectHomework_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.selectHomework_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.selectHomework_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.selectHomework_tbl.Size = new System.Drawing.Size(524, 241);
            this.selectHomework_tbl.TabIndex = 0;
            // 
            // homeworkDescr_lbl
            // 
            this.homeworkDescr_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.homeworkDescr_lbl.AutoSize = true;
            this.homeworkDescr_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homeworkDescr_lbl.Location = new System.Drawing.Point(80, 131);
            this.homeworkDescr_lbl.Margin = new System.Windows.Forms.Padding(3, 11, 3, 0);
            this.homeworkDescr_lbl.Name = "homeworkDescr_lbl";
            this.homeworkDescr_lbl.Size = new System.Drawing.Size(74, 18);
            this.homeworkDescr_lbl.TabIndex = 11;
            this.homeworkDescr_lbl.Text = "Описание:";
            // 
            // homework_cb
            // 
            this.homework_cb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.homework_cb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homework_cb.Location = new System.Drawing.Point(160, 87);
            this.homework_cb.Name = "homework_cb";
            this.homework_cb.Size = new System.Drawing.Size(320, 26);
            this.homework_cb.TabIndex = 10;
            this.homework_cb.TextUpdate += new System.EventHandler(this.comboBox_TextUpdate);
            this.homework_cb.Enter += new System.EventHandler(this.comboBox_Enter);
            this.homework_cb.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            // 
            // homework_lbl
            // 
            this.homework_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.homework_lbl.AutoSize = true;
            this.homework_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homework_lbl.Location = new System.Drawing.Point(22, 91);
            this.homework_lbl.Name = "homework_lbl";
            this.homework_lbl.Size = new System.Drawing.Size(132, 18);
            this.homework_lbl.TabIndex = 9;
            this.homework_lbl.Text = "Домашнее задание:";
            // 
            // teacher_cb
            // 
            this.teacher_cb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teacher_cb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacher_cb.Location = new System.Drawing.Point(160, 47);
            this.teacher_cb.Name = "teacher_cb";
            this.teacher_cb.Size = new System.Drawing.Size(320, 26);
            this.teacher_cb.TabIndex = 8;
            this.teacher_cb.TextUpdate += new System.EventHandler(this.comboBox_TextUpdate);
            this.teacher_cb.Enter += new System.EventHandler(this.comboBox_Enter);
            this.teacher_cb.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            // 
            // teacher_lbl
            // 
            this.teacher_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teacher_lbl.AutoSize = true;
            this.teacher_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacher_lbl.Location = new System.Drawing.Point(92, 51);
            this.teacher_lbl.Name = "teacher_lbl";
            this.teacher_lbl.Size = new System.Drawing.Size(62, 18);
            this.teacher_lbl.TabIndex = 7;
            this.teacher_lbl.Text = "Учитель:";
            // 
            // subject_cb
            // 
            this.subject_cb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subject_cb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subject_cb.Location = new System.Drawing.Point(160, 7);
            this.subject_cb.Name = "subject_cb";
            this.subject_cb.Size = new System.Drawing.Size(320, 26);
            this.subject_cb.TabIndex = 6;
            this.subject_cb.TextUpdate += new System.EventHandler(this.comboBox_TextUpdate);
            this.subject_cb.Enter += new System.EventHandler(this.comboBox_Enter);
            this.subject_cb.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            // 
            // subject_lbl
            // 
            this.subject_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.subject_lbl.AutoSize = true;
            this.subject_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subject_lbl.Location = new System.Drawing.Point(85, 11);
            this.subject_lbl.Name = "subject_lbl";
            this.subject_lbl.Size = new System.Drawing.Size(69, 18);
            this.subject_lbl.TabIndex = 3;
            this.subject_lbl.Text = "Предмет:";
            // 
            // homeworkDescr_rtb
            // 
            this.homeworkDescr_rtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.homeworkDescr_rtb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homeworkDescr_rtb.Location = new System.Drawing.Point(160, 123);
            this.homeworkDescr_rtb.Name = "homeworkDescr_rtb";
            this.homeworkDescr_rtb.ReadOnly = true;
            this.homeworkDescr_rtb.Size = new System.Drawing.Size(320, 115);
            this.homeworkDescr_rtb.TabIndex = 12;
            this.homeworkDescr_rtb.Text = "";
            // 
            // HomeworkPuple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.mainContainer_tbl);
            this.Name = "HomeworkPuple";
            this.Text = "Homework";
            this.mainContainer_tbl.ResumeLayout(false);
            this.mainContainer_tbl.PerformLayout();
            this.sendHomework_gb.ResumeLayout(false);
            this.sendHomework_tbl.ResumeLayout(false);
            this.sendHomework_tbl.PerformLayout();
            this.selectHomework_gb.ResumeLayout(false);
            this.selectHomework_tbl.ResumeLayout(false);
            this.selectHomework_tbl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainContainer_tbl;
        private System.Windows.Forms.GroupBox selectHomework_gb;
        private System.Windows.Forms.TableLayoutPanel selectHomework_tbl;
        private System.Windows.Forms.Label subject_lbl;
        private System.Windows.Forms.ComboBox subject_cb;
        private System.Windows.Forms.ComboBox teacher_cb;
        private System.Windows.Forms.Label teacher_lbl;
        private System.Windows.Forms.ComboBox homework_cb;
        private System.Windows.Forms.Label homework_lbl;
        private System.Windows.Forms.Label homeworkDescr_lbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.RichTextBox homeworkDescr_rtb;
        private System.Windows.Forms.GroupBox sendHomework_gb;
        private System.Windows.Forms.TableLayoutPanel sendHomework_tbl;
        private System.Windows.Forms.Label note_lbl;
        private System.Windows.Forms.Label attachment_lbl;
        private System.Windows.Forms.RichTextBox note_rtb;
        private System.Windows.Forms.LinkLabel attachLink_lbl;
        private System.Windows.Forms.Button send_btn;
    }
}