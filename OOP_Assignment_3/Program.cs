using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment_3
{
    public class Employee
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

        public virtual void CalculateDetails()

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
        }

        class Manager : Employee
        {
        double PetrolA;
        double FoodA;
        double OtherA;
        double grosssalary;

            public new void CalculateGross()

            {
                PetrolA = Salary * 8 / 100;
                FoodA = Salary * 13 / 100;
                OtherA = Salary * 3 / 100;
                base.CalculateDetails();
                grosssalary = grosssalary + PetrolA + FoodA + OtherA;
            }
            public override void CalculateDetails()

            {
                double gs = Grosssalary;
                pf = grosssalary / 10;
                tds = grosssalary / 18;
                Netsalary = grosssalary - (pf + tds);


            }
            public new  void display()
            {
                Console.WriteLine("Emp No is :" + Empno);
                Console.WriteLine("Emp Name is :" + Empname);
                Console.WriteLine("Emp salary is :" + Salary);
                Console.WriteLine("Emp hra is :" + hra);
                Console.WriteLine("Emp ta is :" + ta);
                Console.WriteLine("Emp da is :" + da);
                Console.WriteLine("Emp pf is :" + pf);
                Console.WriteLine("Emp tds is :" + tds);
                Console.WriteLine("Emp gs is :" + grosssalary);
                Console.WriteLine("Emp netsalery is :" + Netsalary);
                Console.WriteLine("Emp petrol is :" + PetrolA);
                Console.WriteLine("Emp Food is :" + FoodA);
                Console.WriteLine("Emp Other is :" + OtherA);
            }
 }
        class MarketingExecutive : Employee

        {
            double kmtravel;
            double tourallowance;
            double teleallowance;
            double gs;

            public void CalculateGross()
            {
                Console.WriteLine("Enter km travel :" );
                kmtravel = Convert.ToDouble(Console.ReadLine());
                tourallowance = 5 * kmtravel;
                teleallowance = 1000;
                base.CalculateDetails();
                Grosssalary = kmtravel + tourallowance + teleallowance;
                gs = Grosssalary;

            }
            public override void CalculateDetails()


            {
                pf = (10 * gs) / 100;
                tds = (18 * gs) / 100;
                Netsalary = gs - (pf + tds);

            }
            public void displaymarketing()
            {
               
                Console.WriteLine("Emp tourallowance is :" + tourallowance);
                Console.WriteLine("Emp teleallowance is :" + teleallowance);
                

            }
              
              
            }
        
           public static void Main(string[] args)
            {
            //Console.WriteLine("Simple C# Class !");
                Manager A = new Manager();
                MarketingExecutive B = new MarketingExecutive();

                Console.WriteLine("Enter employee no :");
                A.Empno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter employee name :");
                A.Empname = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter employee salary :");
                A.Salary = Convert.ToDouble(Console.ReadLine());
                A.CalculateGross();
                A.CalculateDetails();
                A.display();

            Console.WriteLine("Enter employee no :");
            B.Empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name :");
            B.Empname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter employee salary :");
            B.Salary = Convert.ToDouble(Console.ReadLine());
            B.CalculateGross();
            B.CalculateDetails();
            B.displaymarketing();
            Console.ReadKey();



        }


        }
    }


    

      
