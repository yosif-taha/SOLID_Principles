using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.Problem
{
    public class Sqare : Rectangle
    {
        public override decimal Hight { get => base.Hight; 
            
            set { 
                base.Hight = value;
                base.Width = value;
            } 
        }
        public override decimal Width
        { get => base.Width; 
            
            set { 
                base.Width = value;
                base.Hight = value;
            } 
        }
    }
}
