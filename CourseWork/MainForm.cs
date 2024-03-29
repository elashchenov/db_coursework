﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.DBClasses;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        private SignInForm parentForm;
        private Panel currForm;
        private LinkLabel currLinkLabel = null;
        private UserDB user;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(SignInForm f, UserDB user)
        {
            this.user = user;
            InitializeComponent();
            switch (this.user.user_type) {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    homework_lbl.Hide();
                    break;
            }

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
            Image myImage = Properties.Resources.Hamburger_icon_hover;
            menu_btn.Image = myImage;
        }

        private void menu_btn_MouseLeave(object sender, EventArgs e)
        {
            Image myImage = Properties.Resources.Hamburger_icon;
            menu_btn.Image = myImage;
        }

        private void menu_btn_MouseDown(object sender, MouseEventArgs e)
        {
            Image myImage = Properties.Resources.Hamburger_icon_pressed;
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
            if (currLinkLabel != profile_lbl) {
                loadIntoPanel2(new Profile(wrapper, user).getContainer());
                currLinkLabel = profile_lbl;
            }
        }

        private void shedule_lbl_LinkClicked(object sender, EventArgs e)
        {
            if (currLinkLabel != shedule_lbl) {
                loadIntoPanel2(new Shedule(wrapper, user).getContainer());
                currLinkLabel = shedule_lbl;
            }
        }

        private void homework_lbl_LinkClicked(object sender, EventArgs e)
        {
            if (currLinkLabel != homework_lbl) {
                if (user.user_type == 1) {
                    loadIntoPanel2(new HomeworkPuple(wrapper, (PupleDB)user).getContainer());
                    currLinkLabel = homework_lbl;
                } else {
                    loadIntoPanel2(new HomeworkTeacher(wrapper, (TeacherDB)user).getContainer());
                    currLinkLabel = homework_lbl;
                }
            }
        }

        private void acadPerform_lbl_LinkClicked(object sender, EventArgs e)
        {

            if (currLinkLabel != acadPerform_lbl) {
                if (user.user_type == 0) {
                    loadIntoPanel2(new GradingTeacher(wrapper, (TeacherDB)user).getContainer());
                    currLinkLabel = acadPerform_lbl;
                } else {
                    loadIntoPanel2(new AcademicPerformance(wrapper, user).getContainer());
                    currLinkLabel = acadPerform_lbl;
                }
            }
        }

        private void messages_lbl_LinkClicked(object sender, EventArgs e)
        {
            if (currLinkLabel != messages_lbl) {
                //wrapper.AutoScroll = false;
                loadIntoPanel2(new Messages(wrapper, menu_btn, user).getContainer());
                currLinkLabel = messages_lbl;
            }
        }

        private void logOut_lbl_LinkClicked(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Dispose();
        }

        private void mainMenuLable_MouseEnter(object sender, EventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;
            linkLabel.BackColor = SystemColors.GradientActiveCaption;
            linkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
        }

        private void mainMenuLable_MouseLeave(object sender, EventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;
            linkLabel.BackColor = SystemColors.ControlLight;
            linkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
        }

        private void MainForm_ResizeBegin(object sender, EventArgs e)
        {
            if (currForm != null)
                currForm.SuspendLayout();
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            if (currForm != null)
                currForm.ResumeLayout();
        }


    }
}
