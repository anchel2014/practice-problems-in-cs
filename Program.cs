using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeProblemsSCS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new() { 1, 5, 8, 12, 15, 20, 23, 30 };

            Console.WriteLine("Original list: " + string.Join(", ", numbers));
            Console.WriteLine();

            // Filter: only even numbers
            var evenNumbers = FilterNumbers(numbers, num => num % 2 == 0);
            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));

            // Filter: numbers greater than 10
            var greaterThan10 = FilterNumbers(numbers, num => num > 10);
            Console.WriteLine("Numbers > 10: " + string.Join(", ", greaterThan10));

            // Filter: numbers divisible by 5
            var divisibleBy5 = FilterNumbers(numbers, num => num % 5 == 0);
            Console.WriteLine("Divisible by 5: " + string.Join(", ", divisibleBy5));

            // Custom filter: numbers between 10 and 25
            var between10and25 = FilterNumbers(numbers, num => num >= 10 && num <= 25);
            Console.WriteLine("Between 10 and 25: " + string.Join(", ", between10and25));
        }

        /// <summary>
        /// Filters a list of numbers based on a given condition.
        /// </summary>
        /// <param name="numbers">The input list of numbers</param>
        /// <param name="condition">A delegate that defines the filtering condition</param>
        /// <returns>A list containing only numbers that satisfy the condition</returns>
        static List<int> FilterNumbers(List<int> numbers, Func<int, bool> condition)
        {
            List<int> result = new();
            
            foreach (int number in numbers)
            {
                if (condition(number))
                {
                    result.Add(number);
                }
            }
            
            return result;
        }
    }
}
