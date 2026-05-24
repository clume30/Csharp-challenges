// a mini whatever
using System;
using System.Linq;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. uses arrays to store student names and assignment scores
            string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };

            // Sophia
            decimal[] sophiaScores = { 90m, 97m, 96m, 89m, 88m, 79m, 80m }; // array of decimals containing the mix of exam scores and extra credit scores
            decimal[] sophiaScores2 = { 90m, 97m, 96m, 89m, 88m, 79m }; // array of decimals containing only exam scores 
            decimal sophiaAvg1 = sophiaScores2.Average();
            decimal[] sophiaExtraCredits = { 67m, 89m, 80m, 87m };// array of decimals containing only extra credits 
            decimal sophiaAvg2 = sophiaExtraCredits.Average();
            decimal sophiaSum = 0;
            foreach (decimal extraCredit in sophiaExtraCredits)
            {
                sophiaSum += extraCredit;
            }
            decimal sophiaCredits = (decimal) sophiaSum / 10m; // sophiaCredits stores the value for the sum of her extra credit divide by ten
            sophiaScores[6] = sophiaCredits;

            // Andrew
            decimal[] andrewScores = { 89m, 80m, 87m, 88m, 86m, 82m, 90m }; // array of decimals containing the mix of exam scores and extra credit scores
            decimal[] andrewScores2 = { 89m, 80m, 87m, 88m, 86m, 82m }; // array of decimals containing only exam scores
            decimal andrewAvg1 = andrewScores2.Average();
            decimal[] andrewExtraCredits = { 90m, 89m, 88m, 80m }; // array of decimals containing only extra credits
            decimal andrewAvg2 = andrewExtraCredits.Average();
            decimal andrewSum = 0;
            foreach (decimal extraCredit in andrewExtraCredits)
            {
                andrewSum += extraCredit;
            }
            decimal andrewCredits = (decimal) andrewSum / 10m; // andrewCredits does the same for andrew as sophiaCredit does for sophia
            andrewScores[6] = andrewCredits;

            // Emma
            decimal[] emmaScores = { 98m, 89m, 76m, 89m, 80m, 87m, 94m }; // array of decimals containing the mix of exam scores and extra credit scores
            decimal[] emmaScores2 = { 98m, 89m, 76m, 89m, 80m, 87m }; // array of decimals containing only exam scores
            decimal emmaAvg1 = emmaScores2.Average();
            decimal[] emmaExtraCredits = { 90m, 89m, 70m, 89m }; // array of decimals containing only extra credits
            decimal emmaAvg2 = emmaExtraCredits.Average();
            decimal emmaSum = 0;
            foreach (decimal extraCredit in emmaExtraCredits)
            {
                emmaSum += extraCredit;
            }
            decimal emmaCredits = (decimal) emmaSum / 10m; // same thing as line 33
            emmaScores[6] = emmaCredits;

            // Logan
            decimal[] loganScores = { 88m, 87m, 89m, 95m, 98m, 100m, 89m }; // array of decimals containing the mix of exam scores and extra credit scores
            decimal[] loganScores2 = { 88m, 87m, 89m, 95m, 98m, 100m }; // array of decimals containing only exam scores
            decimal loganAvg1 = loganScores2.Average(); 
            decimal[] loganExtraCredits = { 89m, 90m, 90m, 77m }; // array of decimals containing only extra credits
            decimal loganAvg2 = loganExtraCredits.Average();
            decimal loganSum = 0;
            foreach (decimal extraCredit in loganExtraCredits)
            {
                loganSum += extraCredit;
            }
            decimal loganCredits = (decimal) loganSum / 10m;
            loganScores[6] = loganCredits;

            decimal average2 = 0; // stores, based on the student name the required average of the exam scores
            decimal average3 = 0; // stores, based on the student name the required average of the extra credit scores
            decimal anyCredit = 0;
            decimal[] assignmentScores = new decimal[7];
            string currentStudentName = "";
            string grade = "";

            // 2.  Uses a foreach statement to iterate through the student names as an outer program loop
            Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\t     Extra Credit");
            foreach (string student in studentNames)
            {
                currentStudentName = student;
                // 3.  Uses an if statement within the outer loop to identify the current student's name and access that student's assignment scores.
                
                if (currentStudentName == "Sophia")
                {
                    assignmentScores = sophiaScores;
                    average2 = sophiaAvg1;
                    average3 = sophiaAvg2;
                    anyCredit = sophiaCredits;
                }
                else if (currentStudentName == "Andrew")
                {
                    assignmentScores = andrewScores;
                    average2 = andrewAvg1;
                    average3 = andrewAvg2;
                    anyCredit = andrewCredits;
                }
                else if (currentStudentName == "Emma")
                {
                    assignmentScores = emmaScores;
                    average2 = emmaAvg1;
                    average3 = emmaAvg2;
                    anyCredit = emmaCredits;
                }
                else if (currentStudentName == "Logan")
                {
                    assignmentScores = loganScores;
                    average2 = loganAvg1;
                    average3 = loganAvg2;
                    anyCredit = loganCredits;
                }



                // 4. Uses a foreach statement within the outer loop to iterate through the assignment scores array and sum the values.
               
                decimal sum = 0;
                foreach (decimal score in assignmentScores )
                {
                    sum += score;
                }
                // 5. Uses an algorithm within the outer loop to calculate the average exam score for each student.
                decimal average = 0;
                average = (decimal) sum / assignmentScores.Length;

                // 6. Use an if-elseif-else construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
                
                if (average >= 97)
                    grade = "A+";

                else if (average >= 93)
                    grade = "A";

                else if (average >= 90)
                    grade = "A-";

                else if (average >= 87)
                    grade = "B+";

                else if (average >= 83)
                    grade = "B";

                else if (average >= 80)
                    grade = "B-";

                else if (average >= 77)
                    grade = "C+";

                else if (average >= 73)
                    grade = "C";

                else if (average >= 70)
                    grade = "C-";

                else if (average >= 67)
                    grade = "D+";

                else if (average >= 63)
                    grade = "D";

                else if (average >= 60)
                    grade = "D-";

                Console.WriteLine($"{student}\t\t{average2:F1}\t\t{average:F1}\t{grade}\t\t{average3:F1}  ({anyCredit:F1}pts)");
            }
            

        }
    }
}

