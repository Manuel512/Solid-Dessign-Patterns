using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Structural_Patterns.Decorator
{
    public interface IBird
    {
        int Weight { get; set; }

        void Fly();
    }

    public class Bird : IBird
    {
        public int Weight { get; set; }        
        public void Fly()
        {
            Console.WriteLine($"Soaring in the sky with weight {Weight}");
        }
    }

    public interface ILizard
    {
        int Weight { get; set; }

        void Crawl();
    }

    public class Lizard : ILizard
    {
        public int Weight { get; set; }
        public void Crawl()
        {
            Console.WriteLine($"Crawling in the dragon with weight {Weight}");
        }
    }

    //Dragon : Bird, Lizard can't do this
    public class Dragon : IBird, ILizard
    {
        private IBird _bird = new Bird();
        private ILizard _lizard = new Lizard();
        private int weight;

        public int Weight { 
            get => weight;
            set 
            { 
                weight = value;
                _bird.Weight = value;
                _lizard.Weight = value;
            }
        }

        public void Crawl()
        {
            _lizard.Crawl();
        }

        public void Fly()
        {
            _bird.Fly();
        }

        void ILizard.Crawl()
        {
            throw new NotImplementedException();
        }

        void IBird.Fly()
        {
            throw new NotImplementedException();
        }
    }
}
