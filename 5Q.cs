using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class _5Q
    {
        static void Main(string[] args)
        {
            int n, fact = 1;
            Console.WriteLine("Enter Number : ");
            String str = Console.ReadLine();
            n = Convert.ToInt32(str);

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial: {0}", fact);
            Console.Read();
        }
    }
}
