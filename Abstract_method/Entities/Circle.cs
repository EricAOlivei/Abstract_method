using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_method.Entities.Enum;

namespace Abstract_method.Entities
{
    internal class Circle : Shape
    {
        public double Radious { get; set; }

        public Circle()
        {
        }

        public Circle(Color color, double radius)
            : base(color)
        {
            Radious = radius;
        }
    }
}
