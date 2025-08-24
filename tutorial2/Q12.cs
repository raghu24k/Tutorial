//12: Write a program to find the element from a
//n Array and print 1 if element is found else print 0.


using System;

class Q12
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements (N): ");
        int N = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[N];

        // Input N elements
        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter the element to search: ");
        int key = Convert.ToInt32(Console.ReadLine());

        int found = 0;

        // Search for the element
        for (int i = 0; i < N; i++)
        {
            if (arr[i] == key)
            {
                found = 1;
                break;  // Exit loop once found
            }
        }

        Console.WriteLine(found);

        Console.ReadLine();
    }
}
