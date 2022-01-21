using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler = ChocolateBoiler.GetInstance();
            boiler.fill();
            boiler.boil();
            boiler.drain();
            Console.ReadKey();
        }
    }
}
