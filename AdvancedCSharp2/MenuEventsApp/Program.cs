namespace MenuEventsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Items = new List<string>();
            Items.Add("Hi");
            Items.Add("Welcome");
            Items.Add("Exit");

            Menu m = new Menu(Items, ConsoleColor.Green, ConsoleColor.Red);
            m.PressEnter += M_PressEnter;
            m.Show();
        }

        private static void M_PressEnter(object sender, MyEventArgs e)
        {
            switch (e.Current)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("Hi");
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("Welcome");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Exit");
                    e.IsExit = true;
                    break;
            }
        }
    }
}