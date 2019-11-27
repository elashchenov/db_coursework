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
            this.mainContainer_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.pupleSelection_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.puple_lbl = new System.Windows.Forms.Label();
            this.puple_cb = new CourseWork.CustomComboBox();
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
            this.pupleSelection_flp.AutoSize = true;
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
            this.puple_lbl.Location = new System.Drawing.Point(3, 8);
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
            this.puple_cb.Location = new System.Drawing.Point(68, 3);
            this.puple_cb.Name = "puple_cb";
            this.puple_cb.Size = new System.Drawing.Size(320, 24);
            this.puple_cb.TabIndex = 1;
            this.puple_cb.SelectedValueChanged += new System.EventHandler(this.puple_cb_SelectedValueChanged);
            // 
            // marks_tbl
            // 
            this.marks_tbl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.marks_tbl.ColumnCount = 2;
            this.marks_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.marks_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.marks_tbl.Location = new System.Drawing.Point(0, 100);
            this.marks_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.marks_tbl.Name = "marks_tbl";
            this.marks_tbl.RowCount = 1;
            this.marks_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.marks_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.marks_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.marks_tbl.Size = new System.Drawing.Size(800, 30);
            this.marks_tbl.TabIndex = 9;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainContainer_tbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.FlowLayoutPanel pupleSelection_flp;
        private System.Windows.Forms.Label puple_lbl;
        private CustomComboBox puple_cb;
        private System.Windows.Forms.TableLayoutPanel marks_tbl;
    }
}