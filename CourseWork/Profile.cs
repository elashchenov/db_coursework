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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            int[] years = new int[101];
            for(int i = 2019; i > 1918; i--)
            {
                birthYear_cb.Items.Add(i);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void wrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Profile_Resize(object sender, EventArgs e)
        {
            int margin = (this.Width - personalInfo_gb.Width) / 2;
            personalInfo_gb.Margin = new Padding(margin, 30, margin, 3);

            int margin_psw = (this.Width - password_gb.Width) / 2;
            password_gb.Margin = new Padding(margin_psw, 0, margin_psw, 3);
        }
    }
}
