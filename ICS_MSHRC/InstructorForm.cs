using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ICS_MSHRC
{
    public partial class InstructorForm : Form
    {
        private DataGridView Table;
        private int Id;
        public InstructorForm(string type, DataGridView table)
        {
            InitializeComponent();
            this.Text = type;
            confirm.Text = type;
            Table = table;
            foreach (DataRow row in DBProvider.Departments().Rows)
                Department.Items.Add(row[0].ToString());
        }

        public InstructorForm(string type, DataGridView table, DBProvider.Instuctor instructor, int id)
        {
            InitializeComponent();
            this.Text = type;
            confirm.Text = type;
            Table = table;
            Id = id;
            FullName.Text = instructor.FullName;
            Sex.Text = instructor.Sex;
            Address.Text = instructor.Address;
            Phone.Text = instructor.Phone;
            Email.Text = instructor.Email;
            Education.Text = instructor.Education;
            Department.Text = instructor.Department;
            Post.Text = instructor.Post;
            Start.Text = instructor.Start;
            Other.Text = instructor.Other;
            Id = id;
            foreach (DataRow row in DBProvider.Departments().Rows)
                Department.Items.Add(row[0].ToString());
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < this.Controls.Count; i++)
                if (this.Controls[i].Text == "")
                {
                    //MessageBox.Show("Все поля должны быть заполнены!", "Ошибка");
                    //return;
                }
            var instructor = new DBProvider.Instuctor(FullName.Text, Sex.Text, Address.Text, Phone.Text, Email.Text,
                                                 Education.Text, Department.Text, Post.Text, Start.Text, Other.Text);
            if (this.Text == "Добавить")
                DBProvider.AddInstructor(instructor);
            else
                DBProvider.UpdateInstructor(instructor, Id);
            Table.DataSource = DBProvider.Instructors();
            this.Close();
        }

        private void Sex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
