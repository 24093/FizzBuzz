using System;
using System.Linq;

namespace FizzBuzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 100);
            var dict = new[]
            {
                (3, "Fizz"),
                (5, "Buzz"),
                (10, "Wololo")
            };

            var lines = FizzBuzz.GenerateLines(numbers, dict);

            Console.WriteLine(string.Join(Environment.NewLine, lines));
            Console.ReadKey();
        }
    }
}
