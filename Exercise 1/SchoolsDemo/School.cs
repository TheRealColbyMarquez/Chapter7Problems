using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolsDemo
{
    class School : IComparable
    {
        private int enrolled;
        public int Enrolled{get;set;}

         int IComparable.CompareTo(Object other)
        {
            School otherSchool = (School) other;

            if (this.Enrolled < otherSchool.Enrolled)
                return -1;
            else if (this.Enrolled > otherSchool.Enrolled)
                return 1;

            return 0;
        }

    }
}
