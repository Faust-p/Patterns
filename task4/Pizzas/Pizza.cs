using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.Cheese;
using task4.Clams;
using task4.Dough;
using task4.Pepperoni;
using task4.Sauce;
using task4.Veggies;

namespace task4.Pizza
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public IDough Dough { get; set; }
        public ISauce Sauce { get; set; }
        public IPepperoni Pepperoni { get; set; }
        public ICheese Cheese { get; set; }
        public IClams Clams { get; set; }

        public List<IVeggie> Veggies = new List<IVeggie>();

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Baking for 35 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting pizza");
        }

        public void Box()
        {
            Console.WriteLine("Boxing pizza");
        }

    }
}
