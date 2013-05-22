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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Проектирование и производство радиоэлектронных средств");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Техническая эксплуатация радиоэлектронных средств");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Радиотехническое отделение", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Электронные вычислительные средства");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Микроэлектроника");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Коммерческая деятельность");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Отделение электроники", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Отделение программирования");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Студенты", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Кафедра информатики");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Кафедра радиоэлектроники");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Кафедра математических и естественнонаучных дисциплин");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Кафедра экономики и управления");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Кафедра общетехнических дисциплин");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Кафедра социально-гуманитарных дисциплин");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Кафедра психолого-педагогических дисциплин");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Кафедра физического воспитания и спорта");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Преподаватели", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Предметы");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Узел15");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Узел16");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Узел17");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Готовые представления", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22});
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.tableView = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
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
            treeNode1.Name = "Design";
            treeNode1.Text = "Проектирование и производство радиоэлектронных средств";
            treeNode2.Name = "Oper";
            treeNode2.Text = "Техническая эксплуатация радиоэлектронных средств";
            treeNode3.Name = "Radio";
            treeNode3.Text = "Радиотехническое отделение";
            treeNode4.Name = "Emu";
            treeNode4.Text = "Электронные вычислительные средства";
            treeNode5.Name = "Micro";
            treeNode5.Text = "Микроэлектроника";
            treeNode6.Name = "Commerc";
            treeNode6.Text = "Коммерческая деятельность";
            treeNode7.Name = "Electr";
            treeNode7.Text = "Отделение электроники";
            treeNode8.Name = "Progr";
            treeNode8.Text = "Отделение программирования";
            treeNode9.Name = "Students";
            treeNode9.Text = "Студенты";
            treeNode10.Name = "Inform";
            treeNode10.Text = "Кафедра информатики";
            treeNode11.Name = "Radioel";
            treeNode11.Text = "Кафедра радиоэлектроники";
            treeNode12.Name = "Math";
            treeNode12.Text = "Кафедра математических и естественнонаучных дисциплин";
            treeNode13.Name = "Econ";
            treeNode13.Text = "Кафедра экономики и управления";
            treeNode14.Name = "Basetech";
            treeNode14.Text = "Кафедра общетехнических дисциплин";
            treeNode15.Name = "Social";
            treeNode15.Text = "Кафедра социально-гуманитарных дисциплин";
            treeNode16.Name = "Psych";
            treeNode16.Text = "Кафедра психолого-педагогических дисциплин";
            treeNode17.Name = "Phys";
            treeNode17.Text = "Кафедра физического воспитания и спорта";
            treeNode18.Name = "Instructors";
            treeNode18.Text = "Преподаватели";
            treeNode19.Name = "Subjects";
            treeNode19.Text = "Предметы";
            treeNode20.Name = "Узел15";
            treeNode20.Text = "Узел15";
            treeNode21.Name = "Узел16";
            treeNode21.Text = "Узел16";
            treeNode22.Name = "Узел17";
            treeNode22.Text = "Узел17";
            treeNode23.Name = "Views";
            treeNode23.Text = "Готовые представления";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode18,
            treeNode19,
            treeNode23});
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
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(966, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menu";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.DataGridView tableView;
        private System.Windows.Forms.MenuStrip menu;

    }
}

