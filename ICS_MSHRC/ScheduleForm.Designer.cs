namespace ICS_MSHRC
{
    partial class ScheduleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.todaySchedule = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel = new System.Windows.Forms.Panel();
            this.Denominator = new System.Windows.Forms.RadioButton();
            this.Numerator = new System.Windows.Forms.RadioButton();
            this.choice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scheduleFor = new System.Windows.Forms.ComboBox();
            this.todayScheduleView = new System.Windows.Forms.DataGridView();
            this.scheduleAdmin = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cancel = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.weekPanel = new System.Windows.Forms.Panel();
            this.Always = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.Pair = new System.Windows.Forms.NumericUpDown();
            this.Day = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Instructor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Group = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.scheduleView = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.todaySchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todayScheduleView)).BeginInit();
            this.scheduleAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.weekPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.todaySchedule);
            this.tabControl.Controls.Add(this.scheduleAdmin);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(763, 353);
            this.tabControl.TabIndex = 0;
            // 
            // todaySchedule
            // 
            this.todaySchedule.BackColor = System.Drawing.SystemColors.Control;
            this.todaySchedule.Controls.Add(this.splitContainer1);
            this.todaySchedule.Location = new System.Drawing.Point(4, 22);
            this.todaySchedule.Name = "todaySchedule";
            this.todaySchedule.Padding = new System.Windows.Forms.Padding(3);
            this.todaySchedule.Size = new System.Drawing.Size(755, 327);
            this.todaySchedule.TabIndex = 0;
            this.todaySchedule.Text = "Расписание на сегодня";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.scheduleFor);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.todayScheduleView);
            this.splitContainer1.Size = new System.Drawing.Size(749, 321);
            this.splitContainer1.SplitterDistance = 245;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.Denominator);
            this.panel.Controls.Add(this.Numerator);
            this.panel.Controls.Add(this.choice);
            this.panel.Controls.Add(this.label2);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 33);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(245, 288);
            this.panel.TabIndex = 2;
            this.panel.Visible = false;
            // 
            // Denominator
            // 
            this.Denominator.AutoSize = true;
            this.Denominator.Location = new System.Drawing.Point(5, 75);
            this.Denominator.Name = "Denominator";
            this.Denominator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Denominator.Size = new System.Drawing.Size(93, 17);
            this.Denominator.TabIndex = 3;
            this.Denominator.Text = "Знаменатель";
            this.Denominator.UseVisualStyleBackColor = true;
            this.Denominator.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Numerator
            // 
            this.Numerator.AutoSize = true;
            this.Numerator.Checked = true;
            this.Numerator.Location = new System.Drawing.Point(18, 52);
            this.Numerator.Name = "Numerator";
            this.Numerator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Numerator.Size = new System.Drawing.Size(80, 17);
            this.Numerator.TabIndex = 2;
            this.Numerator.TabStop = true;
            this.Numerator.Text = "Числитель";
            this.Numerator.UseVisualStyleBackColor = true;
            this.Numerator.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // choice
            // 
            this.choice.FormattingEnabled = true;
            this.choice.Location = new System.Drawing.Point(5, 25);
            this.choice.Name = "choice";
            this.choice.Size = new System.Drawing.Size(235, 21);
            this.choice.TabIndex = 1;
            this.choice.SelectedIndexChanged += new System.EventHandler(this.choice_SelectedIndexChanged);
            this.choice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scheduleFor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Для:";
            // 
            // scheduleFor
            // 
            this.scheduleFor.FormattingEnabled = true;
            this.scheduleFor.Items.AddRange(new object[] {
            "группы",
            "преподавателя",
            "предмета"});
            this.scheduleFor.Location = new System.Drawing.Point(42, 6);
            this.scheduleFor.Name = "scheduleFor";
            this.scheduleFor.Size = new System.Drawing.Size(198, 21);
            this.scheduleFor.TabIndex = 0;
            this.scheduleFor.SelectedIndexChanged += new System.EventHandler(this.scheduleFor_SelectedIndexChanged);
            this.scheduleFor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scheduleFor_KeyPress);
            // 
            // todayScheduleView
            // 
            this.todayScheduleView.AllowUserToAddRows = false;
            this.todayScheduleView.AllowUserToDeleteRows = false;
            this.todayScheduleView.AllowUserToResizeColumns = false;
            this.todayScheduleView.AllowUserToResizeRows = false;
            this.todayScheduleView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.todayScheduleView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.todayScheduleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.todayScheduleView.DefaultCellStyle = dataGridViewCellStyle4;
            this.todayScheduleView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todayScheduleView.Location = new System.Drawing.Point(0, 0);
            this.todayScheduleView.MultiSelect = false;
            this.todayScheduleView.Name = "todayScheduleView";
            this.todayScheduleView.ReadOnly = true;
            this.todayScheduleView.RowHeadersVisible = false;
            this.todayScheduleView.Size = new System.Drawing.Size(503, 321);
            this.todayScheduleView.TabIndex = 0;
            // 
            // scheduleAdmin
            // 
            this.scheduleAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.scheduleAdmin.Controls.Add(this.splitContainer2);
            this.scheduleAdmin.Location = new System.Drawing.Point(4, 22);
            this.scheduleAdmin.Name = "scheduleAdmin";
            this.scheduleAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.scheduleAdmin.Size = new System.Drawing.Size(755, 327);
            this.scheduleAdmin.TabIndex = 1;
            this.scheduleAdmin.Text = "Редактирование расписания";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cancel);
            this.splitContainer2.Panel1.Controls.Add(this.confirm);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.weekPanel);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.Pair);
            this.splitContainer2.Panel1.Controls.Add(this.Day);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.Instructor);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.Group);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.Subject);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.scheduleView);
            this.splitContainer2.Size = new System.Drawing.Size(749, 321);
            this.splitContainer2.SplitterDistance = 221;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // cancel
            // 
            this.cancel.Enabled = false;
            this.cancel.Location = new System.Drawing.Point(115, 278);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(101, 23);
            this.cancel.TabIndex = 29;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // confirm
            // 
            this.confirm.Enabled = false;
            this.confirm.Location = new System.Drawing.Point(5, 278);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(101, 23);
            this.confirm.TabIndex = 28;
            this.confirm.Text = "Добавить";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Неделя:";
            // 
            // weekPanel
            // 
            this.weekPanel.Controls.Add(this.Always);
            this.weekPanel.Controls.Add(this.radioButton1);
            this.weekPanel.Controls.Add(this.radioButton2);
            this.weekPanel.Enabled = false;
            this.weekPanel.Location = new System.Drawing.Point(51, 202);
            this.weekPanel.Name = "weekPanel";
            this.weekPanel.Size = new System.Drawing.Size(101, 70);
            this.weekPanel.TabIndex = 26;
            // 
            // Always
            // 
            this.Always.AutoSize = true;
            this.Always.Checked = true;
            this.Always.Location = new System.Drawing.Point(35, 3);
            this.Always.Name = "Always";
            this.Always.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Always.Size = new System.Drawing.Size(61, 17);
            this.Always.TabIndex = 9;
            this.Always.TabStop = true;
            this.Always.Text = "Всегда";
            this.Always.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(80, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Числитель";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(93, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Знаменатель";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Пара:";
            // 
            // Pair
            // 
            this.Pair.Enabled = false;
            this.Pair.Location = new System.Drawing.Point(0, 176);
            this.Pair.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Pair.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Pair.Name = "Pair";
            this.Pair.ReadOnly = true;
            this.Pair.Size = new System.Drawing.Size(216, 20);
            this.Pair.TabIndex = 24;
            this.Pair.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Day
            // 
            this.Day.Enabled = false;
            this.Day.FormattingEnabled = true;
            this.Day.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота"});
            this.Day.Location = new System.Drawing.Point(0, 136);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(216, 21);
            this.Day.TabIndex = 23;
            this.Day.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scheduleFor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "День:";
            // 
            // Instructor
            // 
            this.Instructor.Enabled = false;
            this.Instructor.FormattingEnabled = true;
            this.Instructor.Location = new System.Drawing.Point(0, 96);
            this.Instructor.Name = "Instructor";
            this.Instructor.Size = new System.Drawing.Size(216, 21);
            this.Instructor.TabIndex = 21;
            this.Instructor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scheduleFor_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Преподаватель:";
            // 
            // Group
            // 
            this.Group.FormattingEnabled = true;
            this.Group.Location = new System.Drawing.Point(0, 16);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(216, 21);
            this.Group.TabIndex = 19;
            this.Group.SelectedIndexChanged += new System.EventHandler(this.Group_SelectedIndexChanged);
            this.Group.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scheduleFor_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Группа:";
            // 
            // Subject
            // 
            this.Subject.Enabled = false;
            this.Subject.FormattingEnabled = true;
            this.Subject.Location = new System.Drawing.Point(0, 56);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(216, 21);
            this.Subject.TabIndex = 17;
            this.Subject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scheduleFor_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-3, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Предмет:";
            // 
            // scheduleView
            // 
            this.scheduleView.AllowUserToAddRows = false;
            this.scheduleView.AllowUserToDeleteRows = false;
            this.scheduleView.AllowUserToResizeColumns = false;
            this.scheduleView.AllowUserToResizeRows = false;
            this.scheduleView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scheduleView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.scheduleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scheduleView.DefaultCellStyle = dataGridViewCellStyle3;
            this.scheduleView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduleView.Location = new System.Drawing.Point(0, 0);
            this.scheduleView.MultiSelect = false;
            this.scheduleView.Name = "scheduleView";
            this.scheduleView.ReadOnly = true;
            this.scheduleView.RowHeadersVisible = false;
            this.scheduleView.Size = new System.Drawing.Size(527, 321);
            this.scheduleView.TabIndex = 0;
            this.scheduleView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scheduleView_CellDoubleClick);
            this.scheduleView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.scheduleView_KeyDown);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 353);
            this.Controls.Add(this.tabControl);
            this.Name = "ScheduleForm";
            this.Text = "Расписание";
            this.tabControl.ResumeLayout(false);
            this.todaySchedule.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todayScheduleView)).EndInit();
            this.scheduleAdmin.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.weekPanel.ResumeLayout(false);
            this.weekPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage todaySchedule;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage scheduleAdmin;
        private System.Windows.Forms.DataGridView todayScheduleView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox scheduleFor;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox choice;
        private System.Windows.Forms.RadioButton Denominator;
        private System.Windows.Forms.RadioButton Numerator;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView scheduleView;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel weekPanel;
        private System.Windows.Forms.RadioButton Always;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Pair;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Instructor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Group;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Subject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancel;


    }
}