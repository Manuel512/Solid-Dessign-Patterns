using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Structural_Patterns.Adapter
{
    /*You are given an IRectangle interface and an extension method on it.
     * Try to define a SquareToRectangleAdapter 
     * that adapts the Square to the IRectangle interface.
     */
    public class Square
    {
        public int Side;
    }

    public interface IRectangle
    {
        int Width { get; }
        int Height { get; }
    }

    public static class ExtensionMethods
    {
        public static int Area(this IRectangle rc)
        {
            return rc.Width * rc.Height;
        }
    }

    public class SquareToRectangleAdapter : IRectangle
    {
        private int width;
        private int height;
        public SquareToRectangleAdapter(Square square)
        {
            height = width = square.Side;
        }

        public int Width => width;

        public int Height => height;
    }
}
