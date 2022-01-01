using System;

namespace DessignPatterns.Prototype_Pattern
{
    //[Serializable] this is for binaryformatter
    public class Address2
    {
        public string StreetName;
        public int HouseNumber;
       
        public Address2(string streetname, int housenumber)
        {
            StreetName = streetname;
            HouseNumber = housenumber;
        }

        public override string ToString()
        {
            return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
        }
    }
}