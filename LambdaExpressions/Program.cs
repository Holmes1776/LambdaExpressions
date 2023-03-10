using System;

namespace LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a number");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in a second number");
            double second = double.Parse(Console.ReadLine());
            var sum = (double first, double second) => first + second;
            var product = (double first, double second) => first * second;
            var bigger = (double first, double second) =>
            {
                if (first > second)
                {
                    return first;
                }
                else
                {
                    return second;
                }
            };
            Console.WriteLine("Here is the sum of the numbers");
            Console.WriteLine(sum(first, second));
            Console.WriteLine("Here is the product of the numbers");
            Console.WriteLine(product(first, second));
            Console.WriteLine("Here is the larger of the 2 numbers");
            Console.WriteLine(bigger(first, second));
            
        }
    }
}