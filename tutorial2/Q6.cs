using System;

public class Q6
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("You entered the following {0} command line arguments:",
           args.Length);

        // Missing statements
        for (int i = 0; i < args.Length; i++)        // Missing statement-1
        {
            Console.WriteLine(args[i]);              // Missing statement-2
        }                                            // Missing statement-3

        Console.ReadLine();                          // Missing statement-4
    }
}
