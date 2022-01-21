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
    class RedheadDuck : Duck
    {
        public RedheadDuck()
            : base(new FlyWithWings(), new DuckQuack(), new Swim_())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Это рыжая утка");
            base.Display();
        }
    }
}
