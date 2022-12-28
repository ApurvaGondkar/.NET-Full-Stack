using System;
using System.Collections;



namespace OOP_Assignment_5
{
    class Program
    {



        static void Main(string[] args)
        {
            ArrayList MyList = new ArrayList(3);
            Console.WriteLine("Enter Information Of Employee");





            int EmpId = Convert.ToInt32(Console.ReadLine());
            string EmpName = Convert.ToString(Console.ReadLine());
            double EmpSalary = Convert.ToDouble(Console.ReadLine());
            MyList.Add(EmpId);
            MyList.Add(EmpName);
            MyList.Add(EmpSalary);
            foreach (object obj in MyList)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
    }
}