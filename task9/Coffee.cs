using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Brew coffee");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Add milk");
        }
    }
}
