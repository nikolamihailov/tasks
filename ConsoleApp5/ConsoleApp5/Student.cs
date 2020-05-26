using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Student
    {
        public string studentName { get; set; }
        public string studentNumber { get; set; }
        public string Discipline { get; set; }

        public double Mark { get; set; }



        public Student(string name, string discipline, double mark)
        {
            this.studentName = name;
            this.Discipline = discipline;
            this.Mark = mark;
        }

        public override string ToString()
        {
            return studentName + " " + Discipline + " " + Mark;
        }
    }
}
