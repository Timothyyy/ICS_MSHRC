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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.todaySchedule = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scheduleFor = new System.Windows.Forms.ComboBox();
            this.todayScheduleView = new System.Windows.Forms.DataGridView();
            this.scheduleAdmin = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.choice = new System.Windows.Forms.ComboBox();
            this.Numerator = new System.Windows.Forms.RadioButton();
            this.Denominator = new System.Windows.Forms.RadioButton();
            this.tabControl.SuspendLayout();
            this.todaySchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todayScheduleView)).BeginInit();
            this.scheduleAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabControl.Size = new System.Drawing.Size(773, 390);
            this.tabControl.TabIndex = 0;
            // 
            // todaySchedule
            // 
            this.todaySchedule.BackColor = System.Drawing.SystemColors.Control;
            this.todaySchedule.Controls.Add(this.splitContainer1);
            this.todaySchedule.Location = new System.Drawing.Point(4, 22);
            this.todaySchedule.Name = "todaySchedule";
            this.todaySchedule.Padding = new System.Windows.Forms.Padding(3);
            this.todaySchedule.Size = new System.Drawing.Size(765, 364);
            this.todaySchedule.TabIndex = 0;
            this.todaySchedule.Text = "Расписание на сегодня";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.splitContainer1.Size = new System.Drawing.Size(759, 358);
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
            this.panel.Size = new System.Drawing.Size(245, 325);
            this.panel.TabIndex = 2;
            this.panel.Visible = false;
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
            "предмета",
            "студента"});
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
            this.todayScheduleView.Size = new System.Drawing.Size(513, 358);
            this.todayScheduleView.TabIndex = 0;
            // 
            // scheduleAdmin
            // 
            this.scheduleAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.scheduleAdmin.Controls.Add(this.dataGridView1);
            this.scheduleAdmin.Location = new System.Drawing.Point(4, 22);
            this.scheduleAdmin.Name = "scheduleAdmin";
            this.scheduleAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.scheduleAdmin.Size = new System.Drawing.Size(765, 364);
            this.scheduleAdmin.TabIndex = 1;
            this.scheduleAdmin.Text = "Редактирование расписания";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(214, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
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
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 390);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox choice;
        private System.Windows.Forms.RadioButton Denominator;
        private System.Windows.Forms.RadioButton Numerator;


    }
}