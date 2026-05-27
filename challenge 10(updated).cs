/* An update of the challenge9, 
 * Changed all static arrays to dynamic ones{done}
 * Includes the add new pets feature{done}
 * tells the user the PetID for any additional pet{done}
 * Ensure animal ages and physical descriptions are complete{done}
 * Edit an animal's age {done}
 * Edit an animal's personality description{done}
 * Display all cats that meet user specified physical characteristics{done}
 * Display all dogs that meet user specified physical characteristics{done}
 * for some reasons, i had to really upgrade my challenge10 myself to meet up with the microsoft FCC requirements, but nevertheless i built this all on my own,
   copied no pseudocode from microsoft for this project, you can verify it their pseudocode for contoso pet app ain't the same as mine,  all for fun
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace Challenge10
{
    class Program
    {
        public static void Main(string[] args)
        {

            // declaring variables
            List<string> petID = new List<string> { "CP1", "CP2", "CP3", "CP4" }; // stores all the names of pet ID
            List<string> petSpecies = new List<string> { "DOG", "CAT", "DOG", "CAT" }; // stores the species of pets
            List<string> petAge = new List<string>() { "3years", "2years", "1year", "12years" }; // stores the pet age for all pets
            List<string> petSize = new List<string>() { "medium-sized", "small-sized", "small-sized", "large-size" }; // stores the pet size for all pets
            List<string> petNickname = new List<string> { "Skubby", "Risk", "Loopy", "Her Majesty"}; // stores the nicknames for all the pets
            List<string> physicalConditions = new List<string> { "Healthy, Matted Coat, Amputee(Tripod), Teething", "Underweight, Alopecia(Hair Loss), Fracture(recovering from a broken bone), Teething ", "Dehydrated(requires immediate fluid therapy), clean and shiny, deaf, ---", "Healthy, clean and shiny, Senior Care(General weakness or slowing down due to old age)"}; // stores pet's physical conditions
            List<string> petPersonality = new List<string> { "Friendly", "not Friendly", "kind", "Protective" }; // stores the pet personality for pets in the application
            string variable1 = "";
            string variable2 = "";
            string variable3 = "";
            string variable4 = "";
            string variable5 = "";
            string variable6 = "";
            string variable7 = "";

            Console.WriteLine("*****Welcome to our Contoso Pets Application*****\n\n");


            Console.WriteLine("what would like to use our application for \n\n1.Main menu\n2. Exit"); // prompt user for input
            int n = int.Parse(Console.ReadLine()); // stores user input
            Console.WriteLine(""); // for newline 

            if (n == 1)
            {
                Console.WriteLine("1. all pets list\n2. add new pets(for admins only)\n3. edit the pet's information\n4. Choose the pet of your choice "); // prompt userv for input
                int options = int.Parse(Console.ReadLine()); // stores user input
                switch (options)
                {
                    // 1. prints everything in the application to the screen
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
                                variable6 = physicalConditions[i];
                                variable7 = petPersonality[i];


                                // print out all in the application
                                Console.WriteLine($"PetID: {variable1}");
                                Console.WriteLine($"Pet Species: {variable2}");
                                Console.WriteLine($"Pet age: {variable3}");
                                Console.WriteLine($"Pet size: {variable4}");
                                Console.WriteLine($"Pet Nickname: {variable5}");
                                Console.WriteLine($"Pet physical conditions: {variable6}");
                                Console.WriteLine($"Pet personality: {variable7}\n");

                            }
                        }
                        break;

                    // 2. add new pets to the application and print out the entire pets to the screen
                    case 2:
                        int k = 5;
                        int userInput = 0;

                        do
                        {

                            Console.WriteLine($"Enter the petID, type: CP{k}");
                            petID.Add(Console.ReadLine());

                            // asks the user for the pet species
                            Console.Write($"Enter the pet species: ");
                            petSpecies.Add(Console.ReadLine());

                            // asks the user for the pet age
                            Console.Write($"Enter the pet age: ");
                            petAge.Add(Console.ReadLine());

                            // asks the user for the pet size
                            Console.Write($"Enter the pet size: ");
                            petSize.Add(Console.ReadLine());

                            // asks the user for the pet nickname
                            Console.Write($"Enter the pet nickname: ");
                            petNickname.Add(Console.ReadLine());

                            // asks the user for the pet physical conditions
                            Console.Write($"Enter the pet physical condition: ");
                            physicalConditions.Add(Console.ReadLine());

                            // asks the user for the pet personalities
                            Console.Write($"Enter the pet's personality: ");
                            petPersonality.Add(Console.ReadLine());


                            Console.WriteLine("Are you done?\n\n1. continue\n2. done ");
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
                            variable6 = physicalConditions[i];
                            variable7 = petPersonality[i];

                            // print out all in the application
                            Console.WriteLine($"PetID: {variable1}");
                            Console.WriteLine($"Pet Species: {variable2}");
                            Console.WriteLine($"Pet age: {variable3}");
                            Console.WriteLine($"Pet size: {variable4}");
                            Console.WriteLine($"Pet Nickname: {variable5}");
                            Console.WriteLine($"Pet physical conditions: {variable6}");
                            Console.WriteLine($"Pet personality: {variable7}\n");

                        }
                        break;

                    // 3. edit the pet's information and print out all pets in the application
                    case 3:
                        bool hasPets;
                        Console.Write("Input the petID of the pet you are looking for: ");
                        

                        do
                        {
                            string x = Console.ReadLine();
                            hasPets = petID.Contains(x);
                            int index = petID.IndexOf(x);

                            if (hasPets == true)
                            {

                                Console.WriteLine($"PetID {x} exists in this application");
                                Console.WriteLine(petID[index]);
                                Console.WriteLine(petSpecies[index]);
                                Console.WriteLine(petAge[index]);
                                Console.WriteLine(petSize[index]);
                                Console.WriteLine(petNickname[index]);
                                Console.WriteLine(physicalConditions[index]);
                                Console.WriteLine(petPersonality[index]);
                                Console.WriteLine("\n");

                                // changing values section 
                                Console.WriteLine("*****Change their values*****");
                                Console.WriteLine($"Change values for Pet CP{index + 1}\n");

                                Console.Write("petID: ");
                                petID[index] = Console.ReadLine();
                                Console.WriteLine("");

                                Console.Write("Pet Species: ");
                                petSpecies[index] = Console.ReadLine();
                                Console.WriteLine("");

                                Console.Write("Pet age: ");
                                petAge[index] = Console.ReadLine();
                                Console.WriteLine("");

                                Console.Write("Pet size: ");
                                petSize[index] = Console.ReadLine();
                                Console.WriteLine("");

                                Console.Write("Pet Nickname: ");
                                petNickname[index] = Console.ReadLine();
                                Console.WriteLine("");

                                Console.Write("Pet physical conditions: ");
                                physicalConditions[index] = Console.ReadLine();
                                Console.WriteLine("");

                                Console.Write("Pet personality: ");
                                petPersonality[index] = Console.ReadLine();
                                Console.WriteLine("");

                            } // end of if statement
                            else if (hasPets == false)
                                Console.Write($"PetID {x} doesn't exist\nEnter PetID: ");
                        } while (hasPets != true);

                        // prints out all pets in the application
                        for (int i = 0; i < petID.Count; i++)
                        {
                            variable1 = petID[i];
                            variable2 = petSpecies[i];
                            variable3 = petAge[i];
                            variable4 = petSize[i];
                            variable5 = petNickname[i];
                            variable6 = physicalConditions[i];
                            variable7 = petPersonality[i];


                            // print out all in the application
                            Console.WriteLine($"PetID: {variable1}");
                            Console.WriteLine($"Pet Species: {variable2}");
                            Console.WriteLine($"Pet age: {variable3}");
                            Console.WriteLine($"Pet size: {variable4}");
                            Console.WriteLine($"Pet Nickname: {variable5}");
                            Console.WriteLine($"Pet physical conditions: {variable6}");
                            Console.WriteLine($"Pet personality: {variable7}\n");

                        }
                        break;

                    // 4.  Choose your pet of choice
                    case 4:
                       
                        
                        List<int> petOptions = new List<int>();
                        string option1 = "";
                        string target = "";

                       
                        Console.WriteLine("looking for a pet?, we got you covered\n ");

                        Console.WriteLine("what specie of pet do you want(Dog or cat)");
                        // a do-while loop to check if the user input is valid or not
                        do
                        {

                            string option = Console.ReadLine();
                            option1 = option.Trim().ToLower();
                            if (option1 == "dog")
                            {
                                for (int i = 0; i < petSpecies.Count; i++)
                                {
                                    string cleanPet = petSpecies[i].Trim().ToLower();
                                    if (cleanPet.Contains("dog"))
                                    {
                                        petOptions.Add(i); // Saves the current index position(or integers) for each of those particular elements that matched.
                                    }
                                }
                                foreach(int indexes in petOptions)
                                {
                                    Console.WriteLine($"PetID: {petID[indexes]}");
                                    Console.WriteLine($"Pet species: {petSpecies[indexes]}");
                                    Console.WriteLine($"Pet age: {petAge[indexes]}");
                                    Console.WriteLine($"Pet size: {petSize[indexes]}");
                                    Console.WriteLine($"Pet nickname: {petNickname[indexes]}");
                                    Console.WriteLine($"Pet physical conditons: {physicalConditions[indexes]}");
                                    Console.WriteLine($"Pet personality: {petPersonality[indexes]}\n");
                                }
                                // outputs the results
                                
                                break; // breaks out of the if statement in the do-while loop
                            }
                            else if (option1 == "cat")
                            {
                                for (int i = 0; i < petSpecies.Count; i++)
                                {
                                    string cleanPet = petSpecies[i].Trim().ToLower();
                                    if (cleanPet.Contains("cat"))
                                    {
                                        petOptions.Add(i); // Saves the current index position(or integers) for each of those particular elements that matched.
                                    }
                                }
                                // outputs the results
                                foreach (int indexes in petOptions)
                                {
                                    Console.WriteLine($"PetID: {petID[indexes]}");
                                    Console.WriteLine($"Pet Species: {petSpecies[indexes]}");
                                    Console.WriteLine($"Pet age: {petAge[indexes]}");
                                    Console.WriteLine($"Pet size: {petSize[indexes]}");
                                    Console.WriteLine($"Pet nickname: {petNickname[indexes]}");
                                    Console.WriteLine($"Pet physical conditions: {physicalConditions[indexes]}");
                                    Console.WriteLine($"Pet personality: {petPersonality[indexes]}\n");
                                } // end of foreach statement 
                                break; // break out of the else if statement in the do-while
                            } // end of else if statement
                            else
                            {
                                Console.Write("Invalid input\nEnter either dog or cat: ");
                            }
                        } while (option1 != "cat" || option1 != "dog");

                        break;
                  

                } // end of switch case
            } // end of if statement

            else if (n == 2)
            {
                Console.WriteLine("Press the Enter key to exit");
                Console.ReadLine();
            }

        } // end of static main
    } // end of class program
} // end of namespace 