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
                return;
            }
            if (e.Node.Name == "Subjects")
            {
                tableView.DataSource = DBProvider.Subjects();
                return;
            }
            if (e.Node.Name == "Views")
                return;
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
            if (e.Node.Parent.Name == "Instructors")
                tableView.DataSource = DBProvider.Instructors(e.Node.Index + 1);
        }

        private void addStudentMenu_Click(object sender, EventArgs e)
        {
            (new StudentForm("Добавить", tableView)).Show();
        }

        private void tableView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && tableView.ColumnCount == 14)
            {
                var student = new DBProvider.Student(tableView.Rows[e.RowIndex].Cells);
                (new StudentForm("Редактировать", tableView, student, Convert.ToInt32(tableView.Rows[e.RowIndex].Cells[0].Value))).Show();
            }
        }
    }
}