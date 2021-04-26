using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = string.Empty;
            StringBuilder userInputReverse = new StringBuilder();
            Console.WriteLine("Enter Input: ");
            userInput = Console.ReadLine();           
           for(int i = 0; i <= userInput.Length -1; i++)
            {
                userInputReverse.Append(userInput[(userInput.Length-1)-i]);
            }
            Console.WriteLine("Reversed Input: " + userInputReverse.ToString());
            Console.ReadLine();

        }
    }
}
