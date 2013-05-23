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
        public StudentForm(string type, DataGridView table)
        {
            InitializeComponent();
            this.Text = type;
            confirm.Text = type;
            Table = table;
            foreach (DataRow row in DBProvider.Groups().Rows)
            {    
                Group.Items.Add(row[0].ToString());
                Group.AutoCompleteCustomSource.Add(row[0].ToString());
            }
            
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            var student = new DBProvider.Student(FullName.Text, Sex.Text, Address.Text, Phone.Text, Email.Text,
                                                 Birth.Text, Education.Text, Medical.Text,
                                                 Nationalty.Text, Hobby.Text, Dormitory.Checked, Group.Text, Other.Text);
            DBProvider.AddStudent(student);
            Table.DataSource = DBProvider.Students();
            this.Close();
        }

        private void Sex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
