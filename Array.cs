using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Array
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array you want : ");

            int size = Convert.ToInt32(Console.ReadLine());
            int[] ab = new int[size];
            for(int i = 0; i < size; i++)
            {
                Console.Write("enter element {0} : ", i + 1);
                ab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You entered these elements in the array : ");
            foreach (int i in ab)
            {
                Console.WriteLine(i);
            }
            //Console.Read();
            //int[] ab = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (int i in ab)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Read();
        }
    }
}
