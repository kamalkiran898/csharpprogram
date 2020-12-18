using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DIGITAL_CLOCK_0548
{
    public partial class digital_clock : Form
    {
        private Stopwatch stopwatch;
        System.Timers.Timer timer1;
        public digital_clock()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer_tick.Text = DateTime.Now.ToString("T");
            this.label1.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopwatch.Elapsed);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            timer1 = new System.Timers.Timer();
            timer1.Interval = 1000;
            timer1.Elapsed += Timer_Elapsed;
            stopwatch = new Stopwatch();
        }

        delegate void updatelabel(Label label, string value);
        void updatedatalabel(Label label,string value)
        {
            label.Text = value;
        }
            
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;
            if (currentTime.Hour == userTime.Hour && currentTime.Millisecond == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer1.Stop();
                try
                {
                    updatelabel upd = updatedatalabel;
                    if(label_status.InvokeRequired)
                    {
                        Invoke(upd,label_status,"stop");
                    }

                    MessageBox.Show("wake up!");

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void color_btn_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                timer_tick.BackColor = colorDialog1.Color;
            }
        }

        private void alarm_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label_status.Text = "running !!!!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label_status.Text = "stop";
        }

        private void startstp_btn_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
        }

        private void button_pausebtn_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void button_resetstpwatch_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }
    }
}
