using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter7Problems
{
    class Pizza
    {
        private string toppings;
        private double price;
        private int diameter;
        public string Toppings
        {
            get
            {
                return toppings;
            }
            set
            {
                toppings = value;
            }
        }

        public int Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }

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
    }
}
