using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment_5_6
{
    class Player
    {
        public string name;
        public int age;
        public int runsScored;

        public Player(string name, int age, int runsScored)
        {
            this.name = name;
            this.age = age;
            this.runsScored = runsScored;
        }
    }
}