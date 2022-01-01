using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Singleton_Pattern
{
    public interface IDatabase
    {
        int GetPopulation(string name);
    }
}
