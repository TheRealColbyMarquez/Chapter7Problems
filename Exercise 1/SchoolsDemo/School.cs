using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolsDemo
{
    class School : IComparable
    {
        private string school;
        private int enrolled;
        public string School
        {
            get
            {
                return school;
            }
            set
            {
                school = value;
            }
        }

        public int Enrolled
        {
            get
            {
                return enrolled;
            }
            set
            {
                enrolled = value;
            }
        }


        
    }
}
