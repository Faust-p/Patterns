using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.PizzaIngredientFactory;

namespace task4.Pizza
{
    class PepperoniPizza : Pizza
    {
        public IPizzaIngredientFactory Factory { get; }
        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.Factory = ingredientFactory;
        }

        public override void Prepare()
        {
            Dough = Factory.CreateDough();
            Sauce = Factory.CreateSauce();
            Pepperoni = Factory.CreatePepperoni();
        }
    }
}
