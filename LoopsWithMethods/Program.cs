using System;
using System.Collections.Generic;

namespace LoopsWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            GetPlusLoop();
            Console.WriteLine();
            GetMinusLoop();
            Console.WriteLine();
            Console.WriteLine("Please enter a number and press Enter.");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < 49; i++)
            {
                Console.WriteLine(List(input)[i]);
            }
        }
        public static List<int> List(int input)
        {
            int number = input + 48;
            int reverse = 2;
            List<int> output = new List<int> { };

            for (int i = input; i <= number; i++)
            {
                if (i <= input + 32)
                {
                    output.Add(i);
                }
                else
                {
                    output.Add(i - reverse);
                    reverse += 2;
                }
            }
            return output;
        }
        public static void GetPlusLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }
        }
        public static void GetMinusLoop()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
