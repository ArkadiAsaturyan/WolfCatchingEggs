using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp6
{
     class Bomb
    {  
        Wolf wolf=new Wolf();
        Random random = new Random();
        int count = 0;

        char s = '*';
        int bombPosition = 76;
        int heightposition = 1;
        int[] arrBombPosition = { 24, 50, 76 };
        int index = 2;
        public void BombShape(int bombPosition)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.SetCursorPosition(bombPosition, heightposition);
            Console.Write(s);

            Console.SetCursorPosition(bombPosition+1, heightposition);
            Console.Write(s);

            Console.SetCursorPosition(bombPosition-1, heightposition+1);
            Console.Write(s);

            Console.SetCursorPosition(bombPosition, heightposition+1);
            Console.Write(s);

            Console.SetCursorPosition(bombPosition+1, heightposition+1);
            Console.Write(s);

            Console.SetCursorPosition(bombPosition+2, heightposition+1);
            Console.Write(s);

            Console.SetCursorPosition(bombPosition, heightposition+2);
            Console.Write(s);

            Console.SetCursorPosition(bombPosition+1, heightposition+2);
            Console.Write(s);
                                   
            Console.ForegroundColor = ConsoleColor.Black;


        }

        void EraseBomb()
        {
            Console.SetCursorPosition(arrBombPosition[index], heightposition);
            Console.Write(' ');

            Console.SetCursorPosition(arrBombPosition[index] + 1, heightposition);
            Console.Write(' ');

            Console.SetCursorPosition(arrBombPosition[index] - 1, heightposition + 1);
            Console.Write(' ');

            Console.SetCursorPosition(arrBombPosition[index], heightposition + 1);
            Console.Write(' ');

            Console.SetCursorPosition(arrBombPosition[index] + 1, heightposition + 1);
            Console.Write(' ');

            Console.SetCursorPosition(arrBombPosition[index] + 2, heightposition + 1);
            Console.Write(' ');

            Console.SetCursorPosition(arrBombPosition[index], heightposition + 2);
            Console.Write(' ');

            Console.SetCursorPosition(arrBombPosition[index] + 1, heightposition + 2);
            Console.Write(' ');
        }

        public void ThrowBomb(Wolf w)
        {                       
            while (count!=3)
            {   
                wolf.WolfControl(w);
                EraseBomb();
                heightposition++;
                BombShape(arrBombPosition[index]);
                Thread.Sleep(100);

                if (heightposition == 19)
                {
                    EraseBomb();
                    index = random.Next(2);
                    heightposition = 1;
                    count++;
                }
                
            }
            wolf.ClearWolf(wolf);
            
        }

    }
}
