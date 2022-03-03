using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_method.Entities.Enum;

namespace Abstract_method.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public List<Shape> Shapes { get; set; } = new List<Shape>();

        public Shape()
        {
        }

        protected Shape(Color color)
        {
            Color = color;
        }

        public void AddShape(Shape shape)
        {
            Shapes.Add(shape);
        }

        public void RemoveShape(Shape shape)
        {
            Shapes.Remove(shape);
        }

        public abstract double Area();

    }
}
