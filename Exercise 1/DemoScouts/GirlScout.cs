using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoScouts
{
     class GirlScout
    {
        private string name;
        private int troop;
        private double owed;

        public const string motto = ("to obey the Girl Scout law");
        public GirlScout()
        {
            name = "girl";
            troop = 0;
            owed = 0;
        }

        public GirlScout(string empName, int empTroop, double empOwed)
        {
            name = empName;
            troop = empTroop;
            owed = empOwed;
        }

         public string Name {get; set;}
         public int Troop { get; set; }
         public double Owed { get; set; }
    }
}
