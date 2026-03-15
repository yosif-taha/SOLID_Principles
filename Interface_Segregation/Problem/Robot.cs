using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.Problem
{
    internal class Robot : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();  // Robot does not eat, but it is forced to implement this method due to the IWorker interface
        }
        public void Work()
        {
            Console.WriteLine("Robot Can Work");
        }
    {
    }
}
