using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Builder_Pattern
{
    abstract class PersonBuilder
    {
        protected Person person = new Person();

        public Person Build()
        {
            return person;
        }
    }
}
