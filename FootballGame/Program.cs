using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame

    {
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("FootBall Game - First to 21");

            int Downs = 0;
            int DownYards = 0;
            int TotalYards = 90;
            int Score = 0;
            
            Random randomNumber = new Random();
                       
                        
            for (int downs = 0; downs < 4; downs++)
            {
                int yards = randomNumber.Next(0, 10);
                Downs++;                               
                TotalYards += yards;

                if (TotalYards >= 100)
                {
                    DownYards = 0;
                    Downs = 0;
                    Score += 7;
                    TotalYards = 90;
                    Console.WriteLine($"Team A scored {Score}");
                    continue;
                }
                else
                {
                    Console.WriteLine($"{Downs + 1} and {(10 - DownYards) - yards} to go.");
                }


                if (Downs < 4)
                {       // Do nothing           
                }
                else Console.WriteLine("TurnOver on Downs");
                ;


                if (DownYards < 10)
                {
                    DownYards += yards;   // ---go back to random #
                }
                else
                {
                    Console.WriteLine($"First Down and {100 - TotalYards} to goal line.");
                    DownYards = 0;
                    Downs = 0;
                    
                }
                               
            }            
        }           
    }       
}

   
