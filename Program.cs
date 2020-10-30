using System;
using System.Linq;

namespace ConsoleMenu
{
    class Program
    {
        static string MENU(string[] menu)
        {
            int left = 0;
            int top = 0;
            int cursor = 0;
            ConsoleKey k = ConsoleKey.A;
            while (k != ConsoleKey.Escape)
            {
                Console.CursorTop = top;
                for (int i = 0; i < menu.Count(); i++)
                {
                    if (cursor == i)
                    {
                        Console.CursorLeft = left;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"=> {menu[i],-14} <=");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.CursorLeft = left;
                        Console.WriteLine($"   {menu[i],-14}   ");
                    }
                }
                k = Console.ReadKey().Key;
                if (k == ConsoleKey.DownArrow)
                {
                    cursor++;
                    if (cursor > menu.Count() - 1)
                        cursor = 0;
                }
                if (k == ConsoleKey.UpArrow)
                {
                    cursor--;
                    if (cursor < 0)
                        cursor = menu.Count() - 1;
                }
                if (k == ConsoleKey.Enter)
                {
                    Console.Clear();
                    return menu[cursor];
                }
            }
            return "exit";
        }
        enum Menu
        {
            Hello, World, People, Congratulation
        }
        static void Main(string[] args)
        {
            String[] menu = { "Hello", "World", "People", "Congratulation" };
            var res = MENU(menu);
            Menu m = (Menu)Enum.Parse(typeof(Menu), res/*, ignoreCase: true*/);

            switch (m)
            {
                case Menu.Hello:
                    break;
                case Menu.World:
                    break;
                case Menu.People:
                    break;
                case Menu.Congratulation:
                    break;
                default:
                    break;
            }
        }
    }
}