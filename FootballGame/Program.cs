using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame {
    class Program {
        static void Main(string[] args) {
            //int Downs = 0;
            int DownYards = 0;
            int TotalYards = 70;
            int Score = 0;

            Random randomNumber = new Random();


            for (int downs = 1; downs < 4; downs++) {
                //Downs++;
                int yards = randomNumber.Next(0, 10);
                TotalYards += yards;

                if (DownYards < 10) {
                    DownYards += yards;   // ---go back to random #
                }
                else {
                    Console.WriteLine($"{downs + 1} and {(10 - DownYards) - yards} to go.");
                }

                if (downs < 4) {
                    //Do Nothing
                }
                else {
                    Console.WriteLine("TurnOver on Downs");
                    break;
                }

                if (TotalYards >= 100) {
                    DownYards = 0;
                    downs = 0;
                    Score += 7;
                    TotalYards = 90;
                    Console.WriteLine($"Fairfield scored {Score}");
                    break;
                }
                else {
                    Console.WriteLine($"First Down and {100 - TotalYards} to goal line.");
                    DownYards = 0;
                    downs = 0;
                }

            }
        
        }
    }

}