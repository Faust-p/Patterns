using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task6.Device;

namespace task6.Commands
{
    public class CeilingFanOffCommand : ICommand
    {
        private CeilingFan ceilingFan;
        private int prevSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.Off();
        }

        public void Undo()
        {
            if (prevSpeed == ceilingFan.high)
            {
                ceilingFan.High();
            }
            else if (prevSpeed == ceilingFan.medium)
            {
                ceilingFan.Medium();
            }
            else if (prevSpeed == ceilingFan.low)
            {
                ceilingFan.Low();
            }
            else if (prevSpeed == ceilingFan.off)
            {
                ceilingFan.Low();
            }
        }
    }
}
