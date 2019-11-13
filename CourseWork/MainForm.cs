using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        private SignInForm parentForm;
        private Form currForm;
        private LinkLabel currLinkLabel = null;
        private Profile profile;
        private Shedule calendar;
        private Size panel2Size;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(SignInForm f)
        {
            InitializeComponent();
            //user_split.Panel2.BackColor = Color.FromArgb(0, Color.Black);
            //user_split.BackColor = Color.FromArgb(0, Color.Black);

            panel2Size = new Size(
                user_split.Panel2.Size.Width,
                user_split.Panel2.Size.Height
                );
            menu_btn.BackColor = SystemColors.Control;
            profile = new Profile();
            calendar = new Shedule();

            parentForm = f;
            f.Hide();
        }

        private void loadIntoPanel2(Form form)
        {
            user_split.Panel2.Size = panel2Size;
            menu_btn.BackColor = SystemColors.ActiveCaption;
            user_split.Panel2.Controls.Remove(currForm);
            currForm = form;
            form.TopLevel = false;
            user_split.Panel2.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Width = user_split.Panel2.Width;
            form.Height = user_split.Panel2.Height;
            user_split.Panel2.AutoScrollMinSize = new Size(form.Width - 20, form.Height);
            form.Dock = System.Windows.Forms.DockStyle.Fill;
            form.Show();
        }

        private void menu_btn_MouseHover(object sender, EventArgs e)
        {
            Image myImage = CourseWork.Properties.Resources.Hamburger_icon_hover;
            menu_btn.Image = myImage;
        }

        private void menu_btn_MouseLeave(object sender, EventArgs e)
        {
            Image myImage = CourseWork.Properties.Resources.Hamburger_icon;
            menu_btn.Image = myImage;
        }

        private void menu_btn_MouseDown(object sender, MouseEventArgs e)
        {
            Image myImage = CourseWork.Properties.Resources.Hamburger_icon_pressed;
            menu_btn.Image = myImage;
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            user_split.Panel1Collapsed = !user_split.Panel1Collapsed;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //    if (MessageBox.Show(" Хотите выйти?", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        parentForm.Close();
            //        Application.Exit();
            //    } else {
            //        e.Cancel = true;
            //    }
            Application.Exit();

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (currForm != null)
            {
                currForm.Width = user_split.Panel2.Width;
                currForm.Height = user_split.Panel2.Height;
            }

            //int margin = (user_split.Panel1.Width - actionsMenu_table.Width) / 2;
            //actionsMenu_table.Margin = new Padding(margin, 0, 0, 0);

            //foreach (Control control in this.actionsMenu_table.Controls)
            //{
            //    int margin = (actionsMenu_table.Width - 130) / 2; 
            //    control.Margin = new Padding(margin, 0, 0, 0);
            //}

        }

        private void profile_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (currLinkLabel != profile_lbl)
            {
                loadIntoPanel2(profile);
                currLinkLabel = profile_lbl;
            }
        }

        private void shedule_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (currLinkLabel != shedule_lbl)
            {
                loadIntoPanel2(calendar);
                currLinkLabel = shedule_lbl;
            }
        }
    }
}
