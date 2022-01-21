using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.Beverages;
using task3.Additives;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine("{0} = {1}$", beverage.GetDescription(), beverage.Cost());
            beverage = new Decaf();
            beverage = new Soy(beverage);
            beverage = new Mocha(beverage);
            Console.WriteLine("{0} = {1}$", beverage.GetDescription(), beverage.Cost());
            Console.ReadKey();
        }
    }
}
