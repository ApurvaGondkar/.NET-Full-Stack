using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment_2
{
    class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double hra;
        private double ta;
        private double da;
        private double pf;
        private double tds;
        private double NetSalary;
        private double GrossSalary;
        public int EMPNO { get; set; }
        public string EMPNAME { get; set; }
        public double SALARY { get; set; }
        public double HRA { get; set; }
        public double TA { get; set; }
        public double DA { get; set; }
        public double PF { get; set; }
        public double TDS { get; set; }
        public double NETSALARY { get; set; }
        public double GROSSSALARY { get; set; }

        public Employee(int EmpNo, String EmpName, double Salary)
        //int EmpNo, string EmpName, double Salary, double hra, double ta, double da, double pf, double tds, double NetSalary, double GrossSalary
        {
            this.EMPNO = EmpNo;
            this.EMPNAME = EmpName;
            this.SALARY = Salary;
            this.HRA = hra;
            this.TA = ta;
            this.DA = da;
            this.PF = pf;
            this.TDS = tds;
            this.NETSALARY = NetSalary;
            this.GROSSSALARY = GrossSalary;
        }
        public void DisplayEmpDetails()
        {
            Console.WriteLine("The Emp No is " + EMPNO);
            Console.WriteLine("The Emp Name is " + EMPNAME);
            Console.WriteLine("The Emp Salary is " + SALARY);
            Console.WriteLine("The Emp HRA is " + HRA);
            Console.WriteLine("The Emp TA is " + TA);
            Console.WriteLine("The Emp DA is " + DA);
            Console.WriteLine("The Emp PF is " + PF);
            Console.WriteLine("The Emp TDS is " + TDS);
            Console.WriteLine("The Emp Gross Salary is " + GROSSSALARY);
            Console.WriteLine("The Emp Net Salary is " + NETSALARY);
            //Console.WriteLine("The Emp Id is  " + EMPNO + " The Emp Name is " + EMPNAME + " The Emp Salary is " + SALARY + " The Emp HRA is " + HRA + " The Emp TA is " + TA + " The Emp DA is " + DA + " The Emp PF is " + PF + " The Emp TDS is " + TDS + " The Emp Netsalary is " + NETSALARY + " The Emp gross salary is " + GROSSSALARY);
        }
        public void CalculateDetails()
        {
            if (SALARY < 5000)
            {
                HRA = (10 * SALARY) / 100;
                TA = (5 * SALARY) / 100;
                DA = (15 * SALARY) / 100;
                GROSSSALARY = SALARY + HRA + TA + DA;
                PF = (10 * GROSSSALARY) / 100;
                TDS = (18 * GROSSSALARY) / 100;
                NETSALARY = GROSSSALARY - (PF + TDS);


            }
            else if (SALARY < 10000)
            {
                HRA = (15 * SALARY) / 100;
                TA = (10 * SALARY) / 100;
                DA = (20 * SALARY) / 100;
                GROSSSALARY = SALARY + HRA + TA + DA;
                PF = (10 * GROSSSALARY) / 100;
                TDS = (18 * GROSSSALARY) / 100;
                NETSALARY = GROSSSALARY - (PF + TDS);
            }
            else if (SALARY < 15000)
            {
                HRA = (20 * SALARY) / 100;
                TA = (15 * SALARY) / 100;
                DA = (25 * SALARY) / 100;
                GROSSSALARY = SALARY + HRA + TA + DA;
                PF = (10 * GROSSSALARY) / 100;
                TDS = (18 * GROSSSALARY) / 100;
                NETSALARY = GROSSSALARY - (PF + TDS);
            }
            else if (SALARY < 20000)
            {
                HRA = (25 * SALARY) / 100;
                TA = (20 * SALARY) / 100;
                DA = (30 * SALARY) / 100;
                GROSSSALARY = SALARY + HRA + TA + DA;
                PF = (10 * GROSSSALARY) / 100;
                TDS = (18 * GROSSSALARY) / 100;
                NETSALARY = GROSSSALARY - (PF + TDS);
            }
            else if (SALARY >= 20000)
            {
                HRA = (30 * SALARY) / 100;
                TA = (25 * SALARY) / 100;
                DA = (35 * SALARY) / 100;
                GROSSSALARY = SALARY + HRA + TA + DA;
                PF = (10 * GROSSSALARY) / 100;
                TDS = (18 * GROSSSALARY) / 100;
                NETSALARY = GROSSSALARY - (PF + TDS);
            }

        }
    }
}