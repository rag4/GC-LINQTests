using System;
using System.Collections.Generic;
using System.Text;

namespace LINQLabDemo
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool CanDrink => Age >= 21;

        public Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
