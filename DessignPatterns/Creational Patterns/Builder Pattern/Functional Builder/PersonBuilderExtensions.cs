using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Builder_Pattern.Functional_Builder
{
    static class PersonBuilderExtensions
    {
        public static PersonBuilder WorksAs(this PersonBuilder builder, string position)
            => builder.Do(p => p.Position = position);

        public static PersonBuilder2 WorksAs(this PersonBuilder2 builder, string position)
            => builder.Do(p => p.Position = position);

    }
}
