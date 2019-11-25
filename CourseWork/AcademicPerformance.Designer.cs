namespace CourseWork
{
    partial class AcademicPerformance
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
            this.components = new System.ComponentModel.Container();
            this.mainContainer_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.pupleSelection_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.puple_lbl = new System.Windows.Forms.Label();
            this.puple_cb = new CourseWork.CustomComboBox();
            this.marks_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.markLabel1 = new CourseWork.MarkLabel();
            this.markLabel2 = new CourseWork.MarkLabel();
            this.markLabel3 = new CourseWork.MarkLabel();
            this.markLabel4 = new CourseWork.MarkLabel();
            this.mainContainer_tbl.SuspendLayout();
            this.pupleSelection_flp.SuspendLayout();
            this.marks_tbl.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.mainContainer_tbl.Name = "mainContainer_tbl";
            this.mainContainer_tbl.RowCount = 3;
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mainContainer_tbl.Size = new System.Drawing.Size(800, 450);
            this.mainContainer_tbl.TabIndex = 0;
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
            this.title_lbl.Text = "Успеваемость";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pupleSelection_flp
            // 
            this.pupleSelection_flp.Controls.Add(this.puple_lbl);
            this.pupleSelection_flp.Controls.Add(this.puple_cb);
            this.pupleSelection_flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pupleSelection_flp.Location = new System.Drawing.Point(0, 70);
            this.pupleSelection_flp.Margin = new System.Windows.Forms.Padding(0);
            this.pupleSelection_flp.Name = "pupleSelection_flp";
            this.pupleSelection_flp.Size = new System.Drawing.Size(800, 30);
            this.pupleSelection_flp.TabIndex = 8;
            // 
            // puple_lbl
            // 
            this.puple_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.puple_lbl.AutoSize = true;
            this.puple_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.puple_lbl.Location = new System.Drawing.Point(3, 6);
            this.puple_lbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.puple_lbl.Name = "puple_lbl";
            this.puple_lbl.Size = new System.Drawing.Size(59, 16);
            this.puple_lbl.TabIndex = 0;
            this.puple_lbl.Text = "Ученик:";
            // 
            // puple_cb
            // 
            this.puple_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.puple_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.puple_cb.FormattingEnabled = true;
            this.puple_cb.Location = new System.Drawing.Point(65, 3);
            this.puple_cb.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.puple_cb.Name = "puple_cb";
            this.puple_cb.Size = new System.Drawing.Size(200, 24);
            this.puple_cb.TabIndex = 1;
            // 
            // marks_tbl
            // 
            this.marks_tbl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.marks_tbl.ColumnCount = 2;
            this.marks_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.marks_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.marks_tbl.Controls.Add(this.label1, 0, 0);
            this.marks_tbl.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.marks_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marks_tbl.Location = new System.Drawing.Point(0, 100);
            this.marks_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.marks_tbl.Name = "marks_tbl";
            this.marks_tbl.RowCount = 3;
            this.marks_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.marks_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.marks_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.marks_tbl.Size = new System.Drawing.Size(800, 350);
            this.marks_tbl.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информатика и ИКТ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.markLabel1);
            this.flowLayoutPanel1.Controls.Add(this.markLabel2);
            this.flowLayoutPanel1.Controls.Add(this.markLabel3);
            this.flowLayoutPanel1.Controls.Add(this.markLabel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(202, 1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(597, 30);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // markLabel1
            // 
            this.markLabel1._BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(255)))), ((int)(((byte)(68)))));
            this.markLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.markLabel1.AutoSize = true;
            this.markLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markLabel1.ForeColor = System.Drawing.SystemColors.Window;
            this.markLabel1.Location = new System.Drawing.Point(3, 4);
            this.markLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.markLabel1.Name = "markLabel1";
            this.markLabel1.Size = new System.Drawing.Size(19, 20);
            this.markLabel1.TabIndex = 0;
            this.markLabel1.Text = "5";
            // 
            // markLabel2
            // 
            this.markLabel2._BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.markLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.markLabel2.AutoSize = true;
            this.markLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markLabel2.ForeColor = System.Drawing.SystemColors.Window;
            this.markLabel2.Location = new System.Drawing.Point(28, 4);
            this.markLabel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.markLabel2.Name = "markLabel2";
            this.markLabel2.Size = new System.Drawing.Size(19, 20);
            this.markLabel2.TabIndex = 1;
            this.markLabel2.Text = "4";
            // 
            // markLabel3
            // 
            this.markLabel3._BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.markLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.markLabel3.AutoSize = true;
            this.markLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markLabel3.ForeColor = System.Drawing.SystemColors.Window;
            this.markLabel3.Location = new System.Drawing.Point(53, 4);
            this.markLabel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.markLabel3.Name = "markLabel3";
            this.markLabel3.Size = new System.Drawing.Size(19, 20);
            this.markLabel3.TabIndex = 2;
            this.markLabel3.Text = "3";
            // 
            // markLabel4
            // 
            this.markLabel4._BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(34)))), ((int)(((byte)(0)))));
            this.markLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.markLabel4.AutoSize = true;
            this.markLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markLabel4.ForeColor = System.Drawing.SystemColors.Window;
            this.markLabel4.Location = new System.Drawing.Point(78, 4);
            this.markLabel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.markLabel4.Name = "markLabel4";
            this.markLabel4.Size = new System.Drawing.Size(19, 20);
            this.markLabel4.TabIndex = 3;
            this.markLabel4.Text = "2";
            // 
            // AcademicPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainContainer_tbl);
            this.Name = "AcademicPerformance";
            this.Text = "AcademicPerformance";
            this.mainContainer_tbl.ResumeLayout(false);
            this.mainContainer_tbl.PerformLayout();
            this.pupleSelection_flp.ResumeLayout(false);
            this.pupleSelection_flp.PerformLayout();
            this.marks_tbl.ResumeLayout(false);
            this.marks_tbl.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainContainer_tbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.FlowLayoutPanel pupleSelection_flp;
        private System.Windows.Forms.Label puple_lbl;
        private CustomComboBox puple_cb;
        private System.Windows.Forms.TableLayoutPanel marks_tbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MarkLabel markLabel1;
        private MarkLabel markLabel2;
        private MarkLabel markLabel3;
        private MarkLabel markLabel4;
    }
}