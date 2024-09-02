// See https://aka.ms/new-console-template for more information
using CoffeeShopConsoleAppNet60.AddOns.Interfaces;
using CoffeeShopConsoleAppNet60.CoffeFolder;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World! Coffee isnt my style");
Console.WriteLine();


Coffee blackCoffee = new BlackCoffee();
Coffee cortado = new CortadoCoffee();
Coffee latte = new LatteCoffee();
Coffee icedCoffee = new IceCoffee();
Coffee frappe = new FrappeCoffee();
Coffee espresso = new EspressoCoffee();


List<Coffee> CoffeeMenu = new List<Coffee>
{
    blackCoffee,
    cortado,
    latte,
    icedCoffee,
    frappe,
    espresso,
};


foreach (Coffee coffee in CoffeeMenu)
{
    Console.WriteLine($"-Price: {coffee.Price()} Kr.");
    Console.WriteLine($"-Strength: {coffee.Strength()}." );
    if ( coffee is IMilk milkyCoffee)
    {
        Console.WriteLine($"-amount of milk: {milkyCoffee.mlMilk()} ml.");
    }
    Console.WriteLine($"-Temperature: {coffee.Temperatur()}.");
    Console.WriteLine();
}

Console.WriteLine("Only Milk Coffees");
Console.WriteLine();
foreach (Coffee coffee in CoffeeMenu)
{
    if (coffee is IMilk milkyCoffee)
    {
        Console.WriteLine($"-Price: {coffee.Price()} Kr.");
        Console.WriteLine($"-Strength: {coffee.Strength()}.");
        Console.WriteLine($"-amount of milk: {milkyCoffee.mlMilk()} ml.");
        Console.WriteLine($"-Temperature: {coffee.Temperatur()}.");
        Console.WriteLine();
    }
}
