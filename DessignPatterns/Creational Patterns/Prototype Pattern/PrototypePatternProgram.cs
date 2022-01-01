using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Prototype_Pattern
{
    public class PrototypePatternProgram
    {
        public static void RunIClonableIsBad()
        {
            var john = new Person(new[] { "John", "Smith" },
                new Address("London Road", 123));

            var jane = (Person)john.Clone();
            jane.Names[0] = "Jane";
            jane.Address.HouseNumber = 321;

            Console.WriteLine(john);
            Console.WriteLine(jane);
        }

        public static void RunCopyConstructors()
        {
            var john = new Person(new[] { "John", "Smith" },
                new Address("London Road", 123));

            var jane = new Person(john);
            jane.Address.HouseNumber = 321;

            Console.WriteLine(john);
            Console.WriteLine(jane);
        }

        public static void RunExplicitDeepCopyInterface()
        {
            var john = new Person(new[] { "John", "Smith" },
                new Address("London Road", 123));

            var jane = john.DeepCopy();
            jane.Address.HouseNumber = 321;

            Console.WriteLine(john);
            Console.WriteLine(jane);
        }

        public static void RunCopyThroughSerialization()
        {
            var john = new Person2(new[] { "John", "Smith" },
                new Address2("London Road", 123));

            //var jane = john.DeepCopy(); // Binary formatter
            var jane = john.DeepCopyXml(); // xml serializer, will break becuase objects must be constructorless
            jane.Names[0] = "Jane";
            jane.Address.HouseNumber = 321;

            Console.WriteLine(john);
            Console.WriteLine(jane);
        }

        public static void RunExercise()
        {
            var line1 = new Line(new Point(5, 6), new Point(12, 29));
            var line2 = line1.DeepCopy();
            line2.Start.X = 8;
            line2.End.X = 18;

            Console.WriteLine(line1);
            Console.WriteLine(line2);
        }
    }
}
