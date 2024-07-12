using System;

namespace Facade
{
    public class Coffee : Beverage
    {
        public override string GetDescription()
        {
            return "Coffee";
        }

        public override double GetCost()
        {
            return 2.00;
        }
    }

}
