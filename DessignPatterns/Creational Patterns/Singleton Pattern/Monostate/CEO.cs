using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Singleton_Pattern.Monostate
{
    public class CEO
    {
        private static string name;
        private static int age;

        public int Age { 
            get => age; 
            set => age = value; 
        }
        public string Name { 
            get => name; 
            set => name = value; 
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}";
        }
    }
}
