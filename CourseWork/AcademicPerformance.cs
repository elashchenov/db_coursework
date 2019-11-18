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
    public partial class AcademicPerformance : Form
    {
        Panel parentPanel_;
        public AcademicPerformance(Panel parentPanel)
        {
            parentPanel_ = parentPanel;
            InitializeComponent();
            mainContainer_tbl.AutoScroll = false;
            mainContainer_tbl.MinimumSize = new Size(0, mainContainer_tbl.GetRowHeights().Sum());
        }

        public TableLayoutPanel getContainer()
        {
            return mainContainer_tbl;
        }
    }
}
