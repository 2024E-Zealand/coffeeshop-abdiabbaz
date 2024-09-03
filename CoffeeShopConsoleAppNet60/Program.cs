// See https://aka.ms/new-console-template for more information
using CoffeeShopConsoleAppNet60;

Console.WriteLine("Hello, World!");


Console.WriteLine("================> Printing every coffee <================");
BlackCoffee BlackCoffee = new BlackCoffee();
Latte Latte = new Latte(3,"");
Cortado Cortado = new Cortado();

List<Coffee> coffees = new List<Coffee>();
coffees.Add(BlackCoffee);
coffees.Add(Latte);
coffees.Add(Cortado);

List<IMilk> OnlyMilks = new List<IMilk>();
IMilk WithMilk = new Latte();
IMilk WithMilk1 = new Cortado();

OnlyMilks.Add(WithMilk);
OnlyMilks.Add(WithMilk1);

foreach (var coffee in coffees)
{
    Console.WriteLine($"The price of coffee is {coffee.Price()} and the strength is {coffee.Strength()}");

}


