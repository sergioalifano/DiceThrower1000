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

        public static void ThrowDice(string input)
        {
            string[] splittedInput = input.Split('d');
            Random rng = new Random();
            string output=string.Empty;

            if (splittedInput.Length == 2)
            {
                for (int i = 0; i < int.Parse(splittedInput[0]) ; i++)
                {
                  output+=rng.Next(1, int.Parse(splittedInput[1] )+1).ToString()+" ";
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.WriteLine("throwing: "+input);
            Console.WriteLine("Results: "+output);
        }
    }
}
