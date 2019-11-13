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
    public partial class Shedule : Form
    {
        public Shedule()
        {
            InitializeComponent();

            //shedule_table.GetControlFromPosition(1, 1);
            //shedule_table.Controls.Add();
            //List<ReadOnlyTextBox> sheduleArray = new List<ReadOnlyTextBox>();
            
            for (int dayIdx = 1; dayIdx <= 6; dayIdx++)
            {
                for (int lessIdx = 1; lessIdx <= 7; lessIdx++)
                {
                    ReadOnlyTextBox newTextBox = new ReadOnlyTextBox();
                    //newTextBox.Margin = new Padding(1, 1, 0, 0);
                    newTextBox.Font = new Font("Comic Sans MS", 10);
                    newTextBox.Dock = DockStyle.Fill;
                    newTextBox.Multiline = true;
                    newTextBox.BorderStyle = BorderStyle.None;
                    newTextBox.WordWrap = false;
                    List<String> lines = new List<String>();
                    lines.Add("Предмет");
                    lines.Add("Преподаватель");
                    lines.Add("Кабинет");
                    newTextBox.Lines = lines.ToArray();
                    Control controlForDelete = shedule_table.GetControlFromPosition(lessIdx, dayIdx);
                    shedule_table.Controls.Remove(controlForDelete);
                    shedule_table.Controls.Add(newTextBox, lessIdx, dayIdx);
                    //sheduleArray.Add(newTextBox, 1, 2);
                }
            }

        }

        private void lesson1_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
