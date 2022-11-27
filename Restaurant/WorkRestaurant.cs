using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class WorkRestaurant
    {
        public static string[] _restaurantmenu = new string[8] { "Burger", "Fries", "Chicken", "Pizza", "Sandwich", "Onionrings", "Milkshake", "Coke" };
        private List<string> _ordering;
        public void Transformation()
        {
            _ordering = new();
            Console.WriteLine();
            Console.WriteLine($"Введите ваш заказ");
            string enter = Console.ReadLine();
            foreach (string orderpoint in _restaurantmenu)
            {
                string trans = orderpoint.ToLower();
                bool exists = enter.Contains(trans);
                if (exists)
                {
                    _ordering.Add(orderpoint);
                }
            }
        }
        public void Get()
        {
            Console.Write($"Ваш заказ: ");
            foreach (string orderpoint in _ordering)
            {
                int number = 0;
                foreach (var symbol in orderpoint)
                {
                    if (number < 1)
                    {
                        var firstsymbol = char.ToUpper(symbol);
                        Console.Write($"{firstsymbol}");
                    }
                    else if (number >= 1)
                    {
                        Console.Write(symbol);
                    }
                    number++;
                }
                Console.Write(" ");
            }
        }
    }
}
