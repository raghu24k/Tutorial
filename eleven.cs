using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class eleven
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Gender: (M/F): ");
            //string M, N;
            string gender = Console.ReadLine();

            if (gender == "M") 
            {
                Console.WriteLine("Hello Mr. " + name);

            }
            else
            {
                Console.WriteLine("Hello Ms. " + name);
            }
        }
    }
}
