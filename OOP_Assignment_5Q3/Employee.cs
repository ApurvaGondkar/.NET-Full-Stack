using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment_5_3
{
    class Employee
    {
        public string name;
        public Employee(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return (name);
        }
    }
}