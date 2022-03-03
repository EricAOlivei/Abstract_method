using System;
using System.Collections.Generic;
using System.Globalization;
using Abstract_method.Entities;
using Abstract_method.Entities.Enum;

namespace Abstract_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine())

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Rectangle or Circle (r/c)? ");
                char s = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (s == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Heigth: ");
                    double heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(color, width, heigth));
                }
                else
                {
                    Console.Write("Radius: ");
                    double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(color, r));
                }
            }
        }
    }
}