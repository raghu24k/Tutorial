using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class MyException : Exception
    {
        public MyException(string str) : base(str)
        {
        }
    }
    internal class MyClients
    {
        static void Main(string[] args)
        {
            try
            {
                throw new MyException("my exception generated.");
            }
            catch (MyException e)
            {
                Console.WriteLine("Exception caught here: " + e.Message);
            }
            Console.WriteLine("LAST STATEMENT");
        }
    }
}
