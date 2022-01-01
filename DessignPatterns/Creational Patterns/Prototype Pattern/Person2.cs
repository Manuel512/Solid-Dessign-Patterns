using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DessignPatterns.Prototype_Pattern
{
    //[Serializable] this is for binaryformatter
    public class Person2
    {
        public string[] Names;
        public Address2 Address;

        public Person2(string[] names, Address2 address)
        {
            Names = names;
            Address = address;
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(' ', Names)}, {nameof(Address)}: {Address}";
        }
    }
}
