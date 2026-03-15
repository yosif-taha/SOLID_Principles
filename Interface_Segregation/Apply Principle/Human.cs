using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.Apply_Principle
{
    internal class Human : IWorker, IEatable
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
