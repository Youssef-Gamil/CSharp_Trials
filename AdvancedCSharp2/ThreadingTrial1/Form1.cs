using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingTrial1
{
    public partial class Form1 : Form
    {
        class MyClass
        {
            int x;
            string txt;

            public int X { get => x; set => x = value; }
            public string Txt { get => txt; set => txt = value; }

            public MyClass(int x_, string txt_)
            {
                x = x_;
                txt = txt_;
            }
        }
        public Form1()
        {
            InitializeComponent();
            //creating a new thread to run ABC() (run functions asynchronously)
            Thread t = new Thread(ABC);
            //to start the thread.
            t.Start(new MyClass(5, "Youssef"));
            //To wait until t finishes the continue (convert from async functions to sync.)
            //t.Join();
            Func<Int64> func = MyFunc;
            IAsyncResult ia = func.BeginInvoke(test1, null);
            //Int64 x = func.EndInvoke(ia);
            //MessageBox.Show(x.ToString());
            MessageBox.Show("Main Thread");
        }

        //This a callback function that will be called after the end of the thread.
        private void test1(IAsyncResult ar)
        {
            AsyncResult ab = (AsyncResult)ar;
            Func<Int64> t1 = (Func < Int64 >) ab.AsyncDelegate;
            Int64 x = t1.EndInvoke(ar);
            MessageBox.Show(x.ToString());
        }

        private void ABC(object classX)
        {
            MyClass x = (MyClass)classX;
            for (int i = 0; i < 9990000; i++)
            {

            }
            MessageBox.Show("Hello " + x.Txt);
        }
        private Int64 MyFunc()
        {
            Int64 counter = 0;
            for (int i = 0; i < 999000000; i++)
            {
                counter++;
            }
            return counter;
        }
    }
}
