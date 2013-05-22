﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
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
            //tableView.DataSource = DBProvider.Students();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "Students")
            {
                tableView.DataSource = DBProvider.Students();
                return;
            }
            if (e.Node.Name == "Instructors")
            {
                tableView.DataSource = DBProvider.Instructors();
                return;
            }
            if (e.Node.Name == "Subjects")
            {
                tableView.DataSource = DBProvider.Subjects();
                return;
            }
            if (e.Node.Name == "Views")
                return;
            if (e.Node.Parent.Name == "Students")
            {
                tableView.DataSource = DBProvider.Students(e.Node.Text);
                return;
            }
            if (e.Node.Parent.Name == "Radio")
            {
                tableView.DataSource = DBProvider.Students(e.Node.Index + 1);
                return;
            }
            if (e.Node.Parent.Name == "Electr")
                tableView.DataSource = DBProvider.Students(e.Node.Index + 3);
        }
    }
}