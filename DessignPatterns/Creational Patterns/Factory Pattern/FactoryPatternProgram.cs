using DessignPatterns.Factory_Pattern.Abstract_Factory;
using DessignPatterns.Factory_Pattern.Asynchronous_Factory_Method;
using DessignPatterns.Factory_Pattern.Example_Point;
using DessignPatterns.Factory_Pattern.Exercise;
using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Factory_Pattern
{
    public class FactoryPatternProgram
    {
        public static void RunExamplePoint()
        {
            //var point = Point.NewPolarPoint(1.0, Math.PI / 2);

            //Factory
            //var point = PointFactory.NewPolarPoint(1.0, Math.PI / 2);

            //Inner Factory
            var point = Point.Factory.NewPolarPoint(1.0, Math.PI / 2);
            Console.WriteLine(point);
        }

        public static async void AsynchronousFactoryMethodRun()
        {
            //var foo = new Foo();
            //await foo.InitAsync();

            var foo = await Foo.CreateAsync();
            Console.WriteLine(foo);
        }

        public static void AbstractFactoryRun()
        {
            //var machine = new HotDrinkMachine();
            //var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Coffee, 100);
            //drink.Consume();

            var machine = new HotDrinkMachine();
            var drink = machine.MakeDrink();
            drink.Consume();
        }

        public static void ExerciseRun()
        {
            var factory = new PersonFactory();
            var person1 = factory.CreatePerson("Manuel");
            var person2 = factory.CreatePerson("Kimberly");

            Console.WriteLine($"{person1.Name} has Id of {person1.Id}");
            Console.WriteLine($"{person2.Name} has Id of {person2.Id}");
        }
    }
}
