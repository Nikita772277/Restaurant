using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class WorkRestaurant
    {
        private static string[] strings = new string[8] { "Burger", "Fries", "Chicken", "Pizza", "Sandwich", "Onionrings", "Milkshake", "Coke" };
        private List<string> faw = new();
        public void Transformation()
        {
            string enter = Console.ReadLine();            
            foreach (string s in strings)
            {
                var trans= s.ToLower();
                var a = enter.Contains(trans);                
                if (a)
                {
                    faw.Add(s);
                }
            }
        }
        public void Get()
        {
            foreach(string s in faw)
            {                
                int g= 0;
                foreach(var a in s)
                {
                    if (g < 1)
                    {
                        var c = char.ToUpper(a);
                        Console.Write($"{c}");
                    }
                    else if (g >= 1)
                    {
                        Console.Write(a);
                    }
                    g++;                    
                }
                Console.Write(" ");
            }
        }
    }
}
