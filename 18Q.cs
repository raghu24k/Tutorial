using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class _18Q
    {
        static void Main(string[] args)
        {
            int i, j,k=1;
            {
                for (i = 1; i <= 4; i++)
                {
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write(k+" ");
                        k++;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
