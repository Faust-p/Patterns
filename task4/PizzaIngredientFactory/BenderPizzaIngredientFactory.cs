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

namespace task4.PizzaIngredientFactory
{
    class BenderyPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ICheese CreateCheese()
        {
            return new MozarellaCheese();
        }

        public IClams CreateClams()
        {
            return new FreshClams();
        }
        public IPepperoni CreatePepperoni()
        {
            return new NonSlicedPepperoni();
        }

        public List<IVeggie> CreateVeggies()
        {
            return new List<IVeggie>() { new BellPeper(), new Onion() };
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }
    }
}
