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
    public partial class StudentForm : Form
    {
        private DataGridView Table;
        private static int Id;
        public StudentForm(string type, DataGridView table)
        {
            InitializeComponent();
            this.Text = type;
            confirm.Text = type;
            Table = table;
            foreach (DataRow row in DBProvider.GroupCodes().Rows)
                Group.Items.Add(row[0].ToString());
        }

        public StudentForm(string type, DataGridView table, DBProvider.Student student, int id)
        {
            InitializeComponent();
            this.Text = type;
            confirm.Text = type;
            Table = table;
            FullName.Text = student.FullName; 
            Sex.Text = student.Sex;
            Address.Text = student.Address; 
            Phone.Text = student.Phone; 
            Email.Text = student.Email;
            Birth.Text = student.Birth; 
            Education.Text = student.Education; 
            Medical.Text = student.Medical;
            Nationality.Text = student.Nationality; 
            Hobby.Text = student.Hobby; 
            Dormitory.Checked = student.Dormitory; 
            Group.Text = student.Group;
            Other.Text = student.Other;
            Id = id;
            foreach (DataRow row in DBProvider.GroupCodes().Rows)
            {
                Group.Items.Add(row[0].ToString());
                Group.AutoCompleteCustomSource.Add(row[0].ToString());
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < this.Controls.Count; i++)
                if (this.Controls[i].Text == "")
                {
                    MessageBox.Show("Все поля должны быть заполнены!", "Ошибка");
                    return;
                }
            var student = new DBProvider.Student(FullName.Text, Sex.Text, Address.Text, Phone.Text, Email.Text,
                                                 Birth.Text, Education.Text, Medical.Text,
                                                 Nationality.Text, Hobby.Text, Dormitory.Checked, Group.Text,
                                                 Other.Text);
            if (this.Text == "Добавить")
                DBProvider.AddStudent(student);
            else
                DBProvider.UpdateStudent(student, Id);
            Table.DataSource = DBProvider.Students();
            this.Close();
        }

        private void Sex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
