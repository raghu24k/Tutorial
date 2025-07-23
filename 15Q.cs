using System;

namespace ArmstrongCheck
{
    class _15Q
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int original = num;
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum += digit * digit * digit; // cube of digit
                num /= 10;
            }

            if (sum == original)
            {
                Console.WriteLine(original + " is an Armstrong number.");
            }
            else
            {
                Console.WriteLine(original + " is NOT an Armstrong number.");
            }

            Console.ReadLine();
        }
    }
}
