using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.PizzaIngredientFactory;

namespace task4.Pizza
{
    class ClamPizza : Pizza
    {
        public IPizzaIngredientFactory Factory { get; }
        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.Factory = ingredientFactory;
        }
        public override void Prepare()
        {
            Name = "Clam Pizza";
            Dough = Factory.CreateDough();
            Sauce = Factory.CreateSauce();
            Clams = Factory.CreateClams();
        }
    }
}
