using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DessignPatterns.Solid_Principles.DependencyInversion
{
    public class DependencyInversionPrincipleProgram
    {
        //public DependencyInversionPrincipleProgram(RelationShips relationShips)
        //{
        //    var relations = relationShips.Relations;
        //    var filteredRelations = relations
        //        .Where(x => x.Item1.Name == "John" &&
        //                    x.Item2 == RelationShip.Parent
        //        );

        //    foreach (var r in filteredRelations)
        //    {
        //        Console.WriteLine($"John has a child called {r.Item3.Name}");
        //    }
        //}

        public DependencyInversionPrincipleProgram(IRelationshipBrowser browser)
        {
            foreach (var p in browser.FindAllChildrenOf("John"))
            {
                Console.WriteLine($"John has a child called {p.Name}");
            }
        }

        public static void Run()
        {
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Chris" };
            var child2 = new Person { Name = "Mary" };

            var relationships = new RelationShips();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            new DependencyInversionPrincipleProgram(relationships);
        }
    }
}
