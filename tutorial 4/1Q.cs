using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Employee
    {
        private int empCode;
        private string name;
        private string designation;
        private double basicPay;

        public Employee(int empCode, string name, string designation, double basicPay)
        {
            this.empCode = empCode;
            this.name = name;
            this.designation = designation;
            this.basicPay = basicPay;
        }
        public void CalculatePay()
        {
            double hra = 0.10 * basicPay;
            double da = 0.45 * basicPay;
            double total = basicPay + hra + da;

            Console.WriteLine($"Employee Code: {empCode}, Name: {name}, Designation: {designation}");
            Console.WriteLine($"Basic Pay: {basicPay}, HRA: {hra}, DA: {da}, Total Pay: {total}");
            Console.WriteLine();
        }
    }
    // internal class Emp
    // {
    //     static void Main(string[] args)
    //     {
    //         Employee e1 = new Employee(101, "Raghuwinder", "Manager", 300000);
    //         Employee e2 = new Employee(102, "Aakriti", "Developer", 290000);
    //         Employee e3 = new Employee(103, "Priya", "Designer", 280000);

    //         e1.CalculatePay();
    //         e2.CalculatePay();
    //         e3.CalculatePay();
    //     }
    // }
}
