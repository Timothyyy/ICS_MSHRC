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
            /*var str = DateTime.Now.ToString("dddd");
            MessageBox.Show(str.Replace(str[0].ToString(), str[0].ToString().ToUpper()));*/
            tableView.DataSource = DBProvider.Students();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tableView.Columns[0].Visible = false;
            if (e.Node.Name == "Students")
            {
                tableView.DataSource = DBProvider.Students();
                return;
            }
            if (e.Node.Name == "Instructors")
            {
                tableView.DataSource = DBProvider.Instructors();
                return;
            }
            if (e.Node.Name == "Groups")
            {
                tableView.DataSource = DBProvider.Groups();
                return;
            }
            if (e.Node.Name == "Subjects")
            {
                tableView.DataSource = DBProvider.Subjects();
                return;
            }
            if (e.Node.Name == "Schedule")
            {
                tableView.DataSource = DBProvider.Schedule();
                return;
            }
            if (e.Node.Parent.Name == "Students")
            {
                tableView.DataSource = DBProvider.Students(e.Node.Text);
                return;
            }
            if (e.Node.Parent.Name == "Radio")
            {
                tableView.DataSource = DBProvider.Students(e.Node.Index + 1);
                return;
            }
            if (e.Node.Parent.Name == "Electr")
            {
                tableView.DataSource = DBProvider.Students(e.Node.Index + 3);
                return;
            }
            if (e.Node.Parent.Name == "Faculty")
            {
                tableView.DataSource = DBProvider.Students(e.Node.Index + 7);
                return;
            }
            if (e.Node.Parent.Name == "Instructors")
            {
                tableView.DataSource = DBProvider.Instructors(e.Node.Index + 1);
                return;
            }
            if (e.Node.Parent.Name == "Groups")
            {
                tableView.DataSource = DBProvider.Groups(e.Node.Text);
                return;
            }
            if (e.Node.Parent.Name == "RadioGr")
            {
                tableView.DataSource = DBProvider.Groups(e.Node.Index + 1);
                return;
            }
            if (e.Node.Parent.Name == "ElectrGr")
            {
                tableView.DataSource = DBProvider.Groups(e.Node.Index + 3);
                return;
            }
            if (e.Node.Parent.Name == "FacultyGr")
            {
                tableView.DataSource = DBProvider.Groups(e.Node.Index + 7);
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

        private void tableView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && tableView.ColumnCount == 14)
            {
                var student = new DBProvider.Student(tableView.Rows[e.RowIndex].Cells);
                (new StudentForm("Редактировать", tableView, student, Convert.ToInt32(tableView.Rows[e.RowIndex].Cells[0].Value))).Show();
            }
            if (e.RowIndex >= 0 && tableView.ColumnCount == 11)
            {
                var instructor = new DBProvider.Instuctor(tableView.Rows[e.RowIndex].Cells);
                (new InstructorForm("Редактировать", tableView, instructor, Convert.ToInt32(tableView.Rows[e.RowIndex].Cells[0].Value))).Show();
            }
            if (e.RowIndex >= 0 && tableView.ColumnCount == 5)
            {
                var group = new DBProvider.Group(tableView.Rows[e.RowIndex].Cells);
                (new GroupForm("Редактировать", tableView, group, Convert.ToInt32(tableView.Rows[e.RowIndex].Cells[0].Value))).Show();
            }
            if (e.RowIndex >= 0 && tableView.ColumnCount == 2)
            {
                var subject = Interaction.InputBox("Название:", "Добавить", tableView.Rows[e.RowIndex].Cells[1].Value.ToString());
                if (subject == tableView.Rows[e.RowIndex].Cells[1].Value.ToString() || subject == "")
                    return;
                DBProvider.UpdateSubject(subject, Convert.ToInt32(tableView.Rows[e.RowIndex].Cells[0].Value));
                tableView.DataSource = DBProvider.Subjects();
            }
        }
    }
}