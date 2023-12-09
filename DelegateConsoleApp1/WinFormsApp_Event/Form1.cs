namespace WinFormsApp_Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myButton1.Click += MyButton1_Click; //event chaining
            myButton2.Click += MyButton1_Click;
        }

        private void MyButton1_Click(object sender, EventArgs e) //function added to onClick function.
        {
           // MessageBox.Show("Hi");
           MyButton b = (MyButton)sender;
            b.Text = "Hiii";
        }
    }
}