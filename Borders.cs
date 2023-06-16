using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Borders
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Borders()
        {
            Width = 100;
            Height = 29;

        }
              
        public void setBorders()
        {

            for (int i = 1; i <= Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("═");
            }

            for (int i = 1; i <= Width; i++)
            {
                Console.SetCursorPosition(i, Height);
                Console.Write("═");
            }

            for (int i = 0; i <= Height; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("║");
            }

            for (int i = 0; i <= Height; i++)
            {
                Console.SetCursorPosition(Width, i);
                Console.Write("║");
            }

            Console.SetCursorPosition(20, 1);
            Console.Write("║");
            Console.SetCursorPosition(29, 1);
            Console.Write("║");

            Console.SetCursorPosition(46, 1);
            Console.Write("║");
            Console.SetCursorPosition(55, 1);
            Console.Write("║");

            Console.SetCursorPosition(72, 1);
            Console.Write("║");
            Console.SetCursorPosition(81, 1);
            Console.Write("║");

            Console.SetCursorPosition(1, 0);
            Console.Write("╔");

            Console.SetCursorPosition(1, Height);
            Console.Write("╚");

            Console.SetCursorPosition(Width, 0);
            Console.Write("╗");

            Console.SetCursorPosition(Width, Height);
            Console.Write("╝");


        }

    }
}
