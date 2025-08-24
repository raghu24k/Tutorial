using System;

namespace ConsoleApplication1
{
    class Q5
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];  // Declare array
            int sum = 0;             // Initialize sum

            // Input 5 elements
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Element {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Calculate sum
            for (int i = 0; i < 5; i++)
            {
                sum = sum + arr[i];
            }

            // Print result
            Console.WriteLine("Sum of Elements : {0}", sum);

            Console.ReadLine();
        }
    }
}
