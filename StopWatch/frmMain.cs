using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace StopWatch
{
    public partial class frmMain : Form
    {
        Stopwatch stopWatch;

        public frmMain()
        {
            InitializeComponent();
            stopWatch = new Stopwatch();
            this.timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.lblStopwatch.Text = string.Format("{0:mm\\:ss}", stopWatch.Elapsed);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }
    }
}
