using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.PizzaIngredientFactory;

namespace task4.Pizza
{
    class VeggiePizza : Pizza
    {
        public IPizzaIngredientFactory Factory { get; }

        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.Factory = ingredientFactory;
        }
        public override void Prepare()
        {
            Name = "Veggie Pizza";
            Dough = Factory.CreateDough();
            Sauce = Factory.CreateSauce();
            Veggies = Factory.CreateVeggies();
        }
    }
}
