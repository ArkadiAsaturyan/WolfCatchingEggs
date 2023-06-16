using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp6
{

    class Egg
    {
        Random rnd = new Random();


        public int HeightPosition { get; set; } = 1;
        string symbol = "O";
        int index = 1;
        int eggCycle = 0;
        int randomCycle = 0;
        int[] arr = { 24, 50, 76 };
        public int EggPosition { get; private set; } = 50;
        public int FinalPoint { get; private set; } = 0;
        
        public void EggShape(int e)
        {
            Console.SetCursorPosition(e, HeightPosition);
            Console.Write(symbol);

            Console.SetCursorPosition(e + 1, HeightPosition);
            Console.Write(symbol);

            Console.SetCursorPosition(e, HeightPosition + 1);
            Console.Write(symbol);

            Console.SetCursorPosition(e + 1, HeightPosition + 1);
            Console.Write(symbol);

        }

        void ClearLine()
        {
            Console.SetCursorPosition(arr[index], HeightPosition);
            Console.Write("  ");
        }

        void ClearEgg()
        {
            Console.SetCursorPosition(arr[index], HeightPosition);
            Console.Write("  ");
            Console.SetCursorPosition(arr[index], HeightPosition + 1);
            Console.Write("  ");
        }
        public void EggMove(Wolf wolf, Life life, Score score)
        {
            int speed = 80;
            int pointReward = 10;
            randomCycle = rnd.Next(5, 20);

            
            while (eggCycle != randomCycle && life.Points >= 0)
            {
                FinalPoint = score.Points;
                
                wolf.WolfControl(wolf);
                score.ShowPoints();
                life.ShowPoints();
                ClearEgg();

                HeightPosition++;
                EggShape(arr[index]);
                Thread.Sleep(speed);

                if (HeightPosition == 20)
                {
                    if (arr[index] == wolf.Position)
                    {
                        score.Points += pointReward;
                        Console.Beep(1200, 55);
                        eggCycle++;
                    }

                    else
                    {
                        life.Points--;
                        Console.Beep(400, 55);
                        

                    }

                    ClearEgg();
                    HeightPosition = 1;
                    index = rnd.Next(3);

                    if (score.Points == 100)
                    {
                        speed -= 30;
                        pointReward = 25;
                    }

                    else if (score.Points == 300)
                    {
                        speed -= 20;
                        pointReward = 50;
                    }
                    else if (score.Points == 1000)
                    {
                        speed -= 10;
                        pointReward = 100;

                    }

                    else if (score.Points == 5000)
                    {
                        speed -= 5;
                        pointReward = 200;
                    }
                }
            }
            wolf.ClearWolf(wolf);
            
        }
    }
}