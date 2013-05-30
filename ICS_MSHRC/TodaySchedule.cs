using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ICS_MSHRC
{
    public partial class TodaySchedule : Form
    {
        public TodaySchedule()
        {
            InitializeComponent();
            scheduleView.DataSource = DBProvider.TodaySchedule();
        }
    }
}
