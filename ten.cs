using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class ten
    {
        static void Main(string[ ] args)
        {
            Console.Write("Enter your mobile number: ");
            string mobileNumber = Console.ReadLine();
            
            
            if(mobileNumber.Length <= 5)
            {
                Console.WriteLine("X");
                return;
            }
            string masked = mobileNumber.Substring(0, mobileNumber.Length - 5) + "XXXXX";
            Console.WriteLine(masked);
        }
    }
}
