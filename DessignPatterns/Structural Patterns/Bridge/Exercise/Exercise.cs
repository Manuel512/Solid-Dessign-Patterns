using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Structural_Patterns.Bridge.Exercise
{
    public interface IRenderer
    {
        string WhatToRenderAs { get; }
    }

    public class VectorRenderer : IRenderer
    {
        public string WhatToRenderAs => "lines";
    }

    public class RasterRenderer : IRenderer
    {
        public string WhatToRenderAs => "pixels";
    }

    public abstract class Shape
    {
        protected IRenderer _renderer;
        public string Name { get; set; }

        public Shape(IRenderer renderer)
        {
            _renderer = renderer;
        }
    }

    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer) => Name = "Triangle";

        public override string ToString() => $"Drawing {Name} as {_renderer.WhatToRenderAs}";
    }

    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer) => Name = "Square";

        public override string ToString() => $"Drawing {Name} as {_renderer.WhatToRenderAs}";
    }

    //public class VectorSquare : Square
    //{
    //    public override string ToString() => "Drawing {Name} as lines";
    //}

    //public class RasterSquare : Square
    //{
    //    public override string ToString() => "Drawing {Name} as pixels";
    //}
}
