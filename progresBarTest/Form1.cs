using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progresBarTest
{
    public partial class Form1 : Form
    {
        Timer Timer;
        int timercount = 0;

        public Form1()
        {
            InitializeComponent();
            Timer = new Timer();
            Timer.Interval = 1000;
            Timer.Tick += new EventHandler(timer_Tick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();

            // 타이머 중지 조건
            if (++timercount == 10)
            {
                Timer.Stop();
            }
        }
    }
}
