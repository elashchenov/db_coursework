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
using CourseWork.DBClasses;

namespace CourseWork
{
    public partial class Shedule : Form
    {
        private Panel parentLayout;
        private Dictionary<int, string> days = new Dictionary<int, string>
        {
            {1,  "понедельник"},
            {2,  "вторник"},
            {3,  "среда"},
            {4,  "четверг"},
            {5, "пятница"},
            {6,  "суббота"}
        };

        private int getWidth(string text)
        {
            return TextRenderer.MeasureText(text, new Font("Comic Sans MS", 10)).Width;
        }

        public Shedule(Panel parentLayout, UserDB user)
        {
            this.parentLayout = parentLayout;
            InitializeComponent();

            if (user.user_type != 2) {
                puple_cb.Hide();
                puple_lbl.Hide();
                fillShedule(user);
            } else {
                puple_cb.Items.AddRange(((ParentDB)user).puples.ToArray());
            }
        }
        public TableLayoutPanel getContainer()
        {
            return mainLayout_tbl;
        }

        public void fillShedule(UserDB user)
        {
            List<SheduleDB> shedules = new List<SheduleDB>();

            switch (user.user_type) {
                case 0:
                    shedules = SheduleDB.loadSheduleByTeacher((TeacherDB)user);
                    break;
                case 1:
                    shedules = SheduleDB.loadSheduleByClass(((PupleDB)user).classDB);
                    break;
            }
            for (int lessIdx = 1; lessIdx <= 7; lessIdx++) {
                List<SheduleDB> sheduleByLesson = shedules.FindAll(p => p.subjectOrdinal == lessIdx);
                int maxWidth = 109;
                for (int dayIdx = 1; dayIdx <= 6; dayIdx++) {
                    SheduleDB shedule = sheduleByLesson.Find(p => p.day.Contains(days[dayIdx]));
                    if (shedule == null)
                        continue;
                    ReadOnlyTextBox newTextBox = new ReadOnlyTextBox();
                    newTextBox.Font = new Font("Comic Sans MS", 10);
                    newTextBox.Dock = DockStyle.Fill;
                    newTextBox.TextAlign = HorizontalAlignment.Center;
                    newTextBox.Multiline = true;
                    newTextBox.BorderStyle = BorderStyle.None;
                    newTextBox.WordWrap = false;
                    List<String> lines = new List<String>();
                    switch (user.user_type) {
                        case 0:
                            maxWidth = getWidth(shedule.subject.name) > maxWidth ? getWidth(shedule.subject.name) : maxWidth;
                            maxWidth = getWidth(shedule.classDB.ToString()) > maxWidth ? getWidth(shedule.classDB.ToString()) : maxWidth;
                            newTextBox.Text = shedule.subject.name + Environment.NewLine + shedule.classDB.ToString();
                            break;
                        case 1:
                            maxWidth = getWidth(shedule.subject.name) > maxWidth ? getWidth(shedule.subject.name) : maxWidth;
                            maxWidth = getWidth(shedule.teacher.fio) > maxWidth ? getWidth(shedule.teacher.fio) : maxWidth;
                            newTextBox.Text = shedule.subject.name + Environment.NewLine + shedule.teacher.fio;
                            break;
                    }

                    Control controlForDelete = shedule_table.GetControlFromPosition(lessIdx, dayIdx);
                    shedule_table.Controls.Remove(controlForDelete);
                    shedule_table.Controls.Add(newTextBox, lessIdx, dayIdx);
                }
                shedule_table.ColumnStyles[lessIdx].Width = maxWidth;
            }

            int sum = 0;
            foreach (ColumnStyle column in shedule_table.ColumnStyles) {
                sum += (int)column.Width;
            }
            mainLayout_tbl.MinimumSize = new Size(sum, 0);
            parentLayout.AutoScrollMinSize = new Size(sum, parentLayout.Height);
        }

        private void puple_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            fillShedule((PupleDB)puple_cb.SelectedItem);
        }
    }
}
