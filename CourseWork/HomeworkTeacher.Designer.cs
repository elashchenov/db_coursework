namespace CourseWork
{
    partial class HomeworkTeacher
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
            this.components = new System.ComponentModel.Container();
            this.homeworkList_cm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homework_tc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.homeworkCheck_sc = new System.Windows.Forms.SplitContainer();
            this.answerList_lb = new CourseWork.CustomListBox();
            this.checkHomeworkLayout_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.gradeHomework_gb = new System.Windows.Forms.GroupBox();
            this.gradeHomework_tlp = new System.Windows.Forms.TableLayoutPanel();
            this.markComment_lbl = new System.Windows.Forms.Label();
            this.mark_lbl = new System.Windows.Forms.Label();
            this.send_btn = new System.Windows.Forms.Button();
            this.markComment_rtb = new CourseWork.CustomRichTextBox();
            this.mark_cb = new CourseWork.CustomComboBox();
            this.sendedHomework_gb = new System.Windows.Forms.GroupBox();
            this.sendedHomework_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.attachments_lbl = new System.Windows.Forms.Label();
            this.homework_tb = new System.Windows.Forms.TextBox();
            this.pupleNote_lbl = new System.Windows.Forms.Label();
            this.homework_lbl = new System.Windows.Forms.Label();
            this.subject_lbl = new System.Windows.Forms.Label();
            this.subject_tb = new System.Windows.Forms.TextBox();
            this.pupleNote_rtb = new CourseWork.CustomRichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.createHomeworkLayout_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.createHomework_gb = new System.Windows.Forms.GroupBox();
            this.selectHomework_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.classCreate_cb = new CourseWork.CustomComboBox();
            this.classCreate_lbl = new System.Windows.Forms.Label();
            this.homeworkDescr_lbl = new System.Windows.Forms.Label();
            this.homeworkCreate_lbl = new System.Windows.Forms.Label();
            this.subjectCreate_lbl = new System.Windows.Forms.Label();
            this.homeworkCreate_tb = new System.Windows.Forms.TextBox();
            this.publish_btn = new System.Windows.Forms.Button();
            this.subjectCreate_cb = new CourseWork.CustomComboBox();
            this.homeworkDescr_rtb = new CourseWork.CustomRichTextBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.mainContainer_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.homeworkList_cm.SuspendLayout();
            this.homework_tc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeworkCheck_sc)).BeginInit();
            this.homeworkCheck_sc.Panel1.SuspendLayout();
            this.homeworkCheck_sc.Panel2.SuspendLayout();
            this.homeworkCheck_sc.SuspendLayout();
            this.checkHomeworkLayout_tbl.SuspendLayout();
            this.gradeHomework_gb.SuspendLayout();
            this.gradeHomework_tlp.SuspendLayout();
            this.sendedHomework_gb.SuspendLayout();
            this.sendedHomework_tbl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.createHomeworkLayout_tbl.SuspendLayout();
            this.createHomework_gb.SuspendLayout();
            this.selectHomework_tbl.SuspendLayout();
            this.mainContainer_tbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeworkList_cm
            // 
            this.homeworkList_cm.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homeworkList_cm.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.homeworkList_cm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteMenuItem,
            this.refreshMenuItem});
            this.homeworkList_cm.Name = "homeworkList_cm";
            this.homeworkList_cm.Size = new System.Drawing.Size(133, 48);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(132, 22);
            this.deleteMenuItem.Text = "Удалить";
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
            // 
            // refreshMenuItem
            // 
            this.refreshMenuItem.Name = "refreshMenuItem";
            this.refreshMenuItem.Size = new System.Drawing.Size(132, 22);
            this.refreshMenuItem.Text = "Обновить";
            this.refreshMenuItem.Click += new System.EventHandler(this.refreshMenuItem_Click);
            // 
            // homework_tc
            // 
            this.homework_tc.Controls.Add(this.tabPage1);
            this.homework_tc.Controls.Add(this.tabPage2);
            this.homework_tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homework_tc.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homework_tc.Location = new System.Drawing.Point(0, 70);
            this.homework_tc.Margin = new System.Windows.Forms.Padding(0);
            this.homework_tc.Name = "homework_tc";
            this.homework_tc.Padding = new System.Drawing.Point(0, 0);
            this.homework_tc.SelectedIndex = 0;
            this.homework_tc.Size = new System.Drawing.Size(830, 961);
            this.homework_tc.TabIndex = 8;
            this.homework_tc.SelectedIndexChanged += new System.EventHandler(this.homework_tc_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.homeworkCheck_sc);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(822, 933);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Проверка домашних работ";
            // 
            // homeworkCheck_sc
            // 
            this.homeworkCheck_sc.BackColor = System.Drawing.SystemColors.Window;
            this.homeworkCheck_sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeworkCheck_sc.Location = new System.Drawing.Point(0, 0);
            this.homeworkCheck_sc.Margin = new System.Windows.Forms.Padding(0);
            this.homeworkCheck_sc.Name = "homeworkCheck_sc";
            // 
            // homeworkCheck_sc.Panel1
            // 
            this.homeworkCheck_sc.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.homeworkCheck_sc.Panel1.Controls.Add(this.answerList_lb);
            this.homeworkCheck_sc.Panel1MinSize = 155;
            // 
            // homeworkCheck_sc.Panel2
            // 
            this.homeworkCheck_sc.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.homeworkCheck_sc.Panel2.Controls.Add(this.checkHomeworkLayout_tbl);
            this.homeworkCheck_sc.Panel2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.homeworkCheck_sc.Size = new System.Drawing.Size(822, 933);
            this.homeworkCheck_sc.SplitterDistance = 155;
            this.homeworkCheck_sc.SplitterWidth = 1;
            this.homeworkCheck_sc.TabIndex = 0;
            this.homeworkCheck_sc.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.homeworkCheck_sc_SplitterMoved);
            // 
            // answerList_lb
            // 
            this.answerList_lb.ContextMenuStrip = this.homeworkList_cm;
            this.answerList_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerList_lb.FormattingEnabled = true;
            this.answerList_lb.IntegralHeight = false;
            this.answerList_lb.ItemHeight = 15;
            this.answerList_lb.Location = new System.Drawing.Point(0, 0);
            this.answerList_lb.Margin = new System.Windows.Forms.Padding(0);
            this.answerList_lb.Name = "answerList_lb";
            this.answerList_lb.Size = new System.Drawing.Size(155, 933);
            this.answerList_lb.TabIndex = 0;
            this.answerList_lb.SelectedValueChanged += new System.EventHandler(this.homeworkList_lb_SelectedValueChanged);
            // 
            // checkHomeworkLayout_tbl
            // 
            this.checkHomeworkLayout_tbl.ColumnCount = 1;
            this.checkHomeworkLayout_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.checkHomeworkLayout_tbl.Controls.Add(this.gradeHomework_gb, 0, 1);
            this.checkHomeworkLayout_tbl.Controls.Add(this.sendedHomework_gb, 0, 0);
            this.checkHomeworkLayout_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkHomeworkLayout_tbl.Location = new System.Drawing.Point(0, 20);
            this.checkHomeworkLayout_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.checkHomeworkLayout_tbl.Name = "checkHomeworkLayout_tbl";
            this.checkHomeworkLayout_tbl.RowCount = 2;
            this.checkHomeworkLayout_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.checkHomeworkLayout_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.checkHomeworkLayout_tbl.Size = new System.Drawing.Size(666, 913);
            this.checkHomeworkLayout_tbl.TabIndex = 1;
            // 
            // gradeHomework_gb
            // 
            this.gradeHomework_gb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gradeHomework_gb.Controls.Add(this.gradeHomework_tlp);
            this.gradeHomework_gb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gradeHomework_gb.Location = new System.Drawing.Point(48, 290);
            this.gradeHomework_gb.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.gradeHomework_gb.MaximumSize = new System.Drawing.Size(570, 230);
            this.gradeHomework_gb.MinimumSize = new System.Drawing.Size(570, 230);
            this.gradeHomework_gb.Name = "gradeHomework_gb";
            this.gradeHomework_gb.Size = new System.Drawing.Size(570, 230);
            this.gradeHomework_gb.TabIndex = 8;
            this.gradeHomework_gb.TabStop = false;
            this.gradeHomework_gb.Text = "Оценить работу:";
            // 
            // gradeHomework_tlp
            // 
            this.gradeHomework_tlp.ColumnCount = 2;
            this.gradeHomework_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.gradeHomework_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.gradeHomework_tlp.Controls.Add(this.markComment_lbl, 0, 1);
            this.gradeHomework_tlp.Controls.Add(this.mark_lbl, 0, 0);
            this.gradeHomework_tlp.Controls.Add(this.send_btn, 1, 2);
            this.gradeHomework_tlp.Controls.Add(this.markComment_rtb, 1, 1);
            this.gradeHomework_tlp.Controls.Add(this.mark_cb, 1, 0);
            this.gradeHomework_tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradeHomework_tlp.Location = new System.Drawing.Point(3, 26);
            this.gradeHomework_tlp.Margin = new System.Windows.Forms.Padding(0);
            this.gradeHomework_tlp.Name = "gradeHomework_tlp";
            this.gradeHomework_tlp.RowCount = 3;
            this.gradeHomework_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.gradeHomework_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.gradeHomework_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.gradeHomework_tlp.Size = new System.Drawing.Size(564, 201);
            this.gradeHomework_tlp.TabIndex = 0;
            // 
            // markComment_lbl
            // 
            this.markComment_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.markComment_lbl.AutoSize = true;
            this.markComment_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markComment_lbl.Location = new System.Drawing.Point(12, 51);
            this.markComment_lbl.Margin = new System.Windows.Forms.Padding(3, 11, 3, 0);
            this.markComment_lbl.Name = "markComment_lbl";
            this.markComment_lbl.Size = new System.Drawing.Size(154, 18);
            this.markComment_lbl.TabIndex = 11;
            this.markComment_lbl.Text = "Комментарий к работе:";
            // 
            // mark_lbl
            // 
            this.mark_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mark_lbl.AutoSize = true;
            this.mark_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mark_lbl.Location = new System.Drawing.Point(113, 11);
            this.mark_lbl.Name = "mark_lbl";
            this.mark_lbl.Size = new System.Drawing.Size(53, 18);
            this.mark_lbl.TabIndex = 3;
            this.mark_lbl.Text = "Оценка";
            // 
            // send_btn
            // 
            this.send_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.send_btn.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.send_btn.Location = new System.Drawing.Point(379, 163);
            this.send_btn.Margin = new System.Windows.Forms.Padding(0, 3, 72, 0);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(113, 33);
            this.send_btn.TabIndex = 17;
            this.send_btn.Text = "Отправить";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // markComment_rtb
            // 
            this.markComment_rtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.markComment_rtb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markComment_rtb.Location = new System.Drawing.Point(172, 43);
            this.markComment_rtb.Name = "markComment_rtb";
            this.markComment_rtb.Size = new System.Drawing.Size(320, 114);
            this.markComment_rtb.TabIndex = 18;
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
            this.mark_cb.Location = new System.Drawing.Point(172, 6);
            this.mark_cb.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.mark_cb.Name = "mark_cb";
            this.mark_cb.Size = new System.Drawing.Size(320, 26);
            this.mark_cb.TabIndex = 19;
            // 
            // sendedHomework_gb
            // 
            this.sendedHomework_gb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sendedHomework_gb.Controls.Add(this.sendedHomework_tbl);
            this.sendedHomework_gb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendedHomework_gb.Location = new System.Drawing.Point(48, 0);
            this.sendedHomework_gb.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.sendedHomework_gb.MaximumSize = new System.Drawing.Size(570, 260);
            this.sendedHomework_gb.MinimumSize = new System.Drawing.Size(570, 260);
            this.sendedHomework_gb.Name = "sendedHomework_gb";
            this.sendedHomework_gb.Padding = new System.Windows.Forms.Padding(0);
            this.sendedHomework_gb.Size = new System.Drawing.Size(570, 260);
            this.sendedHomework_gb.TabIndex = 7;
            this.sendedHomework_gb.TabStop = false;
            this.sendedHomework_gb.Text = "Домашнее задание на проверку:";
            // 
            // sendedHomework_tbl
            // 
            this.sendedHomework_tbl.AutoSize = true;
            this.sendedHomework_tbl.ColumnCount = 2;
            this.sendedHomework_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.sendedHomework_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.sendedHomework_tbl.Controls.Add(this.attachments_lbl, 0, 3);
            this.sendedHomework_tbl.Controls.Add(this.homework_tb, 1, 1);
            this.sendedHomework_tbl.Controls.Add(this.pupleNote_lbl, 0, 2);
            this.sendedHomework_tbl.Controls.Add(this.homework_lbl, 0, 1);
            this.sendedHomework_tbl.Controls.Add(this.subject_lbl, 0, 0);
            this.sendedHomework_tbl.Controls.Add(this.subject_tb, 1, 0);
            this.sendedHomework_tbl.Controls.Add(this.pupleNote_rtb, 1, 2);
            this.sendedHomework_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendedHomework_tbl.Location = new System.Drawing.Point(0, 23);
            this.sendedHomework_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.sendedHomework_tbl.Name = "sendedHomework_tbl";
            this.sendedHomework_tbl.RowCount = 4;
            this.sendedHomework_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.sendedHomework_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.sendedHomework_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.sendedHomework_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.sendedHomework_tbl.Size = new System.Drawing.Size(570, 237);
            this.sendedHomework_tbl.TabIndex = 0;
            // 
            // attachments_lbl
            // 
            this.attachments_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.attachments_lbl.AutoSize = true;
            this.attachments_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attachments_lbl.Location = new System.Drawing.Point(7, 209);
            this.attachments_lbl.Name = "attachments_lbl";
            this.attachments_lbl.Size = new System.Drawing.Size(161, 18);
            this.attachments_lbl.TabIndex = 15;
            this.attachments_lbl.Text = "Прикрепленные файлы:";
            // 
            // homework_tb
            // 
            this.homework_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.homework_tb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homework_tb.Location = new System.Drawing.Point(174, 47);
            this.homework_tb.Name = "homework_tb";
            this.homework_tb.ReadOnly = true;
            this.homework_tb.Size = new System.Drawing.Size(320, 26);
            this.homework_tb.TabIndex = 14;
            // 
            // pupleNote_lbl
            // 
            this.pupleNote_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pupleNote_lbl.AutoSize = true;
            this.pupleNote_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pupleNote_lbl.Location = new System.Drawing.Point(17, 91);
            this.pupleNote_lbl.Margin = new System.Windows.Forms.Padding(3, 11, 3, 0);
            this.pupleNote_lbl.Name = "pupleNote_lbl";
            this.pupleNote_lbl.Size = new System.Drawing.Size(151, 18);
            this.pupleNote_lbl.TabIndex = 11;
            this.pupleNote_lbl.Text = "Комментарий ученика:";
            // 
            // homework_lbl
            // 
            this.homework_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.homework_lbl.AutoSize = true;
            this.homework_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homework_lbl.Location = new System.Drawing.Point(36, 51);
            this.homework_lbl.Name = "homework_lbl";
            this.homework_lbl.Size = new System.Drawing.Size(132, 18);
            this.homework_lbl.TabIndex = 9;
            this.homework_lbl.Text = "Домашнее задание:";
            // 
            // subject_lbl
            // 
            this.subject_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.subject_lbl.AutoSize = true;
            this.subject_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subject_lbl.Location = new System.Drawing.Point(99, 11);
            this.subject_lbl.Name = "subject_lbl";
            this.subject_lbl.Size = new System.Drawing.Size(69, 18);
            this.subject_lbl.TabIndex = 3;
            this.subject_lbl.Text = "Предмет:";
            // 
            // subject_tb
            // 
            this.subject_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subject_tb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subject_tb.Location = new System.Drawing.Point(174, 7);
            this.subject_tb.Name = "subject_tb";
            this.subject_tb.ReadOnly = true;
            this.subject_tb.Size = new System.Drawing.Size(320, 26);
            this.subject_tb.TabIndex = 13;
            // 
            // pupleNote_rtb
            // 
            this.pupleNote_rtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pupleNote_rtb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pupleNote_rtb.Location = new System.Drawing.Point(174, 83);
            this.pupleNote_rtb.Name = "pupleNote_rtb";
            this.pupleNote_rtb.ReadOnly = true;
            this.pupleNote_rtb.Size = new System.Drawing.Size(320, 114);
            this.pupleNote_rtb.TabIndex = 16;
            this.pupleNote_rtb.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.createHomeworkLayout_tbl);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(822, 933);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задать домашнее задание";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // createHomeworkLayout_tbl
            // 
            this.createHomeworkLayout_tbl.ColumnCount = 1;
            this.createHomeworkLayout_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.createHomeworkLayout_tbl.Controls.Add(this.createHomework_gb, 0, 0);
            this.createHomeworkLayout_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createHomeworkLayout_tbl.Location = new System.Drawing.Point(0, 0);
            this.createHomeworkLayout_tbl.Name = "createHomeworkLayout_tbl";
            this.createHomeworkLayout_tbl.RowCount = 1;
            this.createHomeworkLayout_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.createHomeworkLayout_tbl.Size = new System.Drawing.Size(822, 933);
            this.createHomeworkLayout_tbl.TabIndex = 0;
            // 
            // createHomework_gb
            // 
            this.createHomework_gb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.createHomework_gb.Controls.Add(this.selectHomework_tbl);
            this.createHomework_gb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createHomework_gb.Location = new System.Drawing.Point(146, 30);
            this.createHomework_gb.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.createHomework_gb.MaximumSize = new System.Drawing.Size(530, 310);
            this.createHomework_gb.MinimumSize = new System.Drawing.Size(530, 310);
            this.createHomework_gb.Name = "createHomework_gb";
            this.createHomework_gb.Size = new System.Drawing.Size(530, 310);
            this.createHomework_gb.TabIndex = 7;
            this.createHomework_gb.TabStop = false;
            this.createHomework_gb.Text = "Создание домашнего задания:";
            // 
            // selectHomework_tbl
            // 
            this.selectHomework_tbl.ColumnCount = 2;
            this.selectHomework_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.selectHomework_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.selectHomework_tbl.Controls.Add(this.classCreate_cb, 0, 0);
            this.selectHomework_tbl.Controls.Add(this.classCreate_lbl, 0, 0);
            this.selectHomework_tbl.Controls.Add(this.homeworkDescr_lbl, 0, 3);
            this.selectHomework_tbl.Controls.Add(this.homeworkCreate_lbl, 0, 2);
            this.selectHomework_tbl.Controls.Add(this.subjectCreate_lbl, 0, 1);
            this.selectHomework_tbl.Controls.Add(this.homeworkCreate_tb, 1, 2);
            this.selectHomework_tbl.Controls.Add(this.publish_btn, 1, 4);
            this.selectHomework_tbl.Controls.Add(this.subjectCreate_cb, 1, 1);
            this.selectHomework_tbl.Controls.Add(this.homeworkDescr_rtb, 1, 3);
            this.selectHomework_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectHomework_tbl.Location = new System.Drawing.Point(3, 26);
            this.selectHomework_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.selectHomework_tbl.Name = "selectHomework_tbl";
            this.selectHomework_tbl.RowCount = 5;
            this.selectHomework_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.selectHomework_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.selectHomework_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.selectHomework_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.selectHomework_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.selectHomework_tbl.Size = new System.Drawing.Size(524, 281);
            this.selectHomework_tbl.TabIndex = 0;
            // 
            // classCreate_cb
            // 
            this.classCreate_cb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.classCreate_cb.DropDownHeight = 200;
            this.classCreate_cb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classCreate_cb.FormattingEnabled = true;
            this.classCreate_cb.IntegralHeight = false;
            this.classCreate_cb.Location = new System.Drawing.Point(160, 7);
            this.classCreate_cb.Name = "classCreate_cb";
            this.classCreate_cb.Size = new System.Drawing.Size(320, 26);
            this.classCreate_cb.TabIndex = 23;
            this.classCreate_cb.SelectedIndexChanged += new System.EventHandler(this.Fields_Validating);
            // 
            // classCreate_lbl
            // 
            this.classCreate_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.classCreate_lbl.AutoSize = true;
            this.classCreate_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classCreate_lbl.Location = new System.Drawing.Point(105, 11);
            this.classCreate_lbl.Name = "classCreate_lbl";
            this.classCreate_lbl.Size = new System.Drawing.Size(49, 18);
            this.classCreate_lbl.TabIndex = 21;
            this.classCreate_lbl.Text = "Класс:";
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
            // homeworkCreate_lbl
            // 
            this.homeworkCreate_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.homeworkCreate_lbl.AutoSize = true;
            this.homeworkCreate_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homeworkCreate_lbl.Location = new System.Drawing.Point(22, 91);
            this.homeworkCreate_lbl.Name = "homeworkCreate_lbl";
            this.homeworkCreate_lbl.Size = new System.Drawing.Size(132, 18);
            this.homeworkCreate_lbl.TabIndex = 9;
            this.homeworkCreate_lbl.Text = "Домашнее задание:";
            // 
            // subjectCreate_lbl
            // 
            this.subjectCreate_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.subjectCreate_lbl.AutoSize = true;
            this.subjectCreate_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectCreate_lbl.Location = new System.Drawing.Point(85, 51);
            this.subjectCreate_lbl.Name = "subjectCreate_lbl";
            this.subjectCreate_lbl.Size = new System.Drawing.Size(69, 18);
            this.subjectCreate_lbl.TabIndex = 3;
            this.subjectCreate_lbl.Text = "Предмет:";
            // 
            // homeworkCreate_tb
            // 
            this.homeworkCreate_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.homeworkCreate_tb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homeworkCreate_tb.Location = new System.Drawing.Point(160, 87);
            this.homeworkCreate_tb.Name = "homeworkCreate_tb";
            this.homeworkCreate_tb.Size = new System.Drawing.Size(320, 26);
            this.homeworkCreate_tb.TabIndex = 13;
            this.homeworkCreate_tb.TextChanged += new System.EventHandler(this.Fields_Validating);
            // 
            // publish_btn
            // 
            this.publish_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.publish_btn.Enabled = false;
            this.publish_btn.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publish_btn.Location = new System.Drawing.Point(357, 245);
            this.publish_btn.Margin = new System.Windows.Forms.Padding(0, 3, 44, 0);
            this.publish_btn.Name = "publish_btn";
            this.publish_btn.Size = new System.Drawing.Size(123, 33);
            this.publish_btn.TabIndex = 18;
            this.publish_btn.Text = "Опубликовать";
            this.publish_btn.UseVisualStyleBackColor = true;
            this.publish_btn.Click += new System.EventHandler(this.publish_btn_Click);
            // 
            // subjectCreate_cb
            // 
            this.subjectCreate_cb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subjectCreate_cb.DropDownHeight = 200;
            this.subjectCreate_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectCreate_cb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectCreate_cb.FormattingEnabled = true;
            this.subjectCreate_cb.IntegralHeight = false;
            this.subjectCreate_cb.Location = new System.Drawing.Point(160, 46);
            this.subjectCreate_cb.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.subjectCreate_cb.Name = "subjectCreate_cb";
            this.subjectCreate_cb.Size = new System.Drawing.Size(320, 26);
            this.subjectCreate_cb.TabIndex = 19;
            this.subjectCreate_cb.SelectedIndexChanged += new System.EventHandler(this.Fields_Validating);
            // 
            // homeworkDescr_rtb
            // 
            this.homeworkDescr_rtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.homeworkDescr_rtb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homeworkDescr_rtb.Location = new System.Drawing.Point(160, 123);
            this.homeworkDescr_rtb.Name = "homeworkDescr_rtb";
            this.homeworkDescr_rtb.Size = new System.Drawing.Size(320, 114);
            this.homeworkDescr_rtb.TabIndex = 20;
            this.homeworkDescr_rtb.Text = "";
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
            this.title_lbl.Size = new System.Drawing.Size(830, 70);
            this.title_lbl.TabIndex = 7;
            this.title_lbl.Text = "Домашние задания";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainContainer_tbl
            // 
            this.mainContainer_tbl.AutoScroll = true;
            this.mainContainer_tbl.BackColor = System.Drawing.SystemColors.Window;
            this.mainContainer_tbl.ColumnCount = 1;
            this.mainContainer_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer_tbl.Controls.Add(this.title_lbl, 0, 0);
            this.mainContainer_tbl.Controls.Add(this.homework_tc, 0, 1);
            this.mainContainer_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer_tbl.Location = new System.Drawing.Point(0, 0);
            this.mainContainer_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.mainContainer_tbl.Name = "mainContainer_tbl";
            this.mainContainer_tbl.RowCount = 2;
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.mainContainer_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.mainContainer_tbl.Size = new System.Drawing.Size(847, 456);
            this.mainContainer_tbl.TabIndex = 0;
            this.mainContainer_tbl.Resize += new System.EventHandler(this.mainContainer_tbl_Resize);
            // 
            // HomeworkTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 456);
            this.Controls.Add(this.mainContainer_tbl);
            this.Name = "HomeworkTeacher";
            this.Text = "HomeworkTeacher";
            this.homeworkList_cm.ResumeLayout(false);
            this.homework_tc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.homeworkCheck_sc.Panel1.ResumeLayout(false);
            this.homeworkCheck_sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeworkCheck_sc)).EndInit();
            this.homeworkCheck_sc.ResumeLayout(false);
            this.checkHomeworkLayout_tbl.ResumeLayout(false);
            this.gradeHomework_gb.ResumeLayout(false);
            this.gradeHomework_tlp.ResumeLayout(false);
            this.gradeHomework_tlp.PerformLayout();
            this.sendedHomework_gb.ResumeLayout(false);
            this.sendedHomework_gb.PerformLayout();
            this.sendedHomework_tbl.ResumeLayout(false);
            this.sendedHomework_tbl.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.createHomeworkLayout_tbl.ResumeLayout(false);
            this.createHomework_gb.ResumeLayout(false);
            this.selectHomework_tbl.ResumeLayout(false);
            this.selectHomework_tbl.PerformLayout();
            this.mainContainer_tbl.ResumeLayout(false);
            this.mainContainer_tbl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip homeworkList_cm;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshMenuItem;
        private System.Windows.Forms.TabControl homework_tc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer homeworkCheck_sc;
        private System.Windows.Forms.TableLayoutPanel checkHomeworkLayout_tbl;
        private System.Windows.Forms.GroupBox gradeHomework_gb;
        private System.Windows.Forms.TableLayoutPanel gradeHomework_tlp;
        private System.Windows.Forms.Label markComment_lbl;
        private System.Windows.Forms.Label mark_lbl;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.GroupBox sendedHomework_gb;
        private System.Windows.Forms.TableLayoutPanel sendedHomework_tbl;
        private System.Windows.Forms.Label attachments_lbl;
        private System.Windows.Forms.TextBox homework_tb;
        private System.Windows.Forms.Label pupleNote_lbl;
        private System.Windows.Forms.Label homework_lbl;
        private System.Windows.Forms.Label subject_lbl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel createHomeworkLayout_tbl;
        private System.Windows.Forms.GroupBox createHomework_gb;
        private System.Windows.Forms.TableLayoutPanel selectHomework_tbl;
        private System.Windows.Forms.Label homeworkDescr_lbl;
        private System.Windows.Forms.Label homeworkCreate_lbl;
        private System.Windows.Forms.Label subjectCreate_lbl;
        private System.Windows.Forms.TextBox homeworkCreate_tb;
        private System.Windows.Forms.Button publish_btn;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TableLayoutPanel mainContainer_tbl;
        private CustomListBox answerList_lb;
        private System.Windows.Forms.TextBox subject_tb;
        private CustomRichTextBox markComment_rtb;
        private CustomComboBox mark_cb;
        private CustomComboBox subjectCreate_cb;
        private CustomRichTextBox homeworkDescr_rtb;
        private CustomRichTextBox pupleNote_rtb;
        private System.Windows.Forms.Label classCreate_lbl;
        private CustomComboBox classCreate_cb;
    }
}