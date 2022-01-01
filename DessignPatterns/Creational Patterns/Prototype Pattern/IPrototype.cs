using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Prototype_Pattern
{
    public interface IPrototype<T>
    {
        T DeepCopy();
    }
}
