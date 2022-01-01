using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Structural_Patterns.Proxy
{
    public class ProxyPatternProgram
    {
        public static void RunProtectionProxy()
        {
            ICar car = new Car();
            car.Drive();

            //proxy add new functionality without altering the original members
            ICar car2 = new CarProxy(new Driver(12));
            car2.Drive();
        }

        public static void RunPropertyProxy()
        {
            var c = new Creature();
            c.Agility = 10; // c.set_Agility(10) -> No
                            // c.Agility = new Property<int>(10)
            c.Agility = 10;
            c.Agility = 12;
        }

        public static void RunValueProxy()
        {
            Console.WriteLine(10f * 5.Percent());
            Console.WriteLine(2.Percent() + 3.Percent()); // 5%
        }

        public static void RunCompositeProxy()
        {
            var creatures = new Creatures.Creature[100];

            //Age X Y, Age X Y, Age X Y

            //best performance
            //Age, Age, Age, Age
            //X, X, X, X
            //Y, Y, Y, Y

            foreach (var c in creatures)
            {
                c.x++;
            }

            var creatures2 = new Creatures.Creatures(100);
            foreach (Creatures.Creatures.CreatureProxy c in creatures2)
            {
                c.x++;
            }
        }

        public static void RunCompositeProxyWithArray()
        {

        }
    }
}
