using System;

namespace Facade
{
    public class MilkDecorator : BeverageDecorator
    {
        public MilkDecorator(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Milk";
        }

        public override double GetCost()
        {
            return _beverage.GetCost() + 0.50;
        }
    }
}
