using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Structural_Patterns.Decorator.Inheritance_with_default_interface
{
    public interface ICreature
    {
        int Age { get; set; }
    }

    interface IBird : ICreature
    {
        void Fly()
        {
            if (Age >= 10)
            {
                Console.WriteLine("I am Flying");
            }
        }
    }

    public interface ILizard: ICreature
    {
        void Crawl()
        {
            if (Age < 10)
            {
                Console.WriteLine("I am crawling");
            }
        }
    }

    public class Organism
    {

    }

    public class Dragon : Organism, ICreature, IBird, ILizard
    {
        public int Age { get; set; }
    }

    //inheritance
    // SmartDragon(Dragon)
    // extension method
    // C#8 default interface methods
}
