namespace CourseWork
{
    partial class Shedule
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
            this.mainLayout_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.pupleSelection_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.puple_lbl = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.puple_cb = new CourseWork.CustomComboBox();
            this.dayMon_lbl = new System.Windows.Forms.Label();
            this.dayTue_lbl = new System.Windows.Forms.Label();
            this.dayWed_lbl = new System.Windows.Forms.Label();
            this.dayThu_lbl = new System.Windows.Forms.Label();
            this.dayFri_lbl = new System.Windows.Forms.Label();
            this.daySat_lbl = new System.Windows.Forms.Label();
            this.shedule_table = new System.Windows.Forms.TableLayoutPanel();
            this.lesson1_lbl = new System.Windows.Forms.Label();
            this.lesson2_lbl = new System.Windows.Forms.Label();
            this.lesson3_lbl = new System.Windows.Forms.Label();
            this.lesson4_lbl = new System.Windows.Forms.Label();
            this.lesson5_lbl = new System.Windows.Forms.Label();
            this.lesson6_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mainLayout_tbl.SuspendLayout();
            this.pupleSelection_flp.SuspendLayout();
            this.shedule_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout_tbl
            // 
            this.mainLayout_tbl.AutoSize = true;
            this.mainLayout_tbl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainLayout_tbl.ColumnCount = 1;
            this.mainLayout_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout_tbl.Controls.Add(this.pupleSelection_flp, 0, 1);
            this.mainLayout_tbl.Controls.Add(this.title_lbl, 0, 0);
            this.mainLayout_tbl.Controls.Add(this.shedule_table, 0, 2);
            this.mainLayout_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout_tbl.Location = new System.Drawing.Point(0, 0);
            this.mainLayout_tbl.MinimumSize = new System.Drawing.Size(880, 450);
            this.mainLayout_tbl.Name = "mainLayout_tbl";
            this.mainLayout_tbl.RowCount = 3;
            this.mainLayout_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.mainLayout_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout_tbl.Size = new System.Drawing.Size(884, 450);
            this.mainLayout_tbl.TabIndex = 0;
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
            this.pupleSelection_flp.Size = new System.Drawing.Size(884, 30);
            this.pupleSelection_flp.TabIndex = 9;
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
            // title_lbl
            // 
            this.title_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.title_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title_lbl.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_lbl.Location = new System.Drawing.Point(0, 0);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(884, 70);
            this.title_lbl.TabIndex = 1;
            this.title_lbl.Text = "Расписание занятий";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // puple_cb
            // 
            this.puple_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.puple_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.puple_cb.FormattingEnabled = true;
            this.puple_cb.Location = new System.Drawing.Point(68, 3);
            this.puple_cb.Name = "puple_cb";
            this.puple_cb.Size = new System.Drawing.Size(200, 24);
            this.puple_cb.TabIndex = 1;
            this.puple_cb.SelectedValueChanged += new System.EventHandler(this.puple_cb_SelectedValueChanged);
            // 
            // dayMon_lbl
            // 
            this.dayMon_lbl.AutoSize = true;
            this.dayMon_lbl.BackColor = System.Drawing.Color.Gold;
            this.dayMon_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayMon_lbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayMon_lbl.Location = new System.Drawing.Point(1, 32);
            this.dayMon_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.dayMon_lbl.Name = "dayMon_lbl";
            this.dayMon_lbl.Size = new System.Drawing.Size(120, 52);
            this.dayMon_lbl.TabIndex = 9;
            this.dayMon_lbl.Text = "Понедельник";
            this.dayMon_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayTue_lbl
            // 
            this.dayTue_lbl.AutoSize = true;
            this.dayTue_lbl.BackColor = System.Drawing.Color.Green;
            this.dayTue_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayTue_lbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayTue_lbl.Location = new System.Drawing.Point(1, 85);
            this.dayTue_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.dayTue_lbl.Name = "dayTue_lbl";
            this.dayTue_lbl.Size = new System.Drawing.Size(120, 52);
            this.dayTue_lbl.TabIndex = 10;
            this.dayTue_lbl.Text = "Вторник";
            this.dayTue_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayWed_lbl
            // 
            this.dayWed_lbl.AutoSize = true;
            this.dayWed_lbl.BackColor = System.Drawing.Color.Turquoise;
            this.dayWed_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayWed_lbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayWed_lbl.Location = new System.Drawing.Point(1, 138);
            this.dayWed_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.dayWed_lbl.Name = "dayWed_lbl";
            this.dayWed_lbl.Size = new System.Drawing.Size(120, 52);
            this.dayWed_lbl.TabIndex = 11;
            this.dayWed_lbl.Text = "Среда";
            this.dayWed_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayThu_lbl
            // 
            this.dayThu_lbl.AutoSize = true;
            this.dayThu_lbl.BackColor = System.Drawing.Color.Purple;
            this.dayThu_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayThu_lbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayThu_lbl.Location = new System.Drawing.Point(1, 191);
            this.dayThu_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.dayThu_lbl.Name = "dayThu_lbl";
            this.dayThu_lbl.Size = new System.Drawing.Size(120, 52);
            this.dayThu_lbl.TabIndex = 12;
            this.dayThu_lbl.Text = "Четверг";
            this.dayThu_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayFri_lbl
            // 
            this.dayFri_lbl.AutoSize = true;
            this.dayFri_lbl.BackColor = System.Drawing.Color.OrangeRed;
            this.dayFri_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayFri_lbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayFri_lbl.Location = new System.Drawing.Point(1, 244);
            this.dayFri_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.dayFri_lbl.Name = "dayFri_lbl";
            this.dayFri_lbl.Size = new System.Drawing.Size(120, 52);
            this.dayFri_lbl.TabIndex = 13;
            this.dayFri_lbl.Text = "Пятница";
            this.dayFri_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // daySat_lbl
            // 
            this.daySat_lbl.AutoSize = true;
            this.daySat_lbl.BackColor = System.Drawing.Color.DarkOrange;
            this.daySat_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.daySat_lbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daySat_lbl.Location = new System.Drawing.Point(1, 297);
            this.daySat_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.daySat_lbl.Name = "daySat_lbl";
            this.daySat_lbl.Size = new System.Drawing.Size(120, 52);
            this.daySat_lbl.TabIndex = 14;
            this.daySat_lbl.Text = "Суббота";
            this.daySat_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shedule_table
            // 
            this.shedule_table.BackColor = System.Drawing.SystemColors.Control;
            this.shedule_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.shedule_table.ColumnCount = 8;
            this.shedule_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.shedule_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.shedule_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.shedule_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.shedule_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.shedule_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.shedule_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.shedule_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.shedule_table.Controls.Add(this.daySat_lbl, 0, 6);
            this.shedule_table.Controls.Add(this.dayFri_lbl, 0, 5);
            this.shedule_table.Controls.Add(this.dayThu_lbl, 0, 4);
            this.shedule_table.Controls.Add(this.dayWed_lbl, 0, 3);
            this.shedule_table.Controls.Add(this.dayTue_lbl, 0, 2);
            this.shedule_table.Controls.Add(this.label6, 7, 0);
            this.shedule_table.Controls.Add(this.lesson6_lbl, 6, 0);
            this.shedule_table.Controls.Add(this.lesson5_lbl, 5, 0);
            this.shedule_table.Controls.Add(this.lesson4_lbl, 4, 0);
            this.shedule_table.Controls.Add(this.lesson3_lbl, 3, 0);
            this.shedule_table.Controls.Add(this.lesson2_lbl, 2, 0);
            this.shedule_table.Controls.Add(this.lesson1_lbl, 1, 0);
            this.shedule_table.Controls.Add(this.dayMon_lbl, 0, 1);
            this.shedule_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shedule_table.Location = new System.Drawing.Point(0, 100);
            this.shedule_table.Margin = new System.Windows.Forms.Padding(0);
            this.shedule_table.Name = "shedule_table";
            this.shedule_table.RowCount = 7;
            this.shedule_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.shedule_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.shedule_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.shedule_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.shedule_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.shedule_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.shedule_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.shedule_table.Size = new System.Drawing.Size(884, 350);
            this.shedule_table.TabIndex = 2;
            // 
            // lesson1_lbl
            // 
            this.lesson1_lbl.AutoSize = true;
            this.lesson1_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lesson1_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lesson1_lbl.Location = new System.Drawing.Point(123, 2);
            this.lesson1_lbl.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.lesson1_lbl.Name = "lesson1_lbl";
            this.lesson1_lbl.Size = new System.Drawing.Size(108, 29);
            this.lesson1_lbl.TabIndex = 0;
            this.lesson1_lbl.Text = "1 урок";
            this.lesson1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lesson2_lbl
            // 
            this.lesson2_lbl.AutoSize = true;
            this.lesson2_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lesson2_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lesson2_lbl.Location = new System.Drawing.Point(233, 2);
            this.lesson2_lbl.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.lesson2_lbl.Name = "lesson2_lbl";
            this.lesson2_lbl.Size = new System.Drawing.Size(108, 29);
            this.lesson2_lbl.TabIndex = 2;
            this.lesson2_lbl.Text = "2 урок";
            this.lesson2_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lesson3_lbl
            // 
            this.lesson3_lbl.AutoSize = true;
            this.lesson3_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lesson3_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lesson3_lbl.Location = new System.Drawing.Point(343, 2);
            this.lesson3_lbl.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.lesson3_lbl.Name = "lesson3_lbl";
            this.lesson3_lbl.Size = new System.Drawing.Size(108, 29);
            this.lesson3_lbl.TabIndex = 4;
            this.lesson3_lbl.Text = "3 урок";
            this.lesson3_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lesson4_lbl
            // 
            this.lesson4_lbl.AutoSize = true;
            this.lesson4_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lesson4_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lesson4_lbl.Location = new System.Drawing.Point(453, 2);
            this.lesson4_lbl.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.lesson4_lbl.Name = "lesson4_lbl";
            this.lesson4_lbl.Size = new System.Drawing.Size(108, 29);
            this.lesson4_lbl.TabIndex = 5;
            this.lesson4_lbl.Text = "4 урок";
            this.lesson4_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lesson5_lbl
            // 
            this.lesson5_lbl.AutoSize = true;
            this.lesson5_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lesson5_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lesson5_lbl.Location = new System.Drawing.Point(563, 2);
            this.lesson5_lbl.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.lesson5_lbl.Name = "lesson5_lbl";
            this.lesson5_lbl.Size = new System.Drawing.Size(108, 29);
            this.lesson5_lbl.TabIndex = 6;
            this.lesson5_lbl.Text = "5 урок";
            this.lesson5_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lesson6_lbl
            // 
            this.lesson6_lbl.AutoSize = true;
            this.lesson6_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lesson6_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lesson6_lbl.Location = new System.Drawing.Point(673, 2);
            this.lesson6_lbl.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.lesson6_lbl.Name = "lesson6_lbl";
            this.lesson6_lbl.Size = new System.Drawing.Size(108, 29);
            this.lesson6_lbl.TabIndex = 7;
            this.lesson6_lbl.Text = "6 урок";
            this.lesson6_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(783, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "7 урок";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Shedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.mainLayout_tbl);
            this.Name = "Shedule";
            this.Text = "Calendar";
            this.mainLayout_tbl.ResumeLayout(false);
            this.mainLayout_tbl.PerformLayout();
            this.pupleSelection_flp.ResumeLayout(false);
            this.pupleSelection_flp.PerformLayout();
            this.shedule_table.ResumeLayout(false);
            this.shedule_table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout_tbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.FlowLayoutPanel pupleSelection_flp;
        private System.Windows.Forms.Label puple_lbl;
        private CustomComboBox puple_cb;
        private System.Windows.Forms.TableLayoutPanel shedule_table;
        private System.Windows.Forms.Label daySat_lbl;
        private System.Windows.Forms.Label dayFri_lbl;
        private System.Windows.Forms.Label dayThu_lbl;
        private System.Windows.Forms.Label dayWed_lbl;
        private System.Windows.Forms.Label dayTue_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lesson6_lbl;
        private System.Windows.Forms.Label lesson5_lbl;
        private System.Windows.Forms.Label lesson4_lbl;
        private System.Windows.Forms.Label lesson3_lbl;
        private System.Windows.Forms.Label lesson2_lbl;
        private System.Windows.Forms.Label lesson1_lbl;
        private System.Windows.Forms.Label dayMon_lbl;
    }
}