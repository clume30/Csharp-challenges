using System;
using System.Linq;
namespace firstChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };
            Console.WriteLine($"The maximum number is: {numbers.Max()}" );
            Console.WriteLine($"The minimum number is: {numbers.Min()}");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(Math.Sqrt(numbers[i]));
            }
        }
    }
}
