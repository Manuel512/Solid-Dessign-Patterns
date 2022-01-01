using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DessignPatterns.Solid_Principles.DependencyInversion
{
    //low-level
    public class RelationShips : IRelationshipBrowser
    {
        private List<(Person, RelationShip, Person)> relations 
            = new List<(Person, RelationShip, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, RelationShip.Parent, child));
            relations.Add((child, RelationShip.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations
                .Where(x => x.Item1.Name == name &&
                            x.Item2 == RelationShip.Parent
                ).Select(r => r.Item3);

        }

        //public List<(Person, RelationShip, Person)> Relations => relations;
    }
}
