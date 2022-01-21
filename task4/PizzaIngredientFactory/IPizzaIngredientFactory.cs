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
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ICheese CreateCheese();
        IClams CreateClams();
        ISauce CreateSauce();
        IPepperoni CreatePepperoni();
        List<IVeggie> CreateVeggies();
    }
}
