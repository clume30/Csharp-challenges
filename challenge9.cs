// you haven't finished the adding of new pets yet it still needs an update
using System;
using System.Linq;
using System.Collections.Generic;

namespace Challenge9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] petID = { "CP001", "CP002", "CP003", "CP004" };
            string[] genFunction = new string[4];

            // CP001
            string[] function1 = { "DOG", "1year", "Medium sized", "Skubby" };

            // CP002
            string[] function2 = { "CAT", "12years", "large sized", "Her Majesty" };

            // CP003
            string[] function3 = { "DOG", "5years", "large sized", "The Shadow" };

            // CP004
            string[] function4 = { "CAT", "3years", "medium sized", "Spooky" };

            Console.WriteLine("what do you want to do with our program(options) \n\n 1. Main menu\n 2. Exit");
            int options = int.Parse(Console.ReadLine());

            if (options == 1)
            {
                Console.WriteLine("1. All pets in our care ");
                Console.WriteLine("2. Add new pets(this is for the owners only!!!)\n");
                int innerOptions = int.Parse(Console.ReadLine());
                switch (innerOptions)
                {
                    case 1:
                        foreach (string pet in petID)
                        {
                            if (pet == "CP001")
                            {
                                genFunction = function1;
                            }
                            else if (pet == "CP002")
                            {
                                genFunction = function2;
                            }
                            else if (pet == "CP003")
                            {
                                genFunction = function3;
                            }
                            else if (pet == "CP004")
                            {
                                genFunction = function4;
                            }

                            Console.WriteLine($"PetID: {pet}");
                            Console.WriteLine($"Pet species: {genFunction[0]}");
                            Console.WriteLine($"Age: {genFunction[1]}");
                            Console.WriteLine($"Size: {genFunction[2]}");
                            Console.WriteLine($"Nickname: {genFunction[3]}\n\n");
                        }
                         break;

                        // make sure after the user is done adding new pets to the console, it prints all the pets including the added ones 
                    case 2:
                        Console.WriteLine("This feature would be available soon!!!");
                        break;

                } //end of switch statement

            }
            else if (options == 2)
            {
                Console.WriteLine("Press the Enter to exit");
                Console.ReadLine();
            }
            
            
        }
    }
}