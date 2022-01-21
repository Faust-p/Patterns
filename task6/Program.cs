using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task7.Adapter;
using task7.Kind_of_duck;

namespace task7
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

            mallardDuck.Dead();
            mallardDuck.Display();
            Console.WriteLine();

            WildTurkey turkey = new WildTurkey();
            TurkeyAdapter adaptedTurkey = new TurkeyAdapter(turkey);
            adaptedTurkey.Fly();
            adaptedTurkey.Quack();

            Console.ReadKey();
        }
    }
}
