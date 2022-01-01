using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Builder_Pattern.Functional_Builder
{
    public sealed class PersonBuilder2
        : FunctionalBuilder<Person, PersonBuilder2>
    {
        public new PersonBuilder2 Called(string name)
            => Do(p => p.Name = name);

        internal object called(string v)
        {
            throw new NotImplementedException();
        }
    }
}
