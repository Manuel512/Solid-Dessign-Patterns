using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DessignPatterns.Prototype_Pattern
{
    public class Person : ICloneable, IPrototype<Person>
    {
        public string[] Names;
        public Address Address;

        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }

        //copy constructor
        public Person(Person other)
        {
            Names = other.Names;
            Address = new Address(other.Address);
        }

        public object Clone()
        {
            return new Person(Names, Address);
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(' ', Names)}, {nameof(Address)}: {Address}";
        }

        public Person DeepCopy()
        {
            return new Person(Names, Address.DeepCopy());
        }
    }
}
