using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingTrial2
{
    public partial class Form1 : Form
    {
        BackgroundWorker bw;
        public Form1()
        {
            InitializeComponent();
            bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
            bw.RunWorkerAsync();
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            textBox2.Text = "Hi Youssef";
            bw.RunWorkerAsync();
        }

        //This is an extention for DoWork Event, that executed when thread started.
        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            bool flag = true;
            do
            {
                if (textBox1.Text == "Youssef")
                {
                    flag = false;
                }
            } while (flag);
        }
    }
}
