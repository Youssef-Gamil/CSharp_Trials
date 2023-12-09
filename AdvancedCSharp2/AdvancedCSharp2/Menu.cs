using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp2
{
    class MyEventArgs : EventArgs
    {
        int current;
        bool isExit;

        public int Current { get => current; set => current = value; }
        public bool IsExit { get => isExit; set => isExit = value; }

        public MyEventArgs(int index) 
        {
            current = index;
            isExit = false;
        }
    }
    delegate void MyDelegate(object sender, MyEventArgs e);

    internal class Menu
    {
        public event MyDelegate PressEnter;
        List<string> menuItems;
        ConsoleColor hbackcolor;
        ConsoleColor hforecolor;
        ConsoleColor backcolor;
        ConsoleColor forecolor;
        int x;
        int y;
        int current;

        public Menu(List<string> _menuItems, ConsoleColor _hbackcolor, ConsoleColor _hforecolor, ConsoleColor _backcolor, ConsoleColor _forecolor, int _x, int _y)
        {
            PressEnter = OnPressEnter;
            menuItems = _menuItems;
            hbackcolor = _hbackcolor;
            hforecolor = _hforecolor;
            backcolor = _backcolor;
            forecolor = _forecolor;
            x = _x;
            y = _y;
            current = 0;
        }

        public Menu(List<string> _menuItems, ConsoleColor _hbackcolor, ConsoleColor _hforecolor) : this(_menuItems, _hbackcolor, _hforecolor, ConsoleColor.Black, ConsoleColor.White, 10, 10)
        { }
        private void Draw()
        {
            for (int i = 0; i < menuItems.Count; i++)
            {
                if (i==current)
                {
                    Console.BackgroundColor = hbackcolor;
                    Console.ForegroundColor = hforecolor;
                }
                else
                {
                    Console.BackgroundColor = backcolor;
                    Console.ForegroundColor = forecolor;
                }
                Console.SetCursorPosition(x, y+i);
                Console.Write(menuItems[i]);
            }
            Console.ResetColor();
        }
        public void Show()
        {
            ConsoleKeyInfo cki;
            MyEventArgs abc = new MyEventArgs(current);
            do
            {
                Draw();
                cki = Console.ReadKey(true);
                switch(cki.Key) 
                {
                    case ConsoleKey.Enter:
                        abc = new MyEventArgs(current);
                        PressEnter(this, abc);
                        break;
                    case ConsoleKey.Escape:
                        break;
                    case ConsoleKey.DownArrow:
                        current++;
                        if (current == menuItems.Count)
                        {
                            current = 0;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        current--;
                        if (current < 0)
                        {
                            current = menuItems.Count-1;
                        }
                        break;
                    case ConsoleKey.Home:
                        current = 0;
                        break;
                    case ConsoleKey.End:
                        current = menuItems.Count-1;
                        break;
                }
            } while (!abc.IsExit);    
        }
        private void OnPressEnter(object sender, MyEventArgs e)
        {
        }
    }
}
