using System;

namespace OOP_Assignment_2
{

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Employee emp = new Employee(101, "Amruta", 36000);
            //Console.WriteLine("Enter Employee Number: ");
            //emp.EMPNO = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Employee name: ");
            //emp.EMPNAME = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("Enter Employee Salary: ");
            //emp.SALARY = Convert.ToDouble(Console.ReadLine());
            emp.CalculateDetails();
            emp.DisplayEmpDetails();
            Console.ReadKey();
        }
    }
}