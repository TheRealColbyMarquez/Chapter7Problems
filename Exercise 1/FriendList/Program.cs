using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FriendList
{
    class Program
    {
        static void Main(string[] args)
        {
            Friend[] friend = new Friend[8];
            for (int i = 0; i < friend.Length; i++)
            {
                Console.WriteLine("input friends name");
                string Name = Console.ReadLine();

                Console.WriteLine("input friends phone number");
                string Number = Console.ReadLine();

                Console.WriteLine("input friends birth month");
                string Month = Console.ReadLine();

                Console.WriteLine("input friends day of birth");
                string Day = Console.ReadLine();

                Console.WriteLine("input friends year of birth");
                string Year = Console.ReadLine();

                int nUMBER = Convert.ToInt32(Number);
                int mONTH = Convert.ToInt32(Month);
                int yEAR = Convert.ToInt32(Year);
                int dAY = Convert.ToInt32(Day);

                friend[i] = new Friend();
                friend[i].Name = Name;

            }
        }
    }
}
