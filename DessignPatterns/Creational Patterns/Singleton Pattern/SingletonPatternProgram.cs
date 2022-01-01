using DessignPatterns.Singleton_Pattern.Ambient_Context;
using DessignPatterns.Singleton_Pattern.Monostate;
using DessignPatterns.Singleton_Pattern.Per_Thread_Singleton;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DessignPatterns.Singleton_Pattern
{
    public class SingletonPatternProgram
    {
        public static void RunSingletonImplementation()
        {
            var db = SingletonDatabase.Instance;
            var city = "Tokyo";
            Console.WriteLine($"{city} has population of { db.GetPopulation(city)}");
        }

        public static void RunMonostate()
        {
            var ceo = new CEO();
            ceo.Name = "Adam Smith";
            ceo.Age = 55;

            var ceo2 = new CEO();
            Console.WriteLine(ceo2);
        }

        // Create an instance per thread
        public static void RunPerThreadSingleton()
        {
            var t1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine($"t1: {PerThreadSingleton.Instance.Id}");
            });
            
            var t2 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine($"t2: {PerThreadSingleton.Instance.Id}");
                Console.WriteLine($"t2: {PerThreadSingleton.Instance.Id}");
            });

            Task.WaitAll(t1, t2);
        }

        public static void RunAmbientContext()
        {
            var house = new Building();

            //ground floor 3000
            //BuildingContext.WallHeight = 3000;
            using (new BuildingContext(3000))
            {
                house.Walls.Add(new Wall(new Ambient_Context.Point(0, 0), new Ambient_Context.Point(5000, 0)));
                house.Walls.Add(new Wall(new Ambient_Context.Point(0, 0), new Ambient_Context.Point(0, 4000)));

                //first floor 3500
                //BuildingContext.WallHeight = 3500;
                using (new BuildingContext(3500))
                {
                    house.Walls.Add(new Wall(new Ambient_Context.Point(0, 0), new Ambient_Context.Point(6000, 0)));
                    house.Walls.Add(new Wall(new Ambient_Context.Point(0, 0), new Ambient_Context.Point(0, 4000)));
                }

                //ground floor 3000
                //BuildingContext.WallHeight = 3000;
                house.Walls.Add(new Wall(new Ambient_Context.Point(0, 0), new Ambient_Context.Point(5000, 4000)));
            }

            Console.WriteLine(house);
        }
    }
}
