using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
     class Score
    {
        public int Points { get; set; }
        
        public void ShowPoints()
        {
            Console.SetCursorPosition(110, 0);
            Console.WriteLine("Score");
            Console.SetCursorPosition(110, 1);
            Console.WriteLine(Points);
        }
    }
}
