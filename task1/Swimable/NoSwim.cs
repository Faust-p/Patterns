using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Swimable
{
    class NoSwim : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("Эта уточка не умеет плавать");
        }
    }
}
