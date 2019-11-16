using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

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
            OleDbConnection connection = new OleDbConnection("Provider=SQLNCLI11; Data Source=localhost;Persist Security Info=True;User ID=sa;Password=sa;Initial Catalog=school");

            OleDbDataAdapter adapter = new OleDbDataAdapter();

            try
            {
                connection.Open();

            }
            catch (Exception)
            {
                MessageBox.Show("Coonected failed!");
            }

            for (int dayIdx = 1; dayIdx <= 6; dayIdx++)
            {
                for (int lessIdx = 1; lessIdx <= 7; lessIdx++)
                {
                    ReadOnlyTextBox newTextBox = new ReadOnlyTextBox();
                    newTextBox.Font = new Font("Comic Sans MS", 10);
                    newTextBox.Dock = DockStyle.Fill;
                    newTextBox.Multiline = true;
                    newTextBox.BorderStyle = BorderStyle.None;
                    newTextBox.WordWrap = false;
                    List<String> lines = new List<String>();
                    DataTable table = new DataTable();
                    String day = "";

                    switch (dayIdx)
                    {
                        case 1:
                            day = "mon";
                            break;
                        case 2:
                            day = "tue";
                            break;
                        case 3:
                            day = "wen";
                            break;
                        case 4:
                            day = "thur";
                            break;
                        case 5:
                            day = "fri";
                            break;
                        case 6:
                            day = "sat";
                            break;
                    }

                    OleDbCommand command = new OleDbCommand("select subjects.name from puples, shedules, subjects where puples.classId = shedules.classId and shedules.subjectId = subjects.id and shedules.day = '" + day + "' and puples.id = 5 and shedules.subjectNumber = '" + lessIdx + "'", connection);
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        string name = row["name"].ToString();
                        newTextBox.Text = name;

                    }

                    Control controlForDelete = shedule_table.GetControlFromPosition(lessIdx, dayIdx);
                    shedule_table.Controls.Remove(controlForDelete);
                    shedule_table.Controls.Add(newTextBox, lessIdx, dayIdx);

                }
            }
            connection.Close();

        }
        public TableLayoutPanel getContainer()
        {
            return mainLayout_tbl;
        }
    }
}
