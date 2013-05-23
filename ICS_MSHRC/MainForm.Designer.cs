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
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Проектирование и производство радиоэлектронных средств");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Техническая эксплуатация радиоэлектронных средств");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Радиотехническое отделение", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Электронные вычислительные средства");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Микроэлектроника");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Коммерческая деятельность");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Отделение электроники", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Отделение программирования");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Студенты", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode30,
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Кафедра информатики");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Кафедра радиоэлектроники");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Кафедра математических и естественнонаучных дисциплин");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Кафедра экономики и управления");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Кафедра общетехнических дисциплин");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Кафедра социально-гуманитарных дисциплин");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Кафедра психолого-педагогических дисциплин");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Кафедра физического воспитания и спорта");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Преподаватели", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Предметы");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Узел15");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Узел16");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Узел17");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Готовые представления", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44,
            treeNode45});
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.tableView = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.studentsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.changeStudentMenu = new System.Windows.Forms.ToolStripMenuItem();
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
            treeNode24.Name = "Design";
            treeNode24.Text = "Проектирование и производство радиоэлектронных средств";
            treeNode25.Name = "Oper";
            treeNode25.Text = "Техническая эксплуатация радиоэлектронных средств";
            treeNode26.Name = "Radio";
            treeNode26.Text = "Радиотехническое отделение";
            treeNode27.Name = "Emu";
            treeNode27.Text = "Электронные вычислительные средства";
            treeNode28.Name = "Micro";
            treeNode28.Text = "Микроэлектроника";
            treeNode29.Name = "Commerc";
            treeNode29.Text = "Коммерческая деятельность";
            treeNode30.Name = "Electr";
            treeNode30.Text = "Отделение электроники";
            treeNode31.Name = "Progr";
            treeNode31.Text = "Отделение программирования";
            treeNode32.Name = "Students";
            treeNode32.Text = "Студенты";
            treeNode33.Name = "Inform";
            treeNode33.Text = "Кафедра информатики";
            treeNode34.Name = "Radioel";
            treeNode34.Text = "Кафедра радиоэлектроники";
            treeNode35.Name = "Math";
            treeNode35.Text = "Кафедра математических и естественнонаучных дисциплин";
            treeNode36.Name = "Econ";
            treeNode36.Text = "Кафедра экономики и управления";
            treeNode37.Name = "Basetech";
            treeNode37.Text = "Кафедра общетехнических дисциплин";
            treeNode38.Name = "Social";
            treeNode38.Text = "Кафедра социально-гуманитарных дисциплин";
            treeNode39.Name = "Psych";
            treeNode39.Text = "Кафедра психолого-педагогических дисциплин";
            treeNode40.Name = "Phys";
            treeNode40.Text = "Кафедра физического воспитания и спорта";
            treeNode41.Name = "Instructors";
            treeNode41.Text = "Преподаватели";
            treeNode42.Name = "Subjects";
            treeNode42.Text = "Предметы";
            treeNode43.Name = "Узел15";
            treeNode43.Text = "Узел15";
            treeNode44.Name = "Узел16";
            treeNode44.Text = "Узел16";
            treeNode45.Name = "Узел17";
            treeNode45.Text = "Узел17";
            treeNode46.Name = "Views";
            treeNode46.Text = "Готовые представления";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode41,
            treeNode42,
            treeNode46});
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
            this.addStudentMenu,
            this.changeStudentMenu});
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
            // changeStudentMenu
            // 
            this.changeStudentMenu.Name = "changeStudentMenu";
            this.changeStudentMenu.Size = new System.Drawing.Size(152, 22);
            this.changeStudentMenu.Text = "Изменить";
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
        private System.Windows.Forms.ToolStripMenuItem changeStudentMenu;

    }
}

