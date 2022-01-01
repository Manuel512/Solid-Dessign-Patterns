using DessignPatterns.Builder_Pattern.Exercise;
using DessignPatterns.Builder_Pattern.Functional_Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Builder_Pattern
{
    public class BuilderPatternProgram
    {
        public static void RunLifeWithouBuilder()
        {
            var hello = "hello";
            var sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");
            Console.WriteLine(sb);

            var words = new[] { "hello", "world" };
            sb.Clear();
            sb.Append("<ul>");
            foreach (var word in words)
            {
                sb.AppendFormat("<li>{0}</li>", word);
            }
            sb.Append("</ul>");
            Console.WriteLine(sb);
        }

        public static void RunBuilder()
        {
            var builder = new HtmlBuilder("ul");
            //builder.AddChild("li", "Hello");
            //builder.AddChild("li", "World");

            //Fluent Builder
            builder.AddChild("li", "Hello")
                .AddChild("li", "World");
            Console.WriteLine(builder);
        }

        public static void RunFluentBuilderWithInheritance()
        {
            //var builder = new PersonJobBuilder();

            ////Cant use the new functionality
            //builder.Called("Manuel").WorkAsA

            var me = Person.New
                .Called("Manuel")
                .WorkAsA(".NET")
                .Build();

            Console.WriteLine(me);
        }

        public static void RunFunctionalBuilder()
        {
            var builder = new Functional_Builder.PersonBuilder();
            var person = builder.Called("Sarah")
                .WorksAs("Developer")
                .Build();

            Console.WriteLine(person);

            var builder2 = new Functional_Builder.PersonBuilder2();
            var person2 = builder2.Called("Sarah")
                .WorksAs("Developer")
                .Build();

            Console.WriteLine(person2);
        }

        public static void RunFacetedBuilder()
        {
            var pb = new Faceted_Builder.PersonBuilder();
            var person = pb
                .Lives
                    .At("Sol de Mayo 636")
                    .In("Cordoba")
                    .WithPostCode("5000")
                .Works
                    .At("Globant")
                    .AsA(".NET Developer")
                    .Earning(350000)
                .Build();

            Console.WriteLine(person);
        }

        public static void RunExercise()
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Console.WriteLine(cb);
        }
    }
}
