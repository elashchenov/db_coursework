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
        private Panel currForm;
        private LinkLabel currLinkLabel = null;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(SignInForm f)
        {
            InitializeComponent();
            //wrapper.BackColor = Color.FromArgb(0, Color.Black);
            //user_split.BackColor = Color.FromArgb(0, Color.Black);

            //panel2Size = new Size(
            //    wrapper.Size.Width,
            //    wrapper.Size.Height
            //    );

            parentForm = f;
            f.Hide();
        }

        private void loadIntoPanel2(Panel form)
        {
            //form.TopLevel = false;
            //form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //form.Dock = System.Windows.Forms.DockStyle.Fill;
            wrapper.Controls.Remove(currForm);
            wrapper.AutoScrollMinSize = new Size(form.Width, form.Height);
            wrapper.Controls.Add(form);
            form.Width = wrapper.Width;
            form.Height = wrapper.Height;
            //MessageBox.Show("Panel2 size is " + wrapper.Size + "; Form size is " + form.Size);
            form.Show();
            currForm = form;
            menu_btn.BackColor = SystemColors.ActiveCaption;
            //MessageBox.Show("Panel2 size is " + wrapper.Size + "; Form size is " + form.Size);
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
        

        private void profile_lbl_LinkClicked(object sender, EventArgs e)
        {
            if (currLinkLabel != profile_lbl)
            {
                loadIntoPanel2(new Profile(wrapper).getContainer());
                currLinkLabel = profile_lbl;
            }
        }

        private void shedule_lbl_LinkClicked(object sender, EventArgs e)
        {
            if (currLinkLabel != shedule_lbl)
            {
                loadIntoPanel2(new Shedule().getContainer());
                currLinkLabel = shedule_lbl;
            }
        }

        private void homework_lbl_LinkClicked(object sender, EventArgs e)
        {
            if (currLinkLabel != homework_lbl)
            {
                //loadIntoPanel2(new HomeworkPuple(wrapper).getContainer());
                //currLinkLabel = homework_lbl;                
                loadIntoPanel2(new HomeworkTeacher(wrapper).getContainer());
                currLinkLabel = homework_lbl;
                menu_btn.Focus();
            }
        }

        private void mouseEnterAction(LinkLabel label)
        {
            label.BackColor = SystemColors.GradientActiveCaption;
            label.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
        }

        private void mouseLeaveAction(LinkLabel label)
        {
            label.BackColor = SystemColors.ControlLight;
            label.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
        }

        private void profile_lbl_MouseEnter(object sender, EventArgs e)
        {
            mouseEnterAction(profile_lbl);
        }

        private void profile_lbl_MouseLeave(object sender, EventArgs e)
        {
            mouseLeaveAction(profile_lbl);
        }

        private void shedule_lbl_MouseEnter(object sender, EventArgs e)
        {
            mouseEnterAction(shedule_lbl);
        }

        private void shedule_lbl_MouseLeave(object sender, EventArgs e)
        {
            mouseLeaveAction(shedule_lbl);
        }

        private void homework_lbl_MouseEnter(object sender, EventArgs e)
        {
            mouseEnterAction(homework_lbl);
        }

        private void homework_lbl_MouseLeave(object sender, EventArgs e)
        {
            mouseLeaveAction(homework_lbl);
        }

        private void acadPerform_lbl_MouseEnter(object sender, EventArgs e)
        {
            mouseEnterAction(acadPerform_lbl);
        }

        private void acadPerform_lbl_MouseLeave(object sender, EventArgs e)
        {
            mouseLeaveAction(acadPerform_lbl);
        }

        private void exit_lbl_MouseEnter(object sender, EventArgs e)
        {
            mouseEnterAction(exit_lbl);
        }

        private void exit_lbl_MouseLeave(object sender, EventArgs e)
        {
            mouseLeaveAction(exit_lbl);
        }

        private void MainForm_ResizeBegin(object sender, EventArgs e)
        {
            currForm.SuspendLayout();
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            currForm.ResumeLayout();
        }
    }
}
