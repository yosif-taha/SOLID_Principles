using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.Apply_Principle
{
    public class Sqare : Shape
    {
        public decimal Side { get; set; }
        public override decimal Area()
        {
            return Side * Side;
        }
    }
}
