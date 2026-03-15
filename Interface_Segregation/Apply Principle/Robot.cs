using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.Apply_Principle
{
    internal class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Can Work");
        }
    }
}
