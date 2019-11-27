namespace CourseWork
{
    partial class GradingTeacher
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
            this.pupleSelection_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.subject_lbl = new System.Windows.Forms.Label();
            this.subject_cb = new CourseWork.CustomComboBox();
            this.class_lbl = new System.Windows.Forms.Label();
            this.class_cb = new CourseWork.CustomComboBox();
            this.marks_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.mainContainer_tbl.SuspendLayout();
            this.pupleSelection_flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer_tbl
            // 
            this.mainContainer_tbl.AutoScroll = true;
            this.mainContainer_tbl.ColumnCount = 1;
            this.mainContainer_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer_tbl.Controls.Add(this.title_lbl, 0, 0);
            this.mainContainer_tbl.Controls.Add(this.pupleSelection_flp, 0, 1);
            this.mainContainer_tbl.Controls.Add(this.marks_tbl, 0, 2);
            this.mainContainer_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer_tbl.Location = new System.Drawing.Point(0, 0);
            this.mainContainer_tbl.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.mainContainer_tbl.Name = "mainContainer_tbl";
            this.mainContainer_tbl.RowCount = 3;
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainContainer_tbl.Size = new System.Drawing.Size(800, 450);
            this.mainContainer_tbl.TabIndex = 1;
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
            this.title_lbl.Size = new System.Drawing.Size(800, 70);
            this.title_lbl.TabIndex = 7;
            this.title_lbl.Text = "Выставление оценок";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pupleSelection_flp
            // 
            this.pupleSelection_flp.Controls.Add(this.subject_lbl);
            this.pupleSelection_flp.Controls.Add(this.subject_cb);
            this.pupleSelection_flp.Controls.Add(this.class_lbl);
            this.pupleSelection_flp.Controls.Add(this.class_cb);
            this.pupleSelection_flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pupleSelection_flp.Location = new System.Drawing.Point(0, 70);
            this.pupleSelection_flp.Margin = new System.Windows.Forms.Padding(0);
            this.pupleSelection_flp.Name = "pupleSelection_flp";
            this.pupleSelection_flp.Size = new System.Drawing.Size(800, 30);
            this.pupleSelection_flp.TabIndex = 8;
            // 
            // subject_lbl
            // 
            this.subject_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subject_lbl.AutoSize = true;
            this.subject_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subject_lbl.Location = new System.Drawing.Point(3, 7);
            this.subject_lbl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.subject_lbl.Name = "subject_lbl";
            this.subject_lbl.Size = new System.Drawing.Size(69, 16);
            this.subject_lbl.TabIndex = 2;
            this.subject_lbl.Text = "Предмет:";
            // 
            // subject_cb
            // 
            this.subject_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subject_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subject_cb.FormattingEnabled = true;
            this.subject_cb.Location = new System.Drawing.Point(75, 3);
            this.subject_cb.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.subject_cb.Name = "subject_cb";
            this.subject_cb.Size = new System.Drawing.Size(190, 24);
            this.subject_cb.TabIndex = 3;
            this.subject_cb.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // class_lbl
            // 
            this.class_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.class_lbl.AutoSize = true;
            this.class_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.class_lbl.Location = new System.Drawing.Point(285, 7);
            this.class_lbl.Margin = new System.Windows.Forms.Padding(20, 3, 3, 0);
            this.class_lbl.Name = "class_lbl";
            this.class_lbl.Size = new System.Drawing.Size(49, 16);
            this.class_lbl.TabIndex = 0;
            this.class_lbl.Text = "Класс:";
            // 
            // class_cb
            // 
            this.class_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.class_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.class_cb.FormattingEnabled = true;
            this.class_cb.Location = new System.Drawing.Point(337, 3);
            this.class_cb.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.class_cb.Name = "class_cb";
            this.class_cb.Size = new System.Drawing.Size(70, 24);
            this.class_cb.TabIndex = 1;
            this.class_cb.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // marks_tbl
            // 
            this.marks_tbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marks_tbl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.marks_tbl.ColumnCount = 2;
            this.marks_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.marks_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.marks_tbl.Location = new System.Drawing.Point(0, 100);
            this.marks_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.marks_tbl.Name = "marks_tbl";
            this.marks_tbl.RowCount = 1;
            this.marks_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.marks_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.marks_tbl.Size = new System.Drawing.Size(800, 30);
            this.marks_tbl.TabIndex = 9;
            // 
            // GradingTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainContainer_tbl);
            this.Name = "GradingTeacher";
            this.Text = "GradingTeacher";
            this.mainContainer_tbl.ResumeLayout(false);
            this.mainContainer_tbl.PerformLayout();
            this.pupleSelection_flp.ResumeLayout(false);
            this.pupleSelection_flp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainContainer_tbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.FlowLayoutPanel pupleSelection_flp;
        private System.Windows.Forms.Label class_lbl;
        private CustomComboBox class_cb;
        private System.Windows.Forms.TableLayoutPanel marks_tbl;
        private System.Windows.Forms.Label subject_lbl;
        private CustomComboBox subject_cb;
    }
}