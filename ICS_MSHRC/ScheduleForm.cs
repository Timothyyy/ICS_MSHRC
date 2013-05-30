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
    public partial class ScheduleForm : Form
    {
        private DataGridView Table;
        private int Id;
        public ScheduleForm(string type, DataGridView table)
        {
            InitializeComponent();
            this.Text = type;
            confirm.Text = type;
            Table = table;
            foreach (DataRow row in DBProvider.Subjects().Rows)
                Subject.Items.Add(row[1].ToString());
            foreach (DataRow row in DBProvider.GroupCodes().Rows)
                Group.Items.Add(row[0].ToString());
            foreach (DataRow row in DBProvider.Curators().Rows)
                Instructor.Items.Add(row[0].ToString());
        }

        public ScheduleForm(string type, DataGridView table, DBProvider.Schedule schedule, int id)
        {
            InitializeComponent();
            this.Text = type;
            confirm.Text = type;
            Table = table;
            Id = id;
            Subject.Text = schedule.Subject;
            Group.Text = schedule.Group;
            Instructor.Text = schedule.Instructor;
            Day.Text = schedule.Day;
            Pair.Text = schedule.Pair.ToString();
            panel.Controls.OfType<RadioButton>().First(r => r.Text == schedule.Week).Checked = true;
            foreach (DataRow row in DBProvider.Subjects().Rows)
                Subject.Items.Add(row[1].ToString());
            foreach (DataRow row in DBProvider.GroupCodes().Rows)
                Group.Items.Add(row[0].ToString());
            foreach (DataRow row in DBProvider.Curators().Rows)
                Instructor.Items.Add(row[0].ToString());
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (Controls.OfType<ComboBox>().Count(c => c.Text == "") != 0)
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка");
                return;
            }
            var schedule = new DBProvider.Schedule(Subject.Text, Group.Text, Instructor.Text, Day.Text, Convert.ToInt32(Pair.Text),
                panel.Controls.OfType<RadioButton>().First(r => r.Checked).Text);
            if (this.Text == "Добавить")
                DBProvider.AddSchedule(schedule);
            else
                DBProvider.UpdateSchedule(schedule, Id);
            Table.DataSource = DBProvider.Schedules();
            this.Close();
        }

        private void Subject_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
