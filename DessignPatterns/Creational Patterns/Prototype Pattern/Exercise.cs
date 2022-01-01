using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Prototype_Pattern
{
    public class Point
    {
        public int X, Y;

        public Point()
        {

        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point DeepCopy()
        {
            return new Point(X, Y);
        }

        public override string ToString()
        {
            return $"{nameof(X)}: {X}, {nameof(Y)}: {Y}";
        }
    }

    public class Line
    {
        public Point Start, End;

        public Line()
        {

        }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public Line DeepCopy()
        {
            return new Line(Start.DeepCopy(), End.DeepCopy());
        }

        public override string ToString()
        {
            return $"Point {nameof(Start)}: {Start}, Point {nameof(End)}: {End}";
        }
    }
}
