using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Factory_Pattern.Exercise
{
    public class PersonFactory
    {
        private int IdCount = 0;

        public Person CreatePerson(string name)
        {
            return new Person(IdCount++, name);
        }
    }
}
