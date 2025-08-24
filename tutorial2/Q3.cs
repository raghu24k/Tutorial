//3 : Correct the following code and write output for the corrected code.

using System;

namespace ConsoleApplication1
{
    class Q3
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";

            Console.WriteLine("Name: " + firstName + " " + lastName);

            Console.WriteLine("Please enter a new first name:");
            firstName = Console.ReadLine();

            Console.WriteLine("New name: " + firstName + " " + lastName);

            Console.ReadLine();
        }
    }
}
