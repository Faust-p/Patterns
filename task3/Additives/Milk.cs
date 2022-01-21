using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.Additives
{
    public class Milk : CondimentDecorator
    {
        Beverage beverage;
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return 1.80 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " - Milk";
        }
    }
}
