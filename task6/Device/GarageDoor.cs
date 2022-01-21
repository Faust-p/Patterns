using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6.Device
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Дверь в гараже поднята");
        }

        public void Down()
        {
            Console.WriteLine("Дверь в гараже отпущена");
        }

        public void Stop()
        {
            Console.WriteLine("Дверь остановлена");
        }

        public void LightOn()
        {
            Console.WriteLine("Свет в гараже включён");
        }

        public void LightOff()
        {
            Console.WriteLine("Свет в гараже выключен");
        }
    }
}
