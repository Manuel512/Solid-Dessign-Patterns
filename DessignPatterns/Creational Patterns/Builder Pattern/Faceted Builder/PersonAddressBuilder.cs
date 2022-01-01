using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Builder_Pattern.Faceted_Builder
{
    public class PersonAddressBuilder : PersonBuilder
    {
        // might now work with a value type!
        public PersonAddressBuilder(Person person)
        {
            this.person = person;
        }

        public PersonAddressBuilder WithPostCode(string postCode)
        {
            person.PostCode = postCode;
            return this;
        }

        public PersonAddressBuilder At(string streetAddress)
        {
            person.StreetAddress = streetAddress;
            return this;
        }

        public PersonAddressBuilder In(string city)
        {
            person.City = city;
            return this;
        }


    }
}
