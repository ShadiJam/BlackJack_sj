using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_sj
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "Y";
            do {
            Console.WriteLine("Do you want to play BlackJack? (Y/N)");
            Console.ReadLine();
            response = Console.ReadLine();
                if (response.Equals("Y"))
                {
                    
                    //    Console.WriteLine("The dealer is shuffling! Remember, Aces are worth 11 points, not 1 point!");
                    //    deal userHand Card 1 (display card);
                    //    deal compHand Card 1 (display card);
                    //    deal userHand Card 2 (display card);
                    //    deal compHand Card 2 (hide card);
                    //    
                    //    call below Play.
                    //    Console.WriteLine("Your current score is (score). Would you like to stay or deal? (S/D)");
                    //    response2 = Console.ReadLine()
                    //    Console.ReadLine();
                    //    if (response2.Equals("S")); 
                    //    call countScore;

                    //    if else (response2.Equals("D")
                    //    deal userHand Card 2 (display card);
                    //    if compHand => 16
                    //    {
                    //    deal compHand Card 2 (hide card);
                    //    }
                    //    if else
                    //    do not deal to comp.
                    //    call countScore.
                    //    call Play.


                    // else { Console.WriteLine("I'm sorry, that is an incorrect response. Please type 'Y' or 'N'");

                }
                else if (response.Equals("N"))
                {
                    Console.WriteLine("Thank you for playing!");
                }
                else
                {
                    Console.WriteLine("I'm sorry, that is an incorrect response. Please type 'Y' or 'N'");
                } 
                

            }
        }
    }
}
    
           