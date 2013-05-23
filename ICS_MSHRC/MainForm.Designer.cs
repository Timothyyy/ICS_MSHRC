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
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Проектирование и производство радиоэлектронных средств");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Техническая эксплуатация радиоэлектронных средств");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Радиотехническое отделение", new System.Windows.Forms.TreeNode[] {
            treeNode70,
            treeNode71});
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Электронные вычислительные средства");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Микроэлектроника");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Коммерческая деятельность");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Отделение электроники", new System.Windows.Forms.TreeNode[] {
            treeNode73,
            treeNode74,
            treeNode75});
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Отделение программирования");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Студенты", new System.Windows.Forms.TreeNode[] {
            treeNode72,
            treeNode76,
            treeNode77});
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("Кафедра информатики");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Кафедра радиоэлектроники");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Кафедра математических и естественнонаучных дисциплин");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Кафедра экономики и управления");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Кафедра общетехнических дисциплин");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Кафедра социально-гуманитарных дисциплин");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Кафедра психолого-педагогических дисциплин");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Кафедра физического воспитания и спорта");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("Преподаватели", new System.Windows.Forms.TreeNode[] {
            treeNode79,
            treeNode80,
            treeNode81,
            treeNode82,
            treeNode83,
            treeNode84,
            treeNode85,
            treeNode86});
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("Предметы");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Узел15");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("Узел16");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("Узел17");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Готовые представления", new System.Windows.Forms.TreeNode[] {
            treeNode89,
            treeNode90,
            treeNode91});
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.tableView = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.studentsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentMenu = new System.Windows.Forms.ToolStripMenuItem();
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
            treeNode70.Name = "Design";
            treeNode70.Text = "Проектирование и производство радиоэлектронных средств";
            treeNode71.Name = "Oper";
            treeNode71.Text = "Техническая эксплуатация радиоэлектронных средств";
            treeNode72.Name = "Radio";
            treeNode72.Text = "Радиотехническое отделение";
            treeNode73.Name = "Emu";
            treeNode73.Text = "Электронные вычислительные средства";
            treeNode74.Name = "Micro";
            treeNode74.Text = "Микроэлектроника";
            treeNode75.Name = "Commerc";
            treeNode75.Text = "Коммерческая деятельность";
            treeNode76.Name = "Electr";
            treeNode76.Text = "Отделение электроники";
            treeNode77.Name = "Progr";
            treeNode77.Text = "Отделение программирования";
            treeNode78.Name = "Students";
            treeNode78.Text = "Студенты";
            treeNode79.Name = "Inform";
            treeNode79.Text = "Кафедра информатики";
            treeNode80.Name = "Radioel";
            treeNode80.Text = "Кафедра радиоэлектроники";
            treeNode81.Name = "Math";
            treeNode81.Text = "Кафедра математических и естественнонаучных дисциплин";
            treeNode82.Name = "Econ";
            treeNode82.Text = "Кафедра экономики и управления";
            treeNode83.Name = "Basetech";
            treeNode83.Text = "Кафедра общетехнических дисциплин";
            treeNode84.Name = "Social";
            treeNode84.Text = "Кафедра социально-гуманитарных дисциплин";
            treeNode85.Name = "Psych";
            treeNode85.Text = "Кафедра психолого-педагогических дисциплин";
            treeNode86.Name = "Phys";
            treeNode86.Text = "Кафедра физического воспитания и спорта";
            treeNode87.Name = "Instructors";
            treeNode87.Text = "Преподаватели";
            treeNode88.Name = "Subjects";
            treeNode88.Text = "Предметы";
            treeNode89.Name = "Узел15";
            treeNode89.Text = "Узел15";
            treeNode90.Name = "Узел16";
            treeNode90.Text = "Узел16";
            treeNode91.Name = "Узел17";
            treeNode91.Text = "Узел17";
            treeNode92.Name = "Views";
            treeNode92.Text = "Готовые представления";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode78,
            treeNode87,
            treeNode88,
            treeNode92});
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
            this.tableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableView.Location = new System.Drawing.Point(0, 0);
            this.tableView.MultiSelect = false;
            this.tableView.Name = "tableView";
            this.tableView.ReadOnly = true;
            this.tableView.RowHeadersVisible = false;
            this.tableView.Size = new System.Drawing.Size(799, 576);
            this.tableView.TabIndex = 0;
            this.tableView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableView_CellDoubleClick);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsMenu});
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
            this.addStudentMenu.Size = new System.Drawing.Size(152, 22);
            this.addStudentMenu.Text = "Добавить";
            this.addStudentMenu.Click += new System.EventHandler(this.addStudentMenu_Click);
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

    }
}

