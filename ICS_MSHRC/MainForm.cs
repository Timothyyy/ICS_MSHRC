using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ICS_MSHRC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "Students")
            {
                tableView.DataSource = DBProvider.Students();
                tableView.Columns[0].Visible = false;
                return;
            }
            if (e.Node.Name == "Instructors")
            {
                tableView.DataSource = DBProvider.Instructors();
                tableView.Columns[0].Visible = false;
                return;
            }
            if (e.Node.Name == "Groups")
            {
                tableView.DataSource = DBProvider.Groups();
                tableView.Columns[0].Visible = false;
                return;
            }
            if (e.Node.Name == "Subjects")
            {
                tableView.DataSource = DBProvider.Subjects();
                return;
            }
            if (e.Node.Parent.Name == "Students")
            {
                tableView.DataSource = DBProvider.Students(e.Node.Text);
                tableView.Columns[0].Visible = false;
                return;
            }
            if (e.Node.Parent.Name == "Radio")
            {
                tableView.DataSource = DBProvider.Students(e.Node.Index + 1);
                tableView.Columns[0].Visible = false;
                return;
            }
            if (e.Node.Parent.Name == "Electr")
            {
                tableView.DataSource = DBProvider.Students(e.Node.Index + 3);
                tableView.Columns[0].Visible = false;
                return;
            }
            if (e.Node.Parent.Name == "Instructors")
            {
                tableView.DataSource = DBProvider.Instructors(e.Node.Index + 1);
                tableView.Columns[0].Visible = false;
                return;
            }
            if (e.Node.Parent.Name == "Groups")
            {
                tableView.DataSource = DBProvider.Groups(e.Node.Text);
                tableView.Columns[0].Visible = false;
                return;
            }
            if (e.Node.Parent.Name == "RadioGr")
            {
                tableView.DataSource = DBProvider.Groups(e.Node.Index + 1);
                tableView.Columns[0].Visible = false;
                return;
            }
            if (e.Node.Parent.Name == "ElectrGr")
            {
                tableView.DataSource = DBProvider.Groups(e.Node.Index + 3);
                tableView.Columns[0].Visible = false;
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
        }
    }
}