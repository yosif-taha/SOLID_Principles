using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependacy_Invertion.Apply_Principle
{
    public class Switch
    {
        private readonly IDevice _device;
        public Switch(IDevice device)
        {
            _device = device;
        }
        public void TurnOn()
        {
            _device.TurnOn();
        }
        public void TurnOff()
        {
            _device.TurnOff();
        }
    }
}
