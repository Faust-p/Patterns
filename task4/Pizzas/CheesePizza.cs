using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.PizzaIngredientFactory;

namespace task4.Pizza
{
    class CheesePizza : Pizza
    {
        public IPizzaIngredientFactory Factory { get; }

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.Factory = ingredientFactory;
        }
        public override void Prepare()
        {
            Name = "Cheese Pizza";
            Dough = Factory.CreateDough();
            Sauce = Factory.CreateSauce();
            Cheese = Factory.CreateCheese();
        }
    }
}