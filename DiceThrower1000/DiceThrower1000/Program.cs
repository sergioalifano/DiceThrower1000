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
            ThrowDice("3d4 7d5 10d3");

            Console.ReadKey();
        }

        /// <summary>
        /// This function roll a dice 
        /// </summary>
        /// <param name="input">input string formatted with Dice Notation</param>
        public static void ThrowDice(string input)
        {  
            //split the string for multiple dices
             string[] splitSpace = input.Split();

            //loop for the amount of dices
            for (int i = 0; i < splitSpace.Length; i++)
            {
                //call the function that roll the dices
                RollTheDice(splitSpace[i]);
            }
           

        }
        public static void RollTheDice(string DiceNotation)
        {
           
            Random rng = new Random();
            string output = string.Empty;

            int sum = 0;
            int randomNumber;

            //split the string in two
            string[] splitNotation = DiceNotation.Split('d');

            //loop to roll the dice
            for (int i = 0; i < int.Parse(splitNotation[0]); i++)
            {
                //generate a random number
                randomNumber = rng.Next(1, int.Parse(splitNotation[1]) + 1);
                //keep track of the sum of the nummber generated
                sum += randomNumber;
                //add to the output string the result of the rolled dice   
                output += randomNumber.ToString() + " ";
            }

            Console.WriteLine("Throwing: " + DiceNotation);
            Console.WriteLine("Results: " + output);
            Console.WriteLine("The average roll is {0} ", Convert.ToDouble(sum) / Convert.ToDouble(int.Parse(splitNotation[0])));
            Console.WriteLine();

        }
    }
}
