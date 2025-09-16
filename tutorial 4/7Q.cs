using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    sealed class A
    {
        public int x;
        public int y;
    }
    internal class SealedTest2
    {
        static void Main(string[] args)
        {
            A sc = new A();
            sc.x = 110;
            sc.y = 150;
            Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);
        }
    }
}
