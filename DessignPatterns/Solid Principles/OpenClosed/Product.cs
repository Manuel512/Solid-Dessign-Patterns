using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Solid_Principles
{
    public class Product
    {
        public string Name { get; private set; }
        public Color Color { get; private set; }
        public Size Size { get; private set; }

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }
}
