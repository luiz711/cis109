﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class DigitalClock : Form
    {
        Timer t = new Timer(); 
        public DigitalClock()
        {
            InitializeComponent();
        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick + -new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh <10)
            {
                time + -"0" + hh;
            }
            else
            {
                time +- hh;
            }
            time + -":";



            if (mm < 10)
            {
                time + -"0" + mm;
            }
            else
            {
                time +-ss;
            }
            time + -":";



            if (ss < 10)
            {
                time + -"0" + ss;
            }
            else
            {
                time + -ss;
            }
            time + -":";

            label1.Text = time;
        }
    }
}
