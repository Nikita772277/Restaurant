using Restaurant;

WorkRestaurant workRestaurant = new();

void Menu()
{
    var menu = WorkRestaurant._restaurantmenu;
    Console.WriteLine($"Меню ресторана:");
    Console.WriteLine();
    for (int i = 0; i < menu.Length; i++)
    {
        Console.WriteLine($"{i + 1}) {menu[i]}");
    }
}
void UseMenu()
{
    while (true)
    {
        Menu();
        workRestaurant.Transformation();
        workRestaurant.Get();
    }
}
UseMenu();