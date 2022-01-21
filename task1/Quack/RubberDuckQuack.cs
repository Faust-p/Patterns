using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Quack
{
    public class RubberDuckQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Резиновая уточка крякает по другому.");
        }
    }
}
