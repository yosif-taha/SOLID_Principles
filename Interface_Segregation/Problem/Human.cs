using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.Problem
{
    internal class Human : IWorker
    {
        public void Eat()
        {
            Console.WriteLine("Human Can Eat");
        }

        public void Work()
        {
            Console.WriteLine("Human Can Work");
        }
    }
}
