using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.Apply_Principle
{
    public class Rectangle : Shape
    {
        public decimal Width { get; set; }
        public decimal Hight { get; set; }
        public override decimal Area()
        {
            return Width * Hight;
        }
    }
}
