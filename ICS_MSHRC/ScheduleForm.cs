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
        }

        private enum ForType
        {
            Выберите_группу = 0,
            Выберите_преподавателя = 1,
            Выберите_предмет = 2,
            Выберите_студента = 3
        };

        private enum Choice
        {
            Groups = 0,
            Instructors = 1,
            Subjects = 2,
            Students = 3
        };

        private enum Column
        {
            Группа = 0,
            Преподаватель = 1,
            Предмет = 2,
            Id = 3
        };

        private void scheduleFor_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*var a = Enum.GetName(typeof(ForType), 0);
            MessageBox.Show(a);
            return;*/
            todayScheduleView.DataSource = null;
            choice.Text = "";
            choice.Items.Clear();
            panel.Visible = true;
            tabControl.TabPages.Remove(scheduleAdmin);
            if (scheduleFor.SelectedIndex == 0)
                tabControl.TabPages.Add(scheduleAdmin);
            label2.Text = Enum.GetName(typeof (ForType), scheduleFor.SelectedIndex).Replace('_', ' ') + ':';
            var view = Enum.GetName(typeof (Choice), scheduleFor.SelectedIndex);
            foreach (DataRow row in DBProvider.Choices(view).Rows)
            {
                choice.Items.Add(row[0].ToString());
            }
        }

        private void choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            var column = Enum.GetName(typeof(Column), scheduleFor.SelectedIndex);
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
                    var column = Enum.GetName(typeof(Column), scheduleFor.SelectedIndex);
                    var week = ((RadioButton) sender).Text;
                    todayScheduleView.DataSource = DBProvider.TodaySchedule(column, choice.Text, week);
                }
        }
    }
}