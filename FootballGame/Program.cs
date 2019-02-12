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

            var randomNumber = new Random();

            #region Team Fairfield
            for (int downs = 1; downs < 4; downs++) {                
                int yards = randomNumber.Next(-5, 10);
                TotalYards += yards;
                DownYards += yards;
                
                if (TotalYards >= 100) {
                    DownYards = 0;
                    downs = 0;
                    Score += 7;
                    TotalYards = 90;
                    Console.WriteLine($"Fairfield scored {Score}");
                    break;
                }

                if (DownYards < 10) {
                    Console.WriteLine($"Play resulted in {yards} yards.");
                    Console.WriteLine($"{downs + 1} Down and {10 - DownYards} yards to go.");
                }
                else {
                    Console.WriteLine($"Play resulted in {yards} yards.");
                    Console.WriteLine($"First Down INDIANS!! {100 - TotalYards} yards to goal line.");
                     DownYards = 0;
                     downs = 0;
                }

                if (downs < 4) {
                    //Do Nothing
                }
                else {
                    Console.WriteLine("TurnOver on Downs");
                    break;
                }
                                

            }Console.ReadKey();
            #endregion
        }
    }

}