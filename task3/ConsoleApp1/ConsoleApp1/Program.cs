using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number, bro :)");
            string userInput = Console.ReadLine();
            checkOnPalindrom(userInput);
            Console.ReadKey();
        }

        public static string reverseString(string userInput)
        {
            char[] charArray = userInput.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static void checkOnPalindrom(in string userInput)
        {
            int userInputNumber = Convert.ToInt32(userInput);
            if (userInputNumber >= 0 && userInputNumber < 10)
            {
                Console.WriteLine($"{userInput} is palindrom");
                return;
            }
            int reversedUserInputNumber = Convert.ToInt32(reverseString(userInput));
            if (userInputNumber / reversedUserInputNumber == 1)
                Console.WriteLine($"{userInput} is palindrom");
            else
                Console.WriteLine($"{userInput} is not palindrom");

        }
    }
}
