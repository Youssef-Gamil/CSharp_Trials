namespace DelegateConsoleApp1
{
    delegate void MyDelegateClass();
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegateClass m = ABC;
            m();
        }

        static void ABC()
        {
            Console.WriteLine("Hello from Delegate");
        }
    }
}