using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6.Device
{
    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("Стерео включено");
        }

        public void Off()
        {
            Console.WriteLine("Стерео выключено");
        }

        public void SetCD()
        {
            Console.WriteLine("Режим 'CD' включён");
        }

        public void SetVolume(int value)
        {
            Console.WriteLine("Громкость - {0}", value);
        }
    }
}
