using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Swimable;
using task1.Fly;
using task1.Quack;

namespace task1.Kind_of_duck
{
    class MallardDuck : Duck
    {
        public MallardDuck()
            : base(new FlyWithWings(), new DuckQuack(), new Swim_())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Это селезень");
            base.Display();
        }
    }
}
