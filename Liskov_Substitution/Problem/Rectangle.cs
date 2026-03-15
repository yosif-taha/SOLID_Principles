using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.Problem
{
    public class Rectangle
    {
        public virtual decimal Width { get; set; }
        public virtual decimal Hight { get; set; }

        public decimal Area()
        {
            return Width * Hight;
        }
    }
}
