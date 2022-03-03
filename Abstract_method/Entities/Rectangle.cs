using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_method.Entities.Enum;

namespace Abstract_method.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Heigth { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(Color color, double width, double heigth)
            : base(color)
        {
            Width = width;
            Heigth = heigth;
        }

        public override double Area()
        {
            return Width * Heigth;
        }
    }
}
