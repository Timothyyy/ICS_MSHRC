using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ICS_MSHRC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Settings(string type)
        {
            tableView.Columns[0].Visible = false;
            foreach (ToolStripMenuItem item in menu.Items)
                item.Enabled = item.Text == type;
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "Students")
            {
                tableView.DataSource = DBProvider.Students();
                Settings("Студенты");
                return;
            }
            if (e.Node.Name == "Instructors")
            {
                tableView.DataSource = DBProvider.Instructors();
                Settings("Преподаватели");
                return;
            }
            if (e.Node.Name == "Groups")
            {
                tableView.DataSource = DBProvider.Groups();
                Settings("Группы");
                return;
            }
            if (e.Node.Name == "Subjects")
            {
                tableView.DataSource = DBProvider.Subjects();
                Settings("Предметы");
                return;
            }
            if (e.Node.Name == "Schedule")
            {
                tableView.DataSource = DBProvider.Schedules();
<<<<<<< HEAD
                Settings("Расписание");
=======
>>>>>>> f48a9a0fc14bdb6b0d4965b6f6d81138745e6a09
                return;
            }
            if (e.Node.Parent.Name == "Students")
            {
                tableView.DataSource = DBProvider.Students(e.Node.Text);
                Settings("Студенты");
                return;
            }
            if (e.Node.Parent.Name == "Radio")
            {
                tableView.DataSource = DBProvider.Students(e.Node.Index + 1);
                Settings("Студенты");
                return;
            }
            if (e.Node.Parent.Name == "Electr")
            {
                tableView.DataSource = DBProvider.Students(e.Node.Index + 3);
                Settings("Студенты");
                return;
            }
            if (e.Node.Parent.Name == "Faculty")
            {
                tableView.DataSource = DBProvider.Students(e.Node.Index + 7);
                Settings("Студенты");
                return;
            }
            if (e.Node.Parent.Name == "Instructors")
            {
                tableView.DataSource = DBProvider.Instructors(e.Node.Index + 1);
                Settings("Преподаватели");
                return;
            }
            if (e.Node.Parent.Name == "Groups")
            {
                tableView.DataSource = DBProvider.Groups(e.Node.Text);
                Settings("Группы");
                return;
            }
            if (e.Node.Parent.Name == "RadioGr")
            {
                tableView.DataSource = DBProvider.Groups(e.Node.Index + 1);
                Settings("Группы");
                return;
            }
            if (e.Node.Parent.Name == "ElectrGr")
            {
                tableView.DataSource = DBProvider.Groups(e.Node.Index + 3);
                Settings("Группы");
                return;
            }
            if (e.Node.Parent.Name == "FacultyGr")
            {
                tableView.DataSource = DBProvider.Groups(e.Node.Index + 7);
                Settings("Группы");
            }
        }

        private void addStudentMenu_Click(object sender, EventArgs e)
        {
            (new StudentForm("Добавить", tableView)).Show();
        }

        private void addInstructorMenu_Click(object sender, EventArgs e)
        {
            (new InstructorForm("Добавить", tableView)).Show();
        }

        private void addGroupMenu_Click(object sender, EventArgs e)
        {
            (new GroupForm("Добавить", tableView)).Show();
        }

        private void addSubjectMenu_Click(object sender, EventArgs e)
        {
            var subject = Interaction.InputBox("Название:", "Добавить", " ");
            if (subject == "")
                return;
            DBProvider.AddSubject(subject);
            tableView.DataSource = DBProvider.Subjects();
        }

        private void addScheduleMenu_Click(object sender, EventArgs e)
        {
            (new ScheduleForm("Добавить", tableView)).Show();
        }

        private void tableView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && tableView.ColumnCount == 14)
            {
                var student = new DBProvider.Student(tableView.Rows[e.RowIndex].Cells);
                (new StudentForm("Редактировать", tableView, student, Convert.ToInt32(tableView.Rows[e.RowIndex].Cells[0].Value))).Show();
                return;
            }
            if (e.RowIndex >= 0 && tableView.ColumnCount == 11)
            {
                var instructor = new DBProvider.Instructor(tableView.Rows[e.RowIndex].Cells);
                (new InstructorForm("Редактировать", tableView, instructor, Convert.ToInt32(tableView.Rows[e.RowIndex].Cells[0].Value))).Show();
                return;
            }
            if (e.RowIndex >= 0 && tableView.ColumnCount == 5)
            {
                var group = new DBProvider.Group(tableView.Rows[e.RowIndex].Cells);
                (new GroupForm("Редактировать", tableView, group, Convert.ToInt32(tableView.Rows[e.RowIndex].Cells[0].Value))).Show();
                return;
            }
            if (e.RowIndex >= 0 && tableView.ColumnCount == 2)
            {
                var subject = Interaction.InputBox("Название:", "Добавить", tableView.Rows[e.RowIndex].Cells[1].Value.ToString());
                if (subject == tableView.Rows[e.RowIndex].Cells[1].Value.ToString() || subject == "")
                    return;
                DBProvider.UpdateSubject(subject, Convert.ToInt32(tableView.Rows[e.RowIndex].Cells[0].Value));
                tableView.DataSource = DBProvider.Subjects();
                return;
            }
            if (e.RowIndex >= 0 && tableView.ColumnCount == 7)
            {
                var schedule = new DBProvider.Schedule(tableView.Rows[e.RowIndex].Cells);
                (new ScheduleForm("Редактировать", tableView, schedule, Convert.ToInt32(tableView.Rows[e.RowIndex].Cells[0].Value))).Show();
            }
            if (e.RowIndex >= 0 && tableView.ColumnCount == 7)
            {
                var schedule = new DBProvider.Schedule(tableView.Rows[e.RowIndex].Cells);
                (new ScheduleForm("Редактировать", tableView, schedule, Convert.ToInt32(tableView.Rows[e.RowIndex].Cells[0].Value))).Show();
            }
        }

        private void todayScheduleMenu_Click(object sender, EventArgs e)
        {
            //var item = sender as ToolStripMenuItem;
            (new TodaySchedule()).Show();
        }
    }
}