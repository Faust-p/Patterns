using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override double Cost();
    }
}
