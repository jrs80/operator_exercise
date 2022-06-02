using System;


namespace Operator_Exercise
{
    internal class Program
    {
        public static double AOC(double r) => Math.PI * r * r;
        
        static void Main(string[] args)
        {
            int x = 5, y = 3, q, r;
            q = x / y;
            r = x % y;
            Console.WriteLine($"{x} / {y} is {q} remainder {r}");

            Console.WriteLine("Enter radius: ");
            double rad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of a circle with radius {rad} is " + AOC(rad));

        }
    }
}
