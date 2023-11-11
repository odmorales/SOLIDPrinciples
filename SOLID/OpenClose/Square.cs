using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClose
{
    public class Square : Shape
    {
        public double SideLength { get; set; }
        public override double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }
}
