using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Solid_Principles
{
    //Specification Pattern
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}
