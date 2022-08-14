using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Define A");
            int firstVar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Define B");
            int secondVar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A = {firstVar}; B = {secondVar}");
            Console.WriteLine("Some magic and...");
            doSomeMagic(ref firstVar, ref secondVar);
            Console.WriteLine($"A = {firstVar}; B = {secondVar}");
            Console.WriteLine("Press any key for exit, bro :)");
            Console.ReadKey();
        }

        private static void doSomeMagic(ref int a, ref int b)
        {
            a += b;
            b = a - b;
            a -= b;
        }
    }
}
