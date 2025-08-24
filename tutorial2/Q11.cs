//11: Write a program to find the sum of N elements of an Array.
using System;

class Q11
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements (N): ");
        int N = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[N];
        int sum = 0;

        // Input N elements
        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Calculate sum
        for (int i = 0; i < N; i++)
        {
            sum += arr[i];
        }

        Console.WriteLine("Sum of the array elements: " + sum);

        Console.ReadLine();
    }
}
