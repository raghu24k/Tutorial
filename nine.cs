using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class nine
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your words: ");
            string x = Console.ReadLine();
            string result = "";

            foreach(char c in x )
            {
                if (char.IsUpper(c))
                {
                    result += char.ToLower(c);

                }
                else if (char.IsLower(c))
                {
                    result += char.ToUpper(c);
                }
                else
                {
                    result += c; // Keep non-alphabetic characters unchanged
                }

            }
            Console.WriteLine("Converted string: " + result);
        }
    }
}
