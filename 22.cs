using System;

class _22
{
    static void Main()
    {
        int n = 5;

        // Top half
        for (int i = 1; i <= n; i++)
        {
            // Print spaces
            for (int j = 1; j <= n - i; j++)
                Console.Write(" ");

            // Print stars
            for (int k = 1; k <= 2 * i - 1; k++)
                Console.Write("*");

            Console.WriteLine();
        }

        // Bottom half
        for (int i = n - 1; i >= 1; i--)
        {
            // Print spaces
            for (int j = 1; j <= n - i; j++)
                Console.Write(" ");

            // Print stars
            for (int k = 1; k <= 2 * i - 1; k++)
                Console.Write("*");

            Console.WriteLine();
        }
    }
}
