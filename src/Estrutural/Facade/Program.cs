using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Coffee();
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.GetCost()}");

            beverage = new MilkDecorator(beverage);
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.GetCost()}");

            beverage = new SugarDecorator(beverage);
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.GetCost()}");

            beverage = new SugarDecorator(beverage); // Adding another sugar
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.GetCost()}");
        }
    }
}
