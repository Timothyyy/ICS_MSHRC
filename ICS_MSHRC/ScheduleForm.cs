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
        public ScheduleForm()
        {
            InitializeComponent();
            tabControl.TabPages.Remove(scheduleAdmin);
            foreach (DataRow row in DBProvider.GroupCodes().Rows)
            {
                Group.Items.Add(row[0].ToString());
            }
            foreach (DataRow row in DBProvider.Subjects().Rows)
            {
                Subject.Items.Add(row[1].ToString());
            }
            foreach (DataRow row in DBProvider.Instructors().Rows)
            {
                Instructor.Items.Add(row[1].ToString());
            }
        }

        private enum ForType
        {
            Выберите_группу = 0,
            Выберите_преподавателя = 1,
            Выберите_предмет = 2,
        };

        private enum Choice
        {
            Groups = 0,
            Instructors = 1,
            Subjects = 2,
        };

        private enum Column
        {
            Группа = 0,
            Преподаватель = 1,
            Предмет = 2,
        };

        private void scheduleFor_SelectedIndexChanged(object sender, EventArgs e)
        {
            todayScheduleView.DataSource = null;
            choice.Text = "";
            choice.Items.Clear();
            panel.Visible = true;
            tabControl.TabPages.Remove(scheduleAdmin);
            if (scheduleFor.SelectedIndex == 0)
                tabControl.TabPages.Add(scheduleAdmin);
            label2.Text = Enum.GetName(typeof (ForType), scheduleFor.SelectedIndex).Replace('_', ' ') + ':';
            var view = Enum.GetName(typeof (Choice), scheduleFor.SelectedIndex);
            foreach (DataRow row in DBProvider.Choice(view).Rows)
            {
                choice.Items.Add(row[0].ToString());
            }
        }

        private void choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            var column = Enum.GetName(typeof (Column), scheduleFor.SelectedIndex);
            var week = panel.Controls.OfType<RadioButton>().First(r => r.Checked).Text;
            todayScheduleView.DataSource = DBProvider.TodaySchedule(column, choice.Text, week);
        }

        private void scheduleFor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (choice.Text != "")
                if (((RadioButton) sender).Checked)
                {
                    var column = Enum.GetName(typeof (Column), scheduleFor.SelectedIndex);
                    var week = ((RadioButton) sender).Text;
                    todayScheduleView.DataSource = DBProvider.TodaySchedule(column, choice.Text, week);
                }
        }

        private void Group_SelectedIndexChanged(object sender, EventArgs e)
        {
            scheduleView.DataSource = DBProvider.Schedules(Group.Text);
            scheduleView.Columns[0].Visible = false;
            scheduleView.Columns[2].Visible = false;
            foreach (var c in splitContainer2.Panel1.Controls.OfType<ComboBox>().Where(c => !c.Enabled))
            {
                c.Enabled = true;
            }
            Pair.Enabled = true;
            confirm.Enabled = true;
            cancel.Enabled = true;
            weekPanel.Enabled = true;
        }

        private void scheduleView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && Group.Enabled && Group.Text != "")
            {
                Group.Enabled = false;
                cancel.Enabled = true;
                confirm.Text = "Редактировать";
                Subject.Text = scheduleView.Rows[e.RowIndex].Cells[1].Value.ToString();
                Instructor.Text = scheduleView.Rows[e.RowIndex].Cells[3].Value.ToString();
                Day.Text = scheduleView.Rows[e.RowIndex].Cells[4].Value.ToString();
                Pair.Text = scheduleView.Rows[e.RowIndex].Cells[5].Value.ToString();
                weekPanel.Controls.OfType<RadioButton>()
                         .First(r => r.Text == scheduleView.Rows[e.RowIndex].Cells[6].Value.ToString())
                         .Checked = true;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Group.Enabled = true;
            confirm.Text = "Добавить";
            Subject.Text = "";
            Instructor.Text = "";
            Day.Text = "";
            Pair.Text = "1";
            Always.Checked = true;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (splitContainer2.Panel1.Controls.OfType<ComboBox>().Count(c => c.Text == "") != 0)
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка");
                return;
            }
            var schedule = new DBProvider.Schedule(Subject.Text, Group.Text, Instructor.Text, Day.Text,
                                                   Convert.ToInt32(Pair.Text),
                                                   weekPanel.Controls.OfType<RadioButton>().First(r => r.Checked).Text);
            if (confirm.Text == "Добавить")
                DBProvider.AddSchedule(schedule);
            else
                DBProvider.UpdateSchedule(schedule,
                                          Convert.ToInt32(
                                              scheduleView.Rows[scheduleView.SelectedCells[0].RowIndex].Cells[0].Value));
            scheduleView.DataSource = DBProvider.Schedules(Group.Text);
            cancel_Click(null, null);
        }

        private void scheduleView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete &&
                MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Предупреждение",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DBProvider.DeleteRow("Schedule", Convert.ToInt32(scheduleView.CurrentRow.Cells[0].Value.ToString()));
                scheduleView.DataSource = DBProvider.Schedules(Group.Text);
            }
        }
    }
}