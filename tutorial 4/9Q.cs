using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyClient
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 0;
                int div = 100 / x;
                Console.WriteLine(div);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed (finally block).");
            }
        }
    }
}
