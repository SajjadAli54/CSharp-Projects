using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class frmStopWatch : Form
    {
        int hr = 0, min = 0, sec = 0;
        public frmStopWatch()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            increase();
            txtHour.Text = hr + " : ";
            txtMinutes.Text = min + " : ";
            txtSeconds.Text = sec + "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                btnStart.Text = "Start";
                timer.Enabled = false;
            }
            else
            {
                btnStart.Text = "Pause";
                timer.Enabled = true;
            }
        }

        private void increase()
        {
            sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;
            }
            if (min == 60)
            {
                min = 0;
                hr++;
            }
                
        }
    }
}
