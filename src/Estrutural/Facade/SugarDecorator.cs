namespace Facade
{
    public class SugarDecorator : BeverageDecorator
    {
        public SugarDecorator(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Sugar";
        }

        public override double GetCost()
        {
            return _beverage.GetCost() + 0.20;
        }
    }
}