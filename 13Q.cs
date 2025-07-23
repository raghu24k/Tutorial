using System;

public class _13Q
{
    public static void Main(string[] args)
    {
        int n1 = 0, n2 = 1, n3, i;
        int count = 11; 

        Console.Write(n1 + " " + n2 + " ");

        for (i = 3; i <= count; ++i)
        {
            n3 = n1 + n2;
            Console.Write(n3 + " ");
            n1 = n2;
            n2 = n3;
        }
    }
}
