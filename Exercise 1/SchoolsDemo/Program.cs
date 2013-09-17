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
               Console.Write("Input enrollment size of school {0}: ", i);
                string input = Console.ReadLine();
                int enrollment = Convert.ToInt32(input);
                school[i] = new School();
                school[i].Enrolled = enrollment;
            }

            Array.Sort(school);
            Console.WriteLine("Sorted Schools:");
            for (int i = 0; i < school.Length; i++)
            {
                Console.WriteLine("{0}", school[i].Enrolled);
            }

                Console.Write("Minimum enrollment size: ");
                string MinEnroll = Console.ReadLine();
                int minEnroll = Convert.ToInt32(MinEnroll);

            for (int i = 0; i < school.Length; i++)
            {
                
                if (school[i].Enrolled >= minEnroll)
                    Console.WriteLine(school[i].Enrolled);
            }
        }
    }
}
