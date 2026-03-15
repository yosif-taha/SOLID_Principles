using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependacy_Invertion.Problem
{
    internal class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is off");
        }
    }
}
