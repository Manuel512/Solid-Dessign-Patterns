namespace DessignPatterns.Prototype_Pattern
{
    public class Address : IPrototype<Address>
    {
        public string StreetName;
        public int HouseNumber;

        public Address(Address other)
        {
            StreetName = other.StreetName;
            HouseNumber = other.HouseNumber;
        }

        //copy constructor
        public Address(string streetname, int housenumber)
        {
            StreetName = streetname;
            HouseNumber = housenumber;
        }

        public Address DeepCopy()
        {
            return new Address(StreetName, HouseNumber);
        }

        public override string ToString()
        {
            return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
        }
    }
}