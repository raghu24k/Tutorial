using System;

class Q9
{
    static void FindTwoNumbers(int[] arr)
    {
        int xorAll = 0;

        // Step 1: XOR all elements
        foreach (int num in arr)
        {
            xorAll ^= num;
        }

        // Step 2: Find rightmost set bit
        int setBit = xorAll & -xorAll;

        int num1 = 0, num2 = 0;

        // Step 3: Divide elements into two groups
        foreach (int num in arr)
        {
            if ((num & setBit) > 0)
                num1 ^= num;
            else
                num2 ^= num;
        }

        Console.WriteLine("The two unique numbers are: {0} {1}", num1, num2);
    }

    static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3, 2, 1, 4 };
        FindTwoNumbers(arr1);   // Output: 3 4

        int[] arr2 = { 2, 1, 3, 2 };
        FindTwoNumbers(arr2);   // Output: 1 3

        Console.ReadLine();
    }
}
