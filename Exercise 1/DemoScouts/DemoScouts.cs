using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoScouts
{
    class DemoScouts
    {  
        public static void Main()
        {
            GirlScout Sally = new GirlScout();
            Sally.Name = "Sally";
            Sally.Troop = 20;
            Sally.Owed = 99999999999999;

            GirlScout Susan = new GirlScout("Susan", 20, 0);

            Console.WriteLine("Name: {0} Troop #: {1} Money owed: ${2}", Sally.Name, Sally.Troop, Sally.Owed);
            Console.WriteLine("Name: {0} Troop #: {1} Money owed: ${2}", Susan.Name, Susan.Troop, Susan.Owed);
            Console.WriteLine(GirlScout.motto);
        }
    }
}
