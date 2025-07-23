using System;

namespace Tutorial
{
    internal class _21Q
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the terms: ");
            int termCount = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int termValue = 0;

            Console.Write("Series: ");
            for (int i = 1; i <= termCount; i++)
            {
                termValue = termValue * 10 + number;
                sum += termValue;
                Console.Write(termValue);

                if (i != termCount)
                    Console.Write(" + ");
            }

            Console.WriteLine("\nThe sum is: " + sum);
        }
    }
}
