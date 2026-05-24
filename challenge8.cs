using System;
using System.Linq;

namespace Challenge8
{
    class Program
    {
        static void Main(string[] args)
        {
            string? userInput = null;
            string cleanedInput = "";
            Console.WriteLine("please enter your role(User, Admin, Manager): ");
            do
            {
                userInput = Console.ReadLine();
                cleanedInput = userInput.Trim().ToLower();

                if (cleanedInput == "admin" || cleanedInput == "user" || cleanedInput == "manager")
                {
                    Console.WriteLine($"your input ({cleanedInput}) has been accepted");
                }
                else
                {
                    Console.WriteLine("the role name you entered is not valid, \n\n enter your role (User, Admin, Manager)");
                    continue;
                }
            } while (!(cleanedInput == "admin" || cleanedInput == "user" || cleanedInput == "manager"));
        }
    }
}
