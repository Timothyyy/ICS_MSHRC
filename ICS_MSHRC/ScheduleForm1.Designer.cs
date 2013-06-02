namespace ICS_MSHRC
{
    partial class ScheduleForm1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.ComboBox();
            this.Group = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Instructor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Pair = new System.Windows.Forms.NumericUpDown();
            this.Always = new System.Windows.Forms.RadioButton();
            this.Numerator = new System.Windows.Forms.RadioButton();
            this.Denominator = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pair)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Предмет:";
            // 
            // Subject
            // 
            this.Subject.FormattingEnabled = true;
            this.Subject.Location = new System.Drawing.Point(107, 12);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(207, 21);
            this.Subject.TabIndex = 1;
            this.Subject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Subject_KeyPress);
            // 
            // Group
            // 
            this.Group.FormattingEnabled = true;
            this.Group.Location = new System.Drawing.Point(107, 39);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(207, 21);
            this.Group.TabIndex = 3;
            this.Group.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Subject_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Группа:";
            // 
            // Instructor
            // 
            this.Instructor.FormattingEnabled = true;
            this.Instructor.Location = new System.Drawing.Point(107, 66);
            this.Instructor.Name = "Instructor";
            this.Instructor.Size = new System.Drawing.Size(207, 21);
            this.Instructor.TabIndex = 5;
            this.Instructor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Subject_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Преподаватель:";
            // 
            // Day
            // 
            this.Day.FormattingEnabled = true;
            this.Day.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота"});
            this.Day.Location = new System.Drawing.Point(107, 93);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(207, 21);
            this.Day.TabIndex = 7;
            this.Day.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Subject_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "День:";
            // 
            // Pair
            // 
            this.Pair.Location = new System.Drawing.Point(107, 120);
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
            this.Pair.Size = new System.Drawing.Size(207, 20);
            this.Pair.TabIndex = 8;
            this.Pair.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // Numerator
            // 
            this.Numerator.AutoSize = true;
            this.Numerator.Location = new System.Drawing.Point(16, 26);
            this.Numerator.Name = "Numerator";
            this.Numerator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Numerator.Size = new System.Drawing.Size(80, 17);
            this.Numerator.TabIndex = 10;
            this.Numerator.TabStop = true;
            this.Numerator.Text = "Числитель";
            this.Numerator.UseVisualStyleBackColor = true;
            // 
            // Denominator
            // 
            this.Denominator.AutoSize = true;
            this.Denominator.Location = new System.Drawing.Point(3, 49);
            this.Denominator.Name = "Denominator";
            this.Denominator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Denominator.Size = new System.Drawing.Size(93, 17);
            this.Denominator.TabIndex = 11;
            this.Denominator.TabStop = true;
            this.Denominator.Text = "Знаменатель";
            this.Denominator.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Пара:";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.Always);
            this.panel.Controls.Add(this.Numerator);
            this.panel.Controls.Add(this.Denominator);
            this.panel.Location = new System.Drawing.Point(107, 146);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(103, 70);
            this.panel.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Неделя:";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(107, 222);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(103, 23);
            this.confirm.TabIndex = 15;
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 259);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pair);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Instructor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleForm";
            ((System.ComponentModel.ISupportInitialize)(this.Pair)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Subject;
        private System.Windows.Forms.ComboBox Group;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Instructor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Pair;
        private System.Windows.Forms.RadioButton Always;
        private System.Windows.Forms.RadioButton Numerator;
        private System.Windows.Forms.RadioButton Denominator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button confirm;
    }
}