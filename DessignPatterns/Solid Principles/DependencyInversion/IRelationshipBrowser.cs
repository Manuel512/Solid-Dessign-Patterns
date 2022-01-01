using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Solid_Principles.DependencyInversion
{
    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
}
