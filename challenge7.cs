using System;
using System.Linq;

namespace challenge7
{
    class Program
    {
        static void Main(string[] args)
        {
            string? userInput = null;
            int result = 0;
            Console.WriteLine("Enter an integer between 5 and 10");
            while (!(result > 5 && result < 10))
            {
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out result))
                {
                    Console.WriteLine("you have successfully input an integer");
                }
                else
                {
                    Console.WriteLine("invalid input, Please enter whole numbers\n\n try again");
                    continue;
                }
                // testing the whole number if it reeached the requirements
                if (result > 5 && result < 10)
                {
                    Console.WriteLine("we have received your request");
                }
                else
                    Console.WriteLine("whole number must be greater than 5 and less than 10!!!\n\n try again");
                    continue;
            }
            
        }
    }
}
