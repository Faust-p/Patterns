﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.Additives
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return 1.20 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " - Mocha";
        }
    }
}
