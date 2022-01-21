using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task7.Swimable;
using task7.Fly;
using task7.Quack;

namespace task7.Kind_of_duck
{
    class RubberDuck : Duck
    {
        public RubberDuck()
            : base(new FlyNoWay(), new RubberDuckQuack(), new Swim_())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Это резиновая утка");
            base.Display();
        }
    }
}
