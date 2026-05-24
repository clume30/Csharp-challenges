
using System;
using System.Linq;

namespace Challenge3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=====Welcome to Clume's Company====="); // displays a welcome message to the screen
            Console.Write("What is your status in the Company: "); // prompts the user for his status in the company
            string status = Console.ReadLine(); // inserts it in variable status 
            string status1 = status.ToLower();

            // if the user is a worker 
            if (status1.Contains("worker"))
            {
                Console.WriteLine("Sorry, you do not have sufficient priviledges");
            }
            // if the user is an admin
            else if (status1.Contains("admin"))
            {
                Console.Write("Please what level are you in this company: ");
                int level = int.Parse(Console.ReadLine());
                if (level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user");
                }
                else if (level <= 55)
                {
                    Console.WriteLine("Welcome Admin user");
                }
            }
            // if the user is a manager
            else if (status1.Contains("manager"))
            {
                Console.Write("Please what is your level in this company: ");
                int level = int.Parse(Console.ReadLine());
                if (level >= 20)
                {
                    Console.WriteLine("Please contact an admin for access");
                }
                else if (level < 20)
                {
                    Console.WriteLine("Sorry you do not have sufficient priviledges");
                }
            }
        }
    }
}
