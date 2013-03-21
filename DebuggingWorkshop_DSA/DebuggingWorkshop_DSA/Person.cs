using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DebuggingWorkshop_DSA
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        private double _powerLevel;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;

            if (name == "Carlos Ray Norris")
            {
                _powerLevel = 1.0 / 0.0;
            }
            else
            {
                _powerLevel = 1;
            }
        }

        public override string ToString()
        {
            return "Name: " + Name + ", " +
                   "Age: " + Age.ToString() + ", " +
                   "Power Level: " + _powerLevel.ToString();
        }
    }
}
