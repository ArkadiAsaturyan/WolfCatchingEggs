using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Wolf
    {
        Borders borders = new Borders();
        Score score = new Score();
        Egg egg = new Egg();

        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        public int Position { get; private set; } = 50;

        int step = 26;

        public void ClearWolf(Wolf w)
        {
            Console.SetCursorPosition(w.Position - 4, 21);
            Console.Write("          ");

            Console.SetCursorPosition(w.Position - 4, 22);
            Console.Write("          ");

            Console.SetCursorPosition(w.Position - 3, 23);
            Console.Write("        ");

            Console.SetCursorPosition(w.Position - 2, 24);
            Console.Write("      ");

            Console.SetCursorPosition(w.Position, 25);
            Console.Write("  ");

            Console.SetCursorPosition(w.Position, 26);
            Console.Write("  ");

            Console.SetCursorPosition(w.Position, 27);
            Console.Write("  ");

            Console.SetCursorPosition(w.Position, 28);
            Console.Write("  ");

        }
        
        public void WolfShape(int x)
        {
            // basket
            Console.SetCursorPosition(x - 4, 21);
            Console.Write("║");

            Console.SetCursorPosition(x + 5, 21);
            Console.Write("║");

            Console.SetCursorPosition(x - 4, 22);
            Console.Write("╚");

            Console.SetCursorPosition(x + 5, 22);
            Console.Write("╝");

            Console.SetCursorPosition(x - 3, 22);
            Console.Write("═");

            Console.SetCursorPosition(x - 2, 22);
            Console.Write("═");

            Console.SetCursorPosition(x - 1, 22);
            Console.Write("═");

            Console.SetCursorPosition(x, 22);
            Console.Write("═");

            Console.SetCursorPosition(x + 1, 22);
            Console.Write("═");

            Console.SetCursorPosition(x + 2, 22);
            Console.Write("═");

            Console.SetCursorPosition(x + 3, 22);
            Console.Write("═");

            Console.SetCursorPosition(x + 4, 22);
            Console.Write("═");

            Console.SetCursorPosition(x, 23);
            Console.Write("▲");

            Console.SetCursorPosition(x + 1, 23);
            Console.Write("▲");

            Console.SetCursorPosition(x - 1, 24);
            Console.Write("#");

            Console.SetCursorPosition(x, 24);
            Console.Write("õ");

            Console.SetCursorPosition(x + 1, 24);
            Console.Write("õ");

            Console.SetCursorPosition(x + 2, 24);
            Console.Write("#");

            Console.SetCursorPosition(x, 25);
            Console.Write("#");

            Console.SetCursorPosition(x + 1, 25);
            Console.Write("#");

            Console.SetCursorPosition(x, 26);
            Console.Write("#");

            Console.SetCursorPosition(x + 1, 26);
            Console.Write("#");

            // legs
            Console.SetCursorPosition(x, 27);
            Console.Write("/");

            Console.SetCursorPosition(x + 1, 27);
            Console.Write(@"\");

            Console.SetCursorPosition(x, 28);
            Console.Write("┘");

            Console.SetCursorPosition(x + 1, 28);
            Console.Write(@"└");

            // hands
            Console.SetCursorPosition(x + 3, 24);
            Console.Write("/");

            Console.SetCursorPosition(x - 2, 24);
            Console.Write(@"\");

            Console.SetCursorPosition(x + 4, 23);
            Console.Write("/");

            Console.SetCursorPosition(x - 3, 23);
            Console.Write(@"\");


            Console.SetCursorPosition(0, 0);


        }

        public void WolfControl(Wolf wolf)
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.LeftArrow && wolf.Position > 25)
                {
                    ClearWolf(wolf);
                    wolf.Position -= step;
                    WolfShape(wolf.Position);
                }

                else if (keyInfo.Key == ConsoleKey.RightArrow && wolf.Position < 75)
                {                    
                        ClearWolf(wolf);
                        wolf.Position += step;
                        WolfShape(wolf.Position);                    
                }
            }
        }
    }
}
