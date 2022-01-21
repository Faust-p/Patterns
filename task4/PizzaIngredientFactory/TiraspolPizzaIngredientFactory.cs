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
    class TiraspolPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IClams CreateClams()
        {
            return new FrozenClams();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public List<IVeggie> CreateVeggies()
        {
            return new List<IVeggie>() { new Cucumber(), new Garlic() };
        }
    }
}
