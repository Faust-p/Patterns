using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    public class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Brew tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Add sugar");
        }
    }
}
