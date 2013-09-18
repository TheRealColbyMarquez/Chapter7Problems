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
            Friend[] friend = new Friend[3];
            for (int i = 0; i < friend.Length; i++)
            {
                
                Console.WriteLine("input friend {0}'s name", i + 1);
                string Name = Console.ReadLine();

                Console.WriteLine("input friend {0}'s phone number",i + 1);
                string Number = Console.ReadLine();

                Console.WriteLine("input friend {0}'s birth month",i + 1);
                string Month = Console.ReadLine();

                Console.WriteLine("input friend {0}'s day of birth",i + 1);
                string Day = Console.ReadLine();

                Console.WriteLine("input friend {0}'s year of birth",i + 1);
                string Year = Console.ReadLine();

                int nUMBER = Convert.ToInt32(Number);
                int mONTH = Convert.ToInt32(Month);
                int yEAR = Convert.ToInt32(Year);
                int dAY = Convert.ToInt32(Day);

                friend[i] = new Friend();

                friend[i].Name = Name;

                friend[i].Number = nUMBER;

                friend[i].Day = dAY;

                friend[i].Month = mONTH;

                friend[i].Year = yEAR;
            }

            Array.Sort(friend);
            Console.WriteLine("Friends: ");
                for (int i = 0; i < friend.Length; i++)
                {
                    Console.WriteLine(friend[i].Name);
                }
            
            Friend searchFriends = new Friend();
            searchFriends.Name = Console.ReadLine();
            int x = (Array.BinarySearch(friend, searchFriends));

            Console.WriteLine("{0}'s phone number is {1}", friend[x].Name, friend[x].Number);
            Console.WriteLine("{0}'s date of birth is {1}/{2}/{3}", friend[x].Name, friend[x].Month, friend[x].Day, friend[x].Year);
        }
        
    }
}
