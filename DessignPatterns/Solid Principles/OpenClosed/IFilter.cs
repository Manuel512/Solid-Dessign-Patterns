using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Solid_Principles
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}
