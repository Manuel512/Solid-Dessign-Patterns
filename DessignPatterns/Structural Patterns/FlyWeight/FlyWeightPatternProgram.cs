using JetBrains.dotMemoryUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DessignPatterns.Structural_Patterns.FlyWeight
{
    public class FlyWeightPatternProgram
    {
        public static void Run() //1.655.033
        {
            var firstNames = Enumerable.Range(0, 100).Select(x => RandomString());
            var LastNames = Enumerable.Range(0, 100).Select(x => RandomString());

            var users = new List<User>();

            foreach (var firstname in firstNames)
            {
                foreach (var lastname in LastNames)
                {
                    users.Add(new User($"{firstname} {lastname}"));
                }
            }

            ForceGC();

            dotMemory.Check(Memory =>
            {
                Console.WriteLine(Memory.SizeInBytes);
            });
        }

        public static void Run2() //1.655.033 1.296.991
        {
            var firstNames = Enumerable.Range(0, 100).Select(x => RandomString());
            var LastNames = Enumerable.Range(0, 100).Select(x => RandomString());

            var users = new List<User2>();

            foreach (var firstname in firstNames)
            {
                foreach (var lastname in LastNames)
                {
                    users.Add(new User2($"{firstname} {lastname}"));
                }
            }

            ForceGC();

            dotMemory.Check(Memory =>
            {
                Console.WriteLine(Memory.SizeInBytes);
            });
        }

        public static void RunTextFormatting()
        {
            var ft = new FormattedText("This is a brave new world");
            ft.Capitalize(10, 15);
            Console.WriteLine(ft);

            var bft = new BetterFormattedText("This is a brave new world");
            bft.GetRange(10, 15).Capitalize = true;
            Console.WriteLine(bft);
        }

        public static void RunExercise()
        {
            var sentence = new Sentence("hello world");
            sentence[1].Capitalize = true;
            Console.WriteLine(sentence); // writes hello WORLD
        }

        private static void ForceGC()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private static string RandomString()
        {
            Random rand = new Random();

            return new string(
                Enumerable.Range(0, 10)
                .Select(i => (char)('a' + rand.Next(26)))
                .ToArray());
        }
    }
}
