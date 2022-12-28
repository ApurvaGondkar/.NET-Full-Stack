using System;

namespace OOP_Assignment_2
{
    class Program
    {
    static void Main(string[] args)
    {
    Console.WriteLine("Simple C# Class !");
    Employee emp = new Employee();
    Console.WriteLine("Enter employee no :");
    emp.Empno = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter employee name :");
    emp.Empname = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Enter employee salary :");
    emp.Salary = Convert.ToDouble(Console.ReadLine());
    emp.CalculateDetails();
    emp.DisplayEmpDetails();
    Console.ReadKey();



            }
        }
}
