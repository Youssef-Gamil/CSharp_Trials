namespace AdvancedCSharp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Items = new List<string>();
            Items.Add("Hi");
            Items.Add("Hello");
            Items.Add("Hola");
            Menu myMenu = new Menu(Items, ConsoleColor.Green, ConsoleColor.Red);
            myMenu.PressEnter += MyMenu_PressEnter;
            myMenu.Show();
        }

        private static void MyMenu_PressEnter(object sender, MyEventArgs e)
        {
            switch (e.Current)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("Hi");
                    e.IsExit = false; 
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("Hello");
                    e.IsExit = false;
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