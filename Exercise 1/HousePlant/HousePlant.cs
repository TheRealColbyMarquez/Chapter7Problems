using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HousePlant
{
    class HousePlant
    {
        private double price;
        private string name;
        private bool fed;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public bool Fed
        {
            get
            {
                return fed;
            }
            set
            {
                fed = value;
            }
        }
    }
}
