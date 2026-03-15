using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependacy_Invertion.Problem
{
    internal class Switch
    {
        private readonly Light _light;

        public Switch(Light light)
        {
            _light = light;
        }

        public void TurnOn()
        {
            _light.TurnOn();
        }

        public void TurnOff()
        {
            _light.TurnOff();
        }
    }
}
