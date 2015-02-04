using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1000
{
    class Program
    {
        static void Main(string[] args)
        {
            ThrowDice("10d6");
            ThrowDice("3d20");
            ThrowDice("100d6");

            Console.ReadKey();
        }

        /// <summary>
        /// This function roll a dice 
        /// </summary>
        /// <param name="input">input string formatted with Dice Notation</param>
        public static void ThrowDice(string input)
        {
            //split the tring in two
            string[] splittedInput = input.Split('d');
            Random rng = new Random();
            string output=string.Empty;

            //check if the string is formatted well
            if (splittedInput.Length == 2)
            {
                //loop to roll the dice
                for (int i = 0; i < int.Parse(splittedInput[0]) ; i++)
                {
                  //add to the output string the result of the rolled dice  
                  output += rng.Next(1, int.Parse(splittedInput[1] )+1).ToString()+" ";
                }
                
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.WriteLine("throwing: " + input);
            Console.WriteLine("Results: "+ output);
        }
    }
}
