using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MenuEventsApp
{
    class MyEventArgs : EventArgs
    {
        int current;
        bool isExit;

        public MyEventArgs(int _current)
        {
            current = _current;
            isExit = false;
        }

        public int Current { get => current; set => current = value; }
        public bool IsExit { get => isExit; set => isExit = value; }
    }
   // delegate void Mydelegate(object sender, MyEventArgs e);
    internal class Menu
    {
        List<string> menuItems = new List<string>();
        ConsoleColor hbackcolor;
        ConsoleColor hforecolor;
        ConsoleColor forecolor;
        ConsoleColor backcolor;
        int x;
        int y;
        int current;
        public event EventHandler<MyEventArgs> PressEnter;

        public Menu(List<string> _menuItems, ConsoleColor _hbackcolor, ConsoleColor _hforecolor, ConsoleColor _forecolor, ConsoleColor _backcolor, int _x, int _y)
        {
            menuItems = _menuItems;
            hbackcolor = _hbackcolor;
            hforecolor = _hforecolor;
            forecolor = _forecolor;
            backcolor = _backcolor;
            x = _x;
            y = _y;
            current = 0;
            PressEnter = OnPressEnter;
        }
        public Menu(List<string> _menuItems, ConsoleColor _hbackcolor, ConsoleColor _hforecolor) : this(_menuItems, _hbackcolor, _hforecolor, ConsoleColor.White, ConsoleColor.Black, 10, 10)
        {
        }

        void Draw()
        {
            for (int i = 0; i < menuItems.Count; i++)
            {
                Console.SetCursorPosition(x, y + i);
                if (current == i)
                {
                    Console.BackgroundColor = hbackcolor;
                    Console.ForegroundColor = hforecolor;
                }
                else
                {
                    Console.BackgroundColor = backcolor;
                    Console.ForegroundColor = forecolor;
                }
                Console.Write(menuItems[i]);
            }
            Console.ResetColor();
        }
        public void Show()
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            MyEventArgs abc = new MyEventArgs(current);
            do
            {
                Draw();
                cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow:
                        current--;
                        if (current < 0)
                        {
                            current = menuItems.Count - 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        current++;
                        if (current >= menuItems.Count)
                        {
                            current = 0;
                        }
                        break;
                    case ConsoleKey.Home:
                        current = 0;
                        break;
                    case ConsoleKey.End:
                        current = menuItems.Count-1;
                        break;
                    case ConsoleKey.Escape:
                        abc.IsExit = true;
                        break;
                        case ConsoleKey.Enter:
                        abc = new MyEventArgs(current);
                        PressEnter(this, abc);
                        break;
                }
                
            } while(!abc.IsExit);
        }

        void OnPressEnter(object sender, MyEventArgs e)
        {

        }
    }
}
