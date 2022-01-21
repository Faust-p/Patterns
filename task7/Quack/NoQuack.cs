using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7.Quack
{
    public class NoQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Эта уточка не крякает");
        }
    }
}
