using System;
namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("****Welcome to my CGPA calculator****");

            Console.WriteLine("how many courses do you want to input: "); // prompts user for input  
            int n = int.Parse(Console.ReadLine());

            //Create an array
            Course[] courses = new Course[n];
            
            // Collect input from user 
            for (int i = 0; i < n; i++)
            {
                courses[i] = new Course();

                Console.Write($"Course {i + 1} name: ");
                courses[i].name = Console.ReadLine();


                Console.Write("Credit Unit: ");
                courses[i].creditUnit = int.Parse(Console.ReadLine());


                Console.Write("Grade: ");
                courses[i].grade = char.Parse(Console.ReadLine());

                //Convert grade to grade point
                switch(courses[i].grade)
                {
                    case 'A': case 'a':
                        courses[i].gradePoint = 5;
                        break;
                    case 'B': case 'b':
                        courses[i].gradePoint = 4;
                        break;
                    case 'C': case 'c':
                        courses[i].gradePoint = 3;
                        break;
                    case 'D': case 'd':
                        courses[i].gradePoint = 2;
                        break;
                    case 'E': case 'e':
                        courses[i].gradePoint = 1;
                        break;
                    case 'F': case 'f':
                        courses[i].gradePoint = 0;
                        break;
 
                }

            }

            double totalPoints = 0.00; // stores the sum of all credit unit * grade
            double totalUnits = 0; // stores the sum of all credit units

            for (int i = 0; i < n; i++)
            {
                totalPoints += courses[i].creditUnit * courses[i].gradePoint;
                totalUnits += courses[i].creditUnit; 
            }

            double result = totalPoints / totalUnits;
            Console.WriteLine("\n\n\n");
            Console.WriteLine($"your CGPA is: {result:F2}");

        }
    }
}
