using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Kind_of_duck;


namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallardDuck = new MallardDuck();
            var redheadDuck = new RedheadDuck();
            var rubberDuck = new RubberDuck();
            var decoyDuck = new DecoyDuck();

            mallardDuck.Display();
            Console.WriteLine();

            redheadDuck.Display();
            Console.WriteLine();

            rubberDuck.Display();
            Console.WriteLine();

            decoyDuck.Display();
            Console.WriteLine();

            Console.WriteLine("Убийство рыжей уточки");
            mallardDuck.Dead();
            mallardDuck.Display();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
