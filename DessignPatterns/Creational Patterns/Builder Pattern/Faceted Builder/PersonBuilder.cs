using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Builder_Pattern.Faceted_Builder
{
    public class PersonBuilder //Facade
    {
        // reference!
        protected Person person = new Person();

        public PersonJobBuilder Works => new PersonJobBuilder(person);
        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);

        // NOT WORKING, COMPILER THROW ERROR
        //public static implicit operator Person(PersonBuilder pb)
        //{
        //    return pb.person;
        //}

        public Person Build()
        {
            return person;
        }
    }
}
