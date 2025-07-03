using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class oddeven
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value: ");
            int a = Convert.ToInt32(Console.ReadLine());


            if (a%2 == 0)  {
                Console.Write(a+" is an even number");

            }
            else
            {
                Console.Write(a+ " is an odd number");
            }
        }
    }
}
