using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Builder_Pattern
{
    class PersonJobBuilder<SELF> : PersonInfoBuilder<PersonJobBuilder<SELF>>
        where SELF: PersonJobBuilder<SELF>
    {
        public SELF WorkAsA(string position)
        {
            person.Position = position;
            return (SELF) this;
        }
    }
}
