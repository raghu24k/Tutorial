using System;

public class _20Q
{
    public static void Main(string[] args)
    {
        int rows = 4;
        int number = 1;

        for (int i = 1; i <= rows; i++)
        {
            
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }

          
            for (int k = 1; k <= i; k++)
            {
                Console.Write(number + " ");
                number++;
            }

            Console.WriteLine();
        }
    }
}
