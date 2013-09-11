using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HousePlant
{
    class DisplayHousePlant
    {
        public static void Main()
        {
            HousePlant rose = new HousePlant();
            rose.Name = "rose";
            rose.Price = 5.00;
            rose.Fed = true;

            HousePlant tulip = new HousePlant();
            tulip.Name = "tulip";
            tulip.Price = 3.00;
            tulip.Fed = false;

            HousePlant daisy = new HousePlant();
            daisy.Name = "daisy";
            daisy.Price = 4.00;
            daisy.Fed = true;
        }
    }
}
