using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            School[] school = new School[5];
            
            for (int i = 0; i < school.Length; i++)
           {
               Console.WriteLine("Input enrollment size of school {0}", i);
                string input = Console.ReadLine();
                int enrollment = Convert.ToInt32(input);
                school[i] = new School();

                school[i].Enrolled = enrollment;
            }
        }
    }
}
