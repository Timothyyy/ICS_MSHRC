﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private enum Tables
        {
            StudentsView = 14,
            InstructorsView = 11,
            GroupsView = 5,
            SubjectsView = 3,
        };

        private Dictionary<string, string> SQL = new Dictionary<string, string>
            {
                {"Девушки", "[Пол] = 'Женский'"}, 
                {"Юноши", "[Пол] = 'Мужской'"},
                {"Иногородние", "ToUpper([Адрес]) not like ToUpper('%г%Минск%')"}, 
                {"Иностранцы", "[Гражданство] != 'Беларусь'"},
                {"Несовершеннолетние", "date('now') - date([Дата рождения]) < 18"}, 
                {"Совершеннолетние", "date('now') - date([Дата рождения]) >= 18"},
                {"В общежитии", "[Общежитие] = 1"},
                {"Женщины", "[Пол] = 'Женский'"}, 
                {"Мужчины", "[Пол] = 'Мужской'"},
                {"Кураторы", "Id in (select Curator from Groups)"}
            }; 

        public static DialogResult SubjectBox(string title, ref string[] value)
        {
            var form = new Form();
            var label1 = new Label();
            var name = new TextBox();
            var label2 = new Label();
            var department = new ComboBox();
            var buttonOk = new Button();
            form.Text = title;
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Size = new Size(20, 13);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            name.Location = new Point(74, 15);
            name.Size = new Size(219, 20);
            name.TabIndex = 1;
            name.Text = value[0];
            label2.AutoSize = true;
            label2.Location = new Point(17, 45);
            label2.Size = new Size(20, 13);
            label2.TabIndex = 2;
            label2.Text = "Кафедра:";
            department.DropDownWidth = 300;
            department.FormattingEnabled = true;
            department.Location = new Point(74, 42);
            department.Size = new Size(219, 21);
            department.TabIndex = 2;
            department.KeyPress += department_KeyPress;
            foreach (DataRow row in DBProvider.Departments().Rows)
            {
                department.Items.Add(row[0].ToString());
            }
            if (value[1] != "" && char.IsDigit(value[1], 0))
                department.Text = department.Items[Convert.ToInt32(value[1])].ToString();
            else
                department.Text = value[1];
            buttonOk.Location = new Point(110, 70);
            buttonOk.AutoSize = true;
            buttonOk.Size = new Size(20, 23);
            buttonOk.TabIndex = 3;
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Text = title;
            buttonOk.DialogResult = DialogResult.OK;
            form.ClientSize = new Size(305, 100);
            form.Controls.AddRange(new Control[] { label1, label2, name, department, buttonOk });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.WindowsDefaultLocation;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            var dialogResult = form.ShowDialog();
            value[0] = name.Text;
            if (department.Text != "")
                value[1] = department.FindString(department.Text).ToString();
            else
                value[1] = "";
            return dialogResult;
        }

        private static void department_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Settings(string type)
        {
            groupBox2.Enabled = true;
            tableView.Columns[0].Visible = false;
            foreach (ToolStripMenuItem item in menu.Items)
                item.Enabled = item.Text == type;
            menu.Items[4].Enabled = true;
            criterion.Items.Clear();
            condition.Items.Clear();
            criterion.Text = "";
            criterionValue.Text = "";
            condition.Text = "";
            if (type == "Студенты")
            {
                criterion.Items.AddRange(new object[] { "ФИО", "Адрес", "Дата рождения", "Мед. данные", "Хобби", "Группа" });
                condition.Items.AddRange(new object[] { "Девушки", "Юноши", "Иногородние", "Иностранцы", "Несовершеннолетние", "Совершеннолетние", "В общежитии" });
            }
            if (type == "Преподаватели")
            {
                criterion.Items.AddRange(new object[] { "ФИО", "Адрес", "Должность" });
                condition.Items.AddRange(new object[] { "Мужчины", "Женщины", "Кураторы" });
            }
            if (type == "Группы")
            {
                criterion.Items.AddRange(new object[] { "Номер", "Куратор" });
                groupBox2.Enabled = false;
            }
            if (type == "Предметы")
            {
                criterion.Items.Add("Название");
                groupBox2.Enabled = false;
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "Students")
            {
                tableView.DataSource = null;
                tableView.DataSource = DBProvider.Students();
                Settings("Студенты");
                return;
            }
            if (e.Node.Name == "Instructors")
            {
                tableView.DataSource = null;
                tableView.DataSource = DBProvider.Instructors();
                Settings("Преподаватели");
                return;
            }
            if (e.Node.Name == "Groups")
            {
                tableView.DataSource = null;
                tableView.DataSource = DBProvider.Groups();
                Settings("Группы");
                return;
            }
            if (e.Node.Name == "Subjects")
            {
                tableView.DataSource = null;
                tableView.DataSource = DBProvider.Subjects();
                Settings("Предметы");
                return;
            }
            if (e.Node.Parent.Name == "Students")
            {
                tableView.DataSource = null;
                tableView.DataSource = DBProvider.Students(e.Node.Text);
                Settings("Студенты");
                return;
            }
            if (e.Node.Parent.Name == "Radio")
            {
                tableView.DataSource = null;
                tableView.DataSource = DBProvider.Students(e.Node.Index + 1);
                Settings("Студенты");
                return;
            }
            if (e.Node.Parent.Name == "Electr")
            {
                tableView.DataSource = null;
                tableView.DataSource = DBProvider.Students(e.Node.Index + 3);
                Settings("Студенты");
                return;
            }
            if (e.Node.Parent.Name == "Faculty")
            {
                tableView.DataSource = null;
                tableView.DataSource = DBProvider.Students(e.Node.Index + 7);
                Settings("Студенты");
                return;
            }
            if (e.Node.Parent.Name == "Instructors")
            {
                tableView.DataSource = null;
                tableView.DataSource = DBProvider.Instructors(e.Node.Index + 1);
                Settings("Преподаватели");
                return;
            }
            if (e.Node.Parent.Name == "Groups")
            {
                tableView.DataSource = null;
                tableView.DataSource = DBProvider.Groups(e.Node.Text);
                Settings("Группы");
                return;
            }
            if (e.Node.Parent.Name == "RadioGr")
            {
                tableView.DataSource = null;
                tableView.DataSource = DBProvider.Groups(e.Node.Index + 1);
                Settings("Группы");
                return;
            }
            if (e.Node.Parent.Name == "ElectrGr")
            {
                tableView.DataSource = null;
                tableView.DataSource = DBProvider.Groups(e.Node.Index + 3);
                Settings("Группы");
                return;
            }
            if (e.Node.Parent.Name == "FacultyGr")
            {
                tableView.DataSource = null;
                tableView.DataSource = DBProvider.Groups(e.Node.Index + 7);
                Settings("Группы");
                return;
            }
            if (e.Node.Parent.Name == "Subjects")
            {
                tableView.DataSource = null;
                tableView.DataSource = DBProvider.Subjects(e.Node.Index + 1);
                Settings("Предметы");
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
            var value = new[] {"", ""};
            replay:
            if (SubjectBox("Добавить", ref value) != DialogResult.OK) return;
            if (value.Any(s => s == ""))
            {
                MessageBox.Show("Все поля должны быть заполнены!");
                goto replay;
            }
            DBProvider.AddSubject(value[0], Convert.ToInt32(value[1]) + 1);
            tableView.DataSource = DBProvider.Subjects();
        }

        private void tableView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && tableView.ColumnCount == 14)
            {
                var student = new DBProvider.Student(tableView.Rows[e.RowIndex].Cells);
                (new StudentForm("Редактировать", tableView, student, Convert.ToInt32(tableView.Rows[e.RowIndex].Cells[0].Value))).Show();
                return;
            }
            if (e.RowIndex >= 0 && tableView.ColumnCount == 11)
            {
                var instructor = new DBProvider.Instructor(tableView.Rows[e.RowIndex].Cells);
                (new InstructorForm("Редактировать", tableView, instructor, Convert.ToInt32(tableView.Rows[e.RowIndex].Cells[0].Value))).Show();
                return;
            }
            if (e.RowIndex >= 0 && tableView.ColumnCount == 5)
            {
                var group = new DBProvider.Group(tableView.Rows[e.RowIndex].Cells);
                (new GroupForm("Редактировать", tableView, group, Convert.ToInt32(tableView.Rows[e.RowIndex].Cells[0].Value))).Show();
                return;
            }
            if (e.RowIndex >= 0 && tableView.ColumnCount == 3)
            {
                var value = new[] { tableView.Rows[e.RowIndex].Cells[1].Value.ToString(), tableView.Rows[e.RowIndex].Cells[2].Value.ToString() };
                replay:
                if (SubjectBox("Редактировать", ref value) == DialogResult.OK)
                {
                    if (value.Any(s => s == ""))
                    {
                        MessageBox.Show("Все поля должны быть заполнены!");
                        goto replay;
                    }
                    DBProvider.UpdateSubject(value[0], Convert.ToInt32(value[1]) + 1, Convert.ToInt32(tableView.Rows[e.RowIndex].Cells[0].Value));
                    tableView.DataSource = DBProvider.Subjects();
                }
            }
        }

        private void scheduleMenu_Click(object sender, EventArgs e)
        {
            (new ScheduleForm()).Show();
        }

        private void tableView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (tableView.ColumnCount == 14)
                {
                    DBProvider.DeleteRow("Students", Convert.ToInt32(tableView.CurrentRow.Cells[0].Value.ToString()));
                    tableView.DataSource = DBProvider.Students();
                    return;
                }
                if (tableView.ColumnCount == 11 && MessageBox.Show("При удалении преподавателя удалятся записи других таблиц, которые ссылаются на него! Действительно удалить?",
                    "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DBProvider.DeleteRow("Instructors", Convert.ToInt32(tableView.CurrentRow.Cells[0].Value.ToString()));
                    tableView.DataSource = DBProvider.Instructors();
                    return;
                }
                if (tableView.ColumnCount == 5 && MessageBox.Show("При удалении группы удалятся записи других таблиц, которые ссылаются на неё! Действительно удалить?",
                    "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DBProvider.DeleteRow("Groups", Convert.ToInt32(tableView.CurrentRow.Cells[0].Value.ToString()));
                    tableView.DataSource = DBProvider.Groups();
                    return;
                }
                if (tableView.ColumnCount == 3 && MessageBox.Show("При удалении предмета удалятся записи других таблиц, которые ссылаются на него! Действительно удалить?",
                    "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DBProvider.DeleteRow("Subjects", Convert.ToInt32(tableView.CurrentRow.Cells[0].Value.ToString()));
                    tableView.DataSource = DBProvider.Subjects();
                }
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (criterion.Text != "")
            {
                tableView.DataSource = DBProvider.Search(Enum.GetName(typeof(Tables), tableView.ColumnCount), criterion.Text, criterionValue.Text);
                MessageBox.Show("Найдено записей: " + tableView.RowCount, "Результаты поиска");
            }
        }

        private void criterion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void filter_Click(object sender, EventArgs e)
        {
            if (condition.Text != "")
            {
                tableView.DataSource = DBProvider.Filter(Enum.GetName(typeof(Tables), tableView.ColumnCount), SQL.FirstOrDefault(p => p.Key == condition.Text).Value);
                MessageBox.Show("Найдено записей: " + tableView.RowCount, "Результаты фильтра");
            }
        }
    }
}