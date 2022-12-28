using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment_3
{
    class Employee
    {
        private int empno;
        private string empname;
        private double salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double netsalary;
        private double grosssalary;
        public int Empno { get; set; }
        public string Empname { get; set; }
        public double Salary { get; set; }
        public double hra { get; set; }
        public double ta { get; set; }
        public double da { get; set; }
        public double pf { get; set; }
        public double tds { get; set; }
        public double Netsalary { get; set; }
        public double Grosssalary { get; set; }

        public Employee()
        //(int empno, string empname, double salary, double HRA, double TA, double DA, double PF, double TDS, double netsalary, double grosssalary)

        {
            this.pf = PF;
            this.tds = TDS;
            this.Netsalary = netsalary;
            this.grosssalary = Grosssalary;

        }

        public void DisplayEmpDetails()
        {
            Console.WriteLine("The Emp NO is " + Empno + " The Emp Name is " + Empname + " The Emp Salary is " + Salary + " The Emp hra is " + hra + " The Emp ta is " + ta + " The Emp da is " + da + " The Emp pf is " + pf + " The Emp tds is " + tds + "The Emp Netsalary is " + Netsalary + "The Emp net Grosssalary is" + Grosssalary);
        }

        public void CalculateDetails()

        {
            if (Salary < 5000)
            {
                hra = (Salary * 10) / 100;
                ta = (Salary * 5) / 100;
                da = (Salary * 15) / 100;
                grosssalary = (Salary + hra + ta + da);
                pf = (grosssalary * 10 / 100);
                tds = (grosssalary * 18 / 100);
                Netsalary = (pf + tds);
            }
            if (Salary < 10000)
            {
                hra = (Salary * 15) / 100;
                ta = (Salary * 10) / 100;
                da = (Salary * 20) / 100;
                grosssalary = (Salary + hra + ta + da);
                pf = (grosssalary * 10 / 100);
                tds = (grosssalary * 18 / 100);
                Netsalary = (pf + tds);
            }
            if (Salary < 15000)
            {
                hra = (Salary * 20) / 100;
                ta = (Salary * 15) / 100;
                da = (Salary * 25) / 100;
                grosssalary = (Salary + hra + ta + da);
                pf = (grosssalary * 10 / 100);
                tds = (grosssalary * 18 / 100);
                Netsalary = (pf + tds);
            }
            if (Salary < 20000)
            {
                hra = (Salary * 25) / 100;
                ta = (Salary * 20) / 100;
                da = (Salary * 30) / 100;
                grosssalary = (Salary + hra + ta + da);
                pf = (grosssalary * 10 / 100);
                tds = (grosssalary * 18 / 100);
                Netsalary = (pf + tds);
            }
            if (Salary >= 20000)
            {
                hra = (Salary * 30) / 100;
                ta = (Salary * 25) / 100;
                da = (Salary * 35) / 100;
                grosssalary = (Salary + hra + ta + da);
                pf = (grosssalary * 10 / 100);
                tds = (grosssalary * 18 / 100);
                Netsalary = (pf + tds);
            }
        
        class Manager :Employee
    {
        double Petrol A;
        double Food A;
        double Other A;
        double gs;

        public new void CalculateGross()

            {
                Petrol A = Salary * 8 / 100;
                Food A = Salary * 13 / 100;
                Other A = Salary * 3 / 100;
                base.CalculateEmpDetails();
                gs=gs + Petrol A + Food A + Other A;
            }
            public override void CalculateEmpDetails()

            {
                double gs = Grosssalary;
                pf = gs / 10;
                tds = gs / 18;
                Netsalary = gs - (pf + tds);


            }
            public void display()
            {
                Console.WriteLine("Emp No is :" + Empno);
                Console.WriteLine("Emp Name is :" + Empname);
                Console.WriteLine("Emp salaer is :" + Salary);
                Console.WriteLine("Emp salaer is :" + HRA);
                Console.WriteLine("Emp salaer is :" + TA);
                Console.WriteLine("Emp salaer is :" + DA);
                Console.WriteLine("Emp salaer is :" + PF);
                Console.WriteLine("Emp salaer is :" + TDS);
                Console.WriteLine("Emp salaer is :" + Grosssalary);
                Console.WriteLine("Emp salaer is :" + Netsalary);
            }





            }

    }
}