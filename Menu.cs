using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Menu
    {
        public void ControlMenu()
        {
            Console.SetCursorPosition(58, 7);
            Console.WriteLine("GAME");
            Console.SetCursorPosition(53, 9);
            Console.WriteLine("Catch The Egg");

            Console.SetCursorPosition(45, 20);
            Console.WriteLine("Press ENTER to start the game");

            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;

            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
            Console.Clear();
        }


    }

}
