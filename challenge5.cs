/* a program to check my understanding on for loops
1. Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
2. When the current value is divisible by 3, print the term Fizz next to the number.
3. When the current value is divisible by 5, print the term Buzz next to the number.
4. When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.*/
using System;
using System.Linq;

namespace Challenge5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 101; i++)
            {
                int x = i % 3;
                int y = i % 5;


                if (x == 0 && y == 0)
                {
                    Console.WriteLine($"{i} - fizzBuzz");
                }
                else if (x == 0)
                {
                    Console.WriteLine($"{i} - fizz");
                }
                else if (y == 0)
                {
                    Console.WriteLine($"{i} - buzz");
                }
                else
                    Console.WriteLine(i);
            }
        }
    }
}
