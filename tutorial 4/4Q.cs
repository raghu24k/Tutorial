using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StaticVar
    {
        public static int num;
        public StaticVar()
        {

        }

        public static int getNum()
        {
            return num;
        }

        public void count()
        {
            num++;
        }
    }

    // internal class StaticTester
    // {
    //     static void Main(string[] args)
    //     {
    //         StaticVar s = new StaticVar();
    //         s.count();
    //         s.count();
    //         s.count();

    //         Console.WriteLine("Variable num: {0}", StaticVar.getNum());
    //         Console.ReadKey();
    //     }
    // }
}
