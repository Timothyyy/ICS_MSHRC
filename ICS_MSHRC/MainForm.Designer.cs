namespace ICS_MSHRC
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Проектирование и производство радиоэлектронных средств");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Техническая эксплуатация радиоэлектронных средств");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Радиотехническое отделение", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Электронные вычислительные средства");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Микроэлектроника");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Коммерческая деятельность");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Отделение электроники", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Отделение программирования");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Студенты", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode35,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Кафедра информатики");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Кафедра радиоэлектроники");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Кафедра математических и естественнонаучных дисциплин");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Кафедра экономики и управления");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Кафедра общетехнических дисциплин");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Кафедра социально-гуманитарных дисциплин");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Кафедра психолого-педагогических дисциплин");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Кафедра физического воспитания и спорта");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Преподаватели", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45});
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Проектирование и производство радиоэлектронных средств");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Техническая эксплуатация радиоэлектронных средств");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Радиотехническое отделение", new System.Windows.Forms.TreeNode[] {
            treeNode47,
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Электронные вычислительные средства");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Микроэлектроника");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Коммерческая деятельность");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Отделение электроники", new System.Windows.Forms.TreeNode[] {
            treeNode50,
            treeNode51,
            treeNode52});
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Отделение программирования");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Группы", new System.Windows.Forms.TreeNode[] {
            treeNode49,
            treeNode53,
            treeNode54});
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Предметы");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.tableView = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.studentsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addInstructorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addGroupMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tableView);
            this.splitContainer.Size = new System.Drawing.Size(966, 576);
            this.splitContainer.SplitterDistance = 166;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            treeNode29.Name = "Design";
            treeNode29.Text = "Проектирование и производство радиоэлектронных средств";
            treeNode30.Name = "Oper";
            treeNode30.Text = "Техническая эксплуатация радиоэлектронных средств";
            treeNode31.Name = "Radio";
            treeNode31.Text = "Радиотехническое отделение";
            treeNode32.Name = "Emu";
            treeNode32.Text = "Электронные вычислительные средства";
            treeNode33.Name = "Micro";
            treeNode33.Text = "Микроэлектроника";
            treeNode34.Name = "Commerc";
            treeNode34.Text = "Коммерческая деятельность";
            treeNode35.Name = "Electr";
            treeNode35.Text = "Отделение электроники";
            treeNode36.Name = "Progr";
            treeNode36.Text = "Отделение программирования";
            treeNode37.Name = "Students";
            treeNode37.Text = "Студенты";
            treeNode38.Name = "Inform";
            treeNode38.Text = "Кафедра информатики";
            treeNode39.Name = "Radioel";
            treeNode39.Text = "Кафедра радиоэлектроники";
            treeNode40.Name = "Math";
            treeNode40.Text = "Кафедра математических и естественнонаучных дисциплин";
            treeNode41.Name = "Econ";
            treeNode41.Text = "Кафедра экономики и управления";
            treeNode42.Name = "Basetech";
            treeNode42.Text = "Кафедра общетехнических дисциплин";
            treeNode43.Name = "Social";
            treeNode43.Text = "Кафедра социально-гуманитарных дисциплин";
            treeNode44.Name = "Psych";
            treeNode44.Text = "Кафедра психолого-педагогических дисциплин";
            treeNode45.Name = "Phys";
            treeNode45.Text = "Кафедра физического воспитания и спорта";
            treeNode46.Name = "Instructors";
            treeNode46.Text = "Преподаватели";
            treeNode47.Name = "DesignGr";
            treeNode47.Text = "Проектирование и производство радиоэлектронных средств";
            treeNode48.Name = "OperGr";
            treeNode48.Text = "Техническая эксплуатация радиоэлектронных средств";
            treeNode49.Name = "RadioGr";
            treeNode49.Text = "Радиотехническое отделение";
            treeNode50.Name = "EmuGr";
            treeNode50.Text = "Электронные вычислительные средства";
            treeNode51.Name = "MicroGr";
            treeNode51.Text = "Микроэлектроника";
            treeNode52.Name = "CommercGr";
            treeNode52.Text = "Коммерческая деятельность";
            treeNode53.Name = "ElectrGr";
            treeNode53.Text = "Отделение электроники";
            treeNode54.Name = "ProgrGr";
            treeNode54.Text = "Отделение программирования";
            treeNode55.Name = "Groups";
            treeNode55.Text = "Группы";
            treeNode56.Name = "Subjects";
            treeNode56.Text = "Предметы";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode46,
            treeNode55,
            treeNode56});
            this.treeView.Size = new System.Drawing.Size(166, 576);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // tableView
            // 
            this.tableView.AllowUserToAddRows = false;
            this.tableView.AllowUserToDeleteRows = false;
            this.tableView.AllowUserToResizeColumns = false;
            this.tableView.AllowUserToResizeRows = false;
            this.tableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableView.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableView.Location = new System.Drawing.Point(0, 0);
            this.tableView.MultiSelect = false;
            this.tableView.Name = "tableView";
            this.tableView.ReadOnly = true;
            this.tableView.RowHeadersVisible = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tableView.Size = new System.Drawing.Size(799, 576);
            this.tableView.TabIndex = 0;
            this.tableView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableView_CellDoubleClick);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsMenu,
            this.instructorsMenu,
            this.groupsMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(966, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menu";
            // 
            // studentsMenu
            // 
            this.studentsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentMenu});
            this.studentsMenu.Name = "studentsMenu";
            this.studentsMenu.Size = new System.Drawing.Size(71, 20);
            this.studentsMenu.Text = "Студенты";
            // 
            // addStudentMenu
            // 
            this.addStudentMenu.Name = "addStudentMenu";
            this.addStudentMenu.Size = new System.Drawing.Size(126, 22);
            this.addStudentMenu.Text = "Добавить";
            this.addStudentMenu.Click += new System.EventHandler(this.addStudentMenu_Click);
            // 
            // instructorsMenu
            // 
            this.instructorsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addInstructorMenu});
            this.instructorsMenu.Name = "instructorsMenu";
            this.instructorsMenu.Size = new System.Drawing.Size(104, 20);
            this.instructorsMenu.Text = "Преподаватели";
            // 
            // addInstructorMenu
            // 
            this.addInstructorMenu.Name = "addInstructorMenu";
            this.addInstructorMenu.Size = new System.Drawing.Size(126, 22);
            this.addInstructorMenu.Text = "Добавить";
            this.addInstructorMenu.Click += new System.EventHandler(this.addInstructorMenu_Click);
            // 
            // groupsMenu
            // 
            this.groupsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGroupMenu});
            this.groupsMenu.Name = "groupsMenu";
            this.groupsMenu.Size = new System.Drawing.Size(61, 20);
            this.groupsMenu.Text = "Группы";
            // 
            // addGroupMenu
            // 
            this.addGroupMenu.Name = "addGroupMenu";
            this.addGroupMenu.Size = new System.Drawing.Size(152, 22);
            this.addGroupMenu.Text = "Добавить";
            this.addGroupMenu.Click += new System.EventHandler(this.addGroupMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 600);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "Администрирование";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.DataGridView tableView;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem studentsMenu;
        private System.Windows.Forms.ToolStripMenuItem addStudentMenu;
        private System.Windows.Forms.ToolStripMenuItem instructorsMenu;
        private System.Windows.Forms.ToolStripMenuItem addInstructorMenu;
        private System.Windows.Forms.ToolStripMenuItem groupsMenu;
        private System.Windows.Forms.ToolStripMenuItem addGroupMenu;

    }
}

