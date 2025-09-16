using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        private string name;
        private int age;
        public string address;

        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Address: {address}");
        }
    }
    class EmployeeDetails : Person
    {
        private int empId;
        protected string department;
        public double salary;

        public EmployeeDetails(string name, int age, string address) : base(name, age, address)
        {
        }
        public void SetEmployee(int empId, string dept, double salary)
        {
            this.empId = empId;
            this.department = dept;
            this.salary = salary;
        }
        public void ShowEmployee()
        {
            Console.WriteLine($"EmpID: {empId}, Department: {department}, Salary: {salary}");
        }
    }
    // class Demo
    // {
    //     static void Main(string[] args)
    //     {
    //         EmployeeDetails e1 = new EmployeeDetails("soma", 20, "Birgunj");
    //         e1.SetEmployee(101, "IT", 30000);
    //         e1.ShowDetails();
    //         e1.ShowEmployee();
    //
    //         Console.WriteLine();
    //
    //         EmployeeDetails e2 = new EmployeeDetails("Sham singh", 19, "Kathmandu");
    //         e2.SetEmployee(102, "HR", 25000);
    //         e2.ShowDetails();
    //         e2.ShowEmployee();
    //     }
    // }
}
