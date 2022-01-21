using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task6.Device;
using task6.Commands;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Light light = new Light();

            LightOnCommand onLight = new LightOnCommand(light);
            LightOffCommand offLight = new LightOffCommand(light);

            remoteControl.SetCommand(0, onLight, offLight);
            remoteControl.PushOnButton(0);
            remoteControl.PushOffButton(0);
            Console.ReadKey();
        }
    }
}
