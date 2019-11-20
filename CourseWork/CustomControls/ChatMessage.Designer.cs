namespace CourseWork.CustomControls
{
    partial class ChatMessage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_rtb = new CourseWork.CustomRichTextBox();
            this.time_lbl = new System.Windows.Forms.Label();
            this.message_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.message_tbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_rtb
            // 
            this.text_rtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(121)))));
            this.text_rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_rtb.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_rtb.ForeColor = System.Drawing.Color.White;
            this.text_rtb.Location = new System.Drawing.Point(5, 10);
            this.text_rtb.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.text_rtb.Name = "text_rtb";
            this.text_rtb.ReadOnly = true;
            this.text_rtb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.text_rtb.Size = new System.Drawing.Size(390, 96);
            this.text_rtb.TabIndex = 2;
            this.text_rtb.Text = "";
            this.text_rtb.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.text_rtb_ContentsResized);
            this.text_rtb.TextChanged += new System.EventHandler(this.text_rtb_TextChanged);
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.BackColor = System.Drawing.Color.Transparent;
            this.time_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time_lbl.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_lbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.time_lbl.Location = new System.Drawing.Point(0, 106);
            this.time_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 5, 10);
            this.time_lbl.Size = new System.Drawing.Size(400, 30);
            this.time_lbl.TabIndex = 1;
            this.time_lbl.Text = "18:12";
            this.time_lbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // message_tbl
            // 
            this.message_tbl.AutoSize = true;
            this.message_tbl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.message_tbl.BackColor = System.Drawing.Color.Transparent;
            this.message_tbl.ColumnCount = 1;
            this.message_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.message_tbl.Controls.Add(this.time_lbl, 0, 1);
            this.message_tbl.Controls.Add(this.text_rtb, 0, 0);
            this.message_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.message_tbl.Location = new System.Drawing.Point(0, 0);
            this.message_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.message_tbl.MaximumSize = new System.Drawing.Size(400, 0);
            this.message_tbl.Name = "message_tbl";
            this.message_tbl.RowCount = 2;
            this.message_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.message_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.message_tbl.Size = new System.Drawing.Size(400, 136);
            this.message_tbl.TabIndex = 0;
            // 
            // ChatMessage
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.message_tbl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ChatMessage";
            this.Size = new System.Drawing.Size(400, 136);
            this.Load += new System.EventHandler(this.ChatMessage_Load);
            this.message_tbl.ResumeLayout(false);
            this.message_tbl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomRichTextBox text_rtb;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.TableLayoutPanel message_tbl;
    }
}
