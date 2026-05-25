/* An update of the challenge9, 
 * changed all static arrays to dynamic ones
 * included the add new pets feature */
using System;
using System.Linq;
using System.Collections.Generic;

namespace Challenge10
{
    class Program
    {
        static void Main(string[] args)
        {

            // declaring variables
            List<string> petID = new List<string> { "CP001", "CP002", "CP003", "CP004" }; // stores all the names of pet ID
            List<string> petSpecies = new List<string> { "DOG", "CAT", "DOG", "CAT" }; // stores the species of pets
            List<string> petAge = new List<string>() { "3years", "2years", "1year", "12years" }; // stores the pet age for all pets
            List<string> petSize = new List<string>() { "medium-sized", "small-sized", "small-sized", "large-size" }; // stores the pet size for all pets
            List<string> petNickname = new List<string> { "Skubby", "Risk", "Loopy", "Her Majesty"}; // stores the nicknames for all the pets
            string variable1 = "";
            string variable2 = "";
            string variable3 = "";
            string variable4 = "";
            string variable5 = "";

            Console.WriteLine("what would like to use our application for \n\n1.Main menu \n2. Exit");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("1. all pets list\n 2. add new pets(for admins only)");
                int options = int.Parse(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        if (petID == null)
                            Console.WriteLine("There is no available pet in the pet application\n");
                        else if (petID != null)
                        {
                            for (int i = 0; i < petID.Count; i++)
                            {
                                variable1 = petID[i];
                                variable2 = petSpecies[i];
                                variable3 = petAge[i];
                                variable4 = petSize[i];
                                variable5 = petNickname[i];

                                // print out all in the application
                                Console.WriteLine($"PetID: {variable1}");
                                Console.WriteLine($"Pet Species: {variable2}");
                                Console.WriteLine($"Pet age: {variable3}");
                                Console.WriteLine($"Pet size: {variable4}");
                                Console.WriteLine($"Pet Nickname: {variable5}");

                            }
                        }
                        break;

                    // the case to add new pets to the application and print out the entire pets to the screen
                    case 2:
                        int k = 0;
                        int userInput = 0;
                        do
                        {
                            //Ask user for the new petID
                            Console.WriteLine($"Enter the PetID{k}: ");
                            petID.Add(Console.ReadLine());

                            // asks the user for the pet species
                            Console.WriteLine($"Enter the pet species{k}: ");
                            petSpecies.Add(Console.ReadLine());

                            // asks the user for the pet age
                            Console.WriteLine($"Enter the pet age{k}: ");
                            petAge.Add(Console.ReadLine());

                            // asks the user for the pet size
                            Console.WriteLine($"Enter the pet size{k}: ");
                            petSize.Add(Console.ReadLine());

                            // asks the user for the pet nickname
                            Console.WriteLine($"Enter the pet nickname{k}: ");
                            petNickname.Add(Console.ReadLine());

                            Console.WriteLine("Are you done?\n\n 1. continue\n2. done ");
                            userInput = int.Parse(Console.ReadLine());

                            if (userInput == 1)
                                Console.WriteLine("Okay!\n");

                            k++;
                        } while (userInput != 2);

                        // printing out the whole pets data in the application including the recent added ones 
                        for (int i = 0; i < petID.Count; i++)
                        {
                            variable1 = petID[i];
                            variable2 = petSpecies[i];
                            variable3 = petAge[i];
                            variable4 = petSize[i];
                            variable5 = petNickname[i];

                            // print out all in the application
                            Console.WriteLine($"PetID: {variable1}");
                            Console.WriteLine($"Pet Species: {variable2}");
                            Console.WriteLine($"Pet age: {variable3}");
                            Console.WriteLine($"Pet size: {variable4}");
                            Console.WriteLine($"Pet Nickname: {variable5}\n");

                        }
                        break;


                } // end of switch case
            } // end of if statement

            else if (n == 2)
            {
                Console.WriteLine("Press the Enter to exit");
                Console.ReadLine();
            }

        }
    }
}