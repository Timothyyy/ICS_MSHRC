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
    public partial class GroupForm : Form
    {
        private DataGridView Table;
        private int Id;
        public GroupForm(string type, DataGridView table)
        {
            InitializeComponent();
            this.Text = type;
            confirm.Text = type;
            Table = table;
            foreach (DataRow row in DBProvider.Specialties().Rows)
                Specialty.Items.Add(row[0].ToString());
            foreach (DataRow row in DBProvider.Curators().Rows)
                Curator.Items.Add(row[0].ToString());
        }

        public GroupForm(string type, DataGridView table, DBProvider.Group group, int id)
        {
            InitializeComponent();
            this.Text = type;
            confirm.Text = type;
            Table = table;
            Id = id;
            Code.Text = group.Code;
            Specialty.Text = group.Specialty;
            StudyForm.Text = group.StudyForm;
            Curator.Text = group.Curator;
            foreach (DataRow row in DBProvider.Specialties().Rows)
                Specialty.Items.Add(row[0].ToString());
            foreach (DataRow row in DBProvider.Curators().Rows)
                Curator.Items.Add(row[0].ToString());
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (Controls.OfType<ComboBox>().Count(c => c.Text == "") != 0 || Controls.OfType<TextBox>().Count(t => t.Text == "") != 0)
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка");
                return;
            }
            var group = new DBProvider.Group(Code.Text, Specialty.Text, StudyForm.Text, Curator.Text);
            if (this.Text == "Добавить")
                DBProvider.AddGroup(group);
            else
                DBProvider.UpdateGroup(group, Id);
            Table.DataSource = DBProvider.Groups();
            this.Close();
        }

        private void Specialty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
