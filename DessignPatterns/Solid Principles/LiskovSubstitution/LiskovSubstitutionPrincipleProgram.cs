using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Solid_Principles
{
    public class LiskovSubstitutionPrincipleProgram
    {
        public static void Run()
        {
            Rectangle rc = new Rectangle(2, 3);
            Console.WriteLine($"{rc} has area {Area(rc)}");

            Rectangle sq = new Square();
            sq.Width = 4;
            Console.WriteLine($"{sq} has area {Area(sq)}");
        }

        public static int Area(Rectangle r) => r.Width * r.Height;
    }
}
