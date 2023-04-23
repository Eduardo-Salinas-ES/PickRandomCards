using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            int numOfCards;
            

            Console.Write("Hello there, Enter a number of cards to generate: ");

            line = Console.ReadLine();

            if(int.TryParse(line, out numOfCards))
            {
                // CardPicker.PickSomeCards(numOfCards) returns a string array that contains our cards
                // so here we display each card in the array of cards
                foreach (string card in CardPicker.PickSomeCards(numOfCards))
                {
                    Console.WriteLine(card);
                }
                
            }
            else
            {
                Console.WriteLine("The number you entered is invalid.");
            }

            Console.ReadLine();







        }
    }
}
