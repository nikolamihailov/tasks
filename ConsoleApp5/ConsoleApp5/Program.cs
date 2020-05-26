using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stuDictionary = new Dictionary<string, string>();
            List<Student> students = new List<Student>();
            while (true)
            {
                string input = Console.ReadLine();
                if(input.ToLower() == "end")
                {
                    break;

                }
                string[] data = input.Split(new string[] { "=>" }, StringSplitOptions.RemoveEmptyEntries);
                string discipline = data[0];
                string name = data[1];
                string number = data[2];
                double mark = double.Parse(data[3]);
                

                Student stu = new Student(name, discipline, mark);

                try
                {
                    stuDictionary.Add(number, stu.Discipline);
                }
                catch(Exception)
                {
                    continue;
                }

                students.Add(stu);
             }
           
            foreach (var student in students.OrderByDescending(m => m.Mark))
            {
                Console.WriteLine(student);
                
            }
        }
    }
}
