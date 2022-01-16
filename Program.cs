using System;

namespace FactorialExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = fact(input);
            Console.WriteLine("Factorial of " + input + ": "+number);
        }

        static int fact(int number)
        {
            if (number >= 1)
            {
                return number * fact(number - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}
