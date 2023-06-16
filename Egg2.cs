using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{     
    class Egg2
    {
        
        string symbol = "O";
        public void WriteEgg(int e, int h)
        {
            Console.SetCursorPosition(e, h);
            Console.Write(symbol);

            Console.SetCursorPosition(e + 1, h);
            Console.Write(symbol);

            Console.SetCursorPosition(e, h + 1);
            Console.Write(symbol);

            Console.SetCursorPosition(e + 1, h + 1);
            Console.Write(symbol);

        }

        
    }
}
