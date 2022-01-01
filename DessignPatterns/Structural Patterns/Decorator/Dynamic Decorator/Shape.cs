﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Structural_Patterns.Decorator.Dynamic_Decorator
{
    public interface IShape
    {
        string AsString();
    }

    public class Circle : IShape
    {
        private float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public void Resize(float factor)
        {
            radius *= factor;
        }

        public string AsString() => $"A circle with radius {radius}";
    }

    public class Square : IShape
    {
        private float side;

        public Square(float side)
        {
            this.side = side;
        }

        public string AsString() => $"A square with side {side}";
    }

    public class ColorShape : IShape
    {
        private IShape shape;
        private string color;

        public ColorShape(IShape shape, string color)
        {
            this.shape = shape;
            this.color = color;
        }

        public string AsString() => $"{shape.AsString()} has the color {color}";
    }

    public class TransparentShape : IShape
    {
        private IShape shape;
        private float transparency;

        public TransparentShape(IShape shape, float transparency)
        {
            this.shape = shape;
            this.transparency = transparency;
        }

        public string AsString() => $"{shape.AsString()} has {transparency * 100.0}% transparency";
    }


}
