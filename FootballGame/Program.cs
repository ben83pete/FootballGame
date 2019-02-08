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
            Console.WriteLine("FootBall Game - First to 21");

            int Downs = 0;
            int DownYards = 0;
            //int TotalYards = 0;
            
            Random randomNumber = new Random();
            int  yards = randomNumber.Next(1, 10);
            Downs++;

            if (Downs < 4)
            {
                DownYards += yards;
            }
            else Console.WriteLine("TurnOver on Downs");

            if (DownYards < 10)
            {
                DownYards += yards;
            }


            
            Console.Write($"Random # = {yards} ");


            //var int DownYards;

            //for (var counter = 0; counter < 10; counter++)
            //{
            //    DownYards = 
            //}
            
        }



                 

        //    //int TeamScore;
        //    //int TotalYards;
        //    //int DownYards;

            
            
        //    Random rnd = new Random();
        //    int BestTotal = 0;
        //    int BestRolls = 0;
        //    int counter = 0;
        //    int gp = 0;
        //    long GamesToPlay = 10000000000;

                                 
        //    while (counter++ < GamesToPlay)
        //    {
        //        int Yards = 0;
        //        int Rolls = 0;
        //        int Die = 0;

        //        do
        //        {
        //            DownYards += Die;
        //            Die = rnd.Next(10) + 1;
        //            if( DownYards >= 10)
        //            {
        //                Rolls++;
        //            }
                    
        //        }

        //        while()



        //        if (Total > BestTotal)
        //        {
        //            BestTotal = Total;
        //            BestRolls = Rolls;
        //            Console.WriteLine($"Score: {BestTotal} in {BestRolls} rolls. Played Games: {counter}");
        //        }
        //        //continue;



        //    }

        //    Console.ReadKey();


        //}
    }
}

   
