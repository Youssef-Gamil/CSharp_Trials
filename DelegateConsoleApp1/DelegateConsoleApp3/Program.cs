namespace DelegateConsoleApp3
{
    delegate void MyDelegate();
    class Test
    {
        public event MyDelegate lll;

        public Test()
        {
            lll = ABC;
        }
        private void ABC()
        {
            Console.WriteLine("ABC");
        }
        public void FireEvent()
        {
            lll();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
                Test T = new Test();
            T.lll += KKK;
                T.FireEvent();
        }

        static void KKK()
            {
                Console.WriteLine("KKK");
            }
    }
}