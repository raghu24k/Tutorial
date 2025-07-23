using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class mam1
    {
        static void Main(String[] args)
        {
            int num = 521;
            string[] units = { "zero","one","two","three","four","five" };
            int temp = num;
            int[] digit = new int[10];
            int count = 0;
            //int reverse = 0;
            while (temp > 0 )
            {
                digit[count] = temp % 10;
                //Console.WriteLine("digit count is" + digit[count]);
                //reverse = (reverse * 10) + digit[count];
                temp = temp / 10;
                //Console.WriteLine("temp value is " + temp);
                count = count + 1;
            }
            Console.WriteLine("Number is: ");
            //reverse using loop
            for(int i = count-1; i>=0; i--)
            {
                Console.Write(units[digit[i]] + " ");
            }
        }
    }
}
