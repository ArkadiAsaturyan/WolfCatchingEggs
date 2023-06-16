using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp6
{
    class Logic
    {
        public int Points { get; set; } = 3;

        public void GameLogic()
        {
            
        int recordPoint = 0;            

            
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();


            Menu menu = new Menu();
            menu.ControlMenu();

        GotoPoint:
            Borders borders = new Borders();
            borders.setBorders();

            Life life = new Life();
            life.ShowPoints();

            Score score = new Score();
            score.ShowPoints();

            Wolf wolf = new Wolf();
            
            wolf.WolfShape(wolf.Position);



            Egg egg = new Egg();
            Bomb bomb = new Bomb();
            

            

            while (life.Points >= 0)
            { 
                 
                egg.EggMove(wolf,life, score);

                if (life.Points == 0) break;
                
               // bomb.ThrowBomb(wolf);
            }







            Console.Clear();
            if (egg.FinalPoint > recordPoint)
            {
                recordPoint = egg.FinalPoint;
                
            }

            Console.SetCursorPosition(50, 9);
            Console.WriteLine("Your Score Is: " + egg.FinalPoint);

            Console.SetCursorPosition(50, 11);
            Console.WriteLine("Record Is: " + recordPoint);

            Console.SetCursorPosition(50, 13);
            Console.WriteLine("Press ESC To Quit The Game");

            Console.SetCursorPosition(50, 15);
            Console.WriteLine("Press ENTER To Start The Game");

            Console.SetCursorPosition(0, 25);
            cki = Console.ReadKey(true);

            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                Console.Clear();
                goto GotoPoint;


            }

            else if (Console.ReadKey(true).Key == ConsoleKey.Escape) { Console.Clear(); }



        }
    }
}
