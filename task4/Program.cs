using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using task4.PizzaStore;

namespace task4
{
    class Program
    {
        static void Main()
        {
            BenderyPizzaStore benderyPizzaStore = new BenderyPizzaStore();
            var a = benderyPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"{a.Name} is ready");
        }
    }
}
