using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ICS_MSHRC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var conn = new SQLiteConnection("Data Source=C:\\Users\\Тимми\\Desktop\\MSHRC.db"))
            {
                conn.Open();
                var cmd = new SQLiteCommand("select * from Students", conn);
                var da = new SQLiteDataAdapter(cmd);
                var ds = new DataSet();
                da.Fill(ds, "Students");
                dataGridView1.DataSource = ds.Tables["Students"];
                ds.Dispose();
                da.Dispose();
            }
        }
    }
}
