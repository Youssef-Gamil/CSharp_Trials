
namespace Threading
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
            //To wait until t finishes the continue (con*vert from async functions to sync.)
            //t.Join();
            Func<string,Int64> func = MyFunc;
            IAsyncResult ia = func.BeginInvoke("Youssef",null,null);
            Int64 x = func.EndInvoke(ia);
            MessageBox.Show(x.ToString());
            MessageBox.Show("Main Thread");
        }

        private void ABC(object classX)
        {
            MyClass x = (MyClass) classX;
            for (int i = 0; i < 999000000; i++)
            {

            }
            MessageBox.Show("Hello "+x.Txt);
        }

        private Int64 MyFunc(string name)
        {
            Int64 counter = 0;
            for (int i = 0; i < 999000000; i++)
            {
                counter++;
            }
            MessageBox.Show(name);
            return counter;
        }
    }
}