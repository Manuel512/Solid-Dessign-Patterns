using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Structural_Patterns.Proxy
{
    public class Person
    {
        public int Age { get; set; }

        public string Drink()
        {
            return "drinking";
        }

        public string Drive()
        {
            return "driving";
        }

        public string DrinkAndDrive()
        {
            return "driving while drunk";
        }
    }

    public class ResponsiblePerson
    {
        private readonly Person person;

        public ResponsiblePerson(Person person)
        {
            this.person = person;
        }

        public int Age 
        {
            get => person.Age;
            set => person.Age = value;
        }

        public string Drink()
        {
            if (person.Age < 18)
            {
                return "too young";
            }
            return person.Drink();
        }

        public string Drive()
        {

            if (person.Age < 16)
            {
                return "too young";
            }
            return person.Drive();
        }

        public string DrinkAndDrive() => "dead";
    }
}
