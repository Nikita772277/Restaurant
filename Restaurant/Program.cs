

using Restaurant;

WorkRestaurant workRestaurant = new();
workRestaurant.Transformation();
workRestaurant.Get();
void Memu()
{
    Console.WriteLine($"Меню ресторана");
    Console.WriteLine();
    Console.WriteLine($"1. Burger");
    Console.WriteLine($"2. Fries");
    Console.WriteLine($"3. Chicken");
    Console.WriteLine($"4. Pizza");
    Console.WriteLine($"5. Sandwich");
    Console.WriteLine($"6. Onionrings");
    Console.WriteLine($"7. Milkshake");
    Console.WriteLine($"8. Coke");
    Console.WriteLine();
}