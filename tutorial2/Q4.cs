using System;

namespace OperatorsDemo
{
    class Q4
    {
        static void Main(string[] args)
        {
            // Input two numbers
            Console.Write("Enter number A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n=== Arithmetic Operators ===");
            Console.WriteLine("A + B = " + (A + B));   // Addition
            Console.WriteLine("A - B = " + (A - B));   // Subtraction
            Console.WriteLine("A * B = " + (A * B));   // Multiplication
            Console.WriteLine("A / B = " + ((float)A / B)); // Division (float)
            Console.WriteLine("A % B = " + (A % B));   // Modulus

            Console.WriteLine("\n=== Relational Operators ===");
            Console.WriteLine("A == B : " + (A == B));
            Console.WriteLine("A != B : " + (A != B));
            Console.WriteLine("A > B  : " + (A > B));
            Console.WriteLine("A < B  : " + (A < B));
            Console.WriteLine("A >= B : " + (A >= B));
            Console.WriteLine("A <= B : " + (A <= B));

            Console.WriteLine("\n=== Logical Operators ===");
            bool cond1 = (A > 0);
            bool cond2 = (B > 0);
            Console.WriteLine("cond1 && cond2 = " + (cond1 && cond2));
            Console.WriteLine("cond1 || cond2 = " + (cond1 || cond2));
            Console.WriteLine("!cond1 = " + (!cond1));

            Console.WriteLine("\n=== Bitwise Operators ===");
            Console.WriteLine("A & B = " + (A & B));
            Console.WriteLine("A | B = " + (A | B));
            Console.WriteLine("A ^ B = " + (A ^ B));
            Console.WriteLine("~A = " + (~A));
            Console.WriteLine("A << 1 = " + (A << 1));
            Console.WriteLine("A >> 1 = " + (A >> 1));

            Console.WriteLine("\n=== Assignment Operators ===");
            int C = A;
            Console.WriteLine("C = A → " + C);
            C += B;
            Console.WriteLine("C += B → " + C);
            C -= B;
            Console.WriteLine("C -= B → " + C);
            C *= B;
            Console.WriteLine("C *= B → " + C);
            C /= B;
            Console.WriteLine("C /= B → " + C);

            Console.WriteLine("\n=== Different Data Types ===");
            double d = (double)A / B;
            decimal dec = (decimal)A / B;
            char ch = 'X';
            string str = "Hello";
            bool flag = (A > B);

            Console.WriteLine("Double value = " + d);
            Console.WriteLine("Decimal value = " + dec);
            Console.WriteLine("Char value = " + ch);
            Console.WriteLine("String value = " + str);
            Console.WriteLine("Boolean value = " + flag);

            Console.ReadLine();
        }
    }
}
