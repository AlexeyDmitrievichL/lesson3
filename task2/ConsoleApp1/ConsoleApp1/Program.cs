using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            getNumbers();
        }

        private static void getNumbers()
        {
            Console.WriteLine("Input first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            compareNumbers(firstNumber, secondNumber);
            getNumbers();
        }

        private static void compareNumbers(in int numberA, in int numberB)
        {
            if (numberA > numberB)
            {
                Console.WriteLine($"Number {numberA} more then number {numberB}");
            }

            if (numberB > numberA)
            {
                Console.WriteLine($"Number {numberB} more then number {numberA}");
            }

            if (numberB == numberA)
            {
                Console.WriteLine($"Number {numberA} is equal to number {numberB}");
            }
        }
    }
}
