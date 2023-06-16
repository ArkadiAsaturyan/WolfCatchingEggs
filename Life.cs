using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Life
    {
        public int Points { get; set; } = 3;
        public void ShowPoints()
        {
            Console.SetCursorPosition(110, 4);
            Console.Write("Life ♥ ");
            Console.SetCursorPosition(110, 5);
            Console.Write(Points);
        }
    }
}
