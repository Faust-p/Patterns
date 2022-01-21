using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task6.Device;

namespace task6.Commands
{
    public class GarageDoorCloseCommand : ICommand
    {
        private GarageDoor garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.LightOff();
            garageDoor.Down();
        }

        public void Undo()
        {
            garageDoor.LightOn();
            garageDoor.Up();
        }
    }
}
