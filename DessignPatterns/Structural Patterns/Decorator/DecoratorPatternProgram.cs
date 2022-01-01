using Autofac;
using DessignPatterns.Solid_Principles;
using DessignPatterns.Structural_Patterns.Decorator.AutofacDI;
using System;
using System.Collections.Generic;
using System.Text;
using DynamicDecorator = DessignPatterns.Structural_Patterns.Decorator.Dynamic_Decorator;
using StaticDecorator = DessignPatterns.Structural_Patterns.Decorator.Static_Decorator;

namespace DessignPatterns.Structural_Patterns.Decorator
{
    public class DecoratorPatternProgram
    {
        public static void RunCustomStringBuilder()
        {
            var cb = new CodeBuilder();
            cb.AppendLine("class Foo")
                .AppendLine("{")
                .AppendLine("}");

            Console.WriteLine(cb);
        }
        
        public static void RunAdapterDecorator()
        {
            MyStringBuilder s = "hello ";
            s += "world";
            Console.WriteLine(s);
        }

        public static void RunMultipleInheritanceWithInterfaces()
        {
            var d = new Dragon();
            d.Weight = 123;
            d.Fly();
            d.Crawl();
        }

        //Very Intrusive
        public static void RunMultipleInheritanceWithDefaultInterfaceMembers()
        {
            var d = new Inheritance_with_default_interface.Dragon { Age = 5 };
            
            if (d is IBird bird)
            {
                bird.Fly();
            }
            
            if (d is ILizard lizard)
            {
                lizard.Crawl();
            }
        }

        public static void RunDynamicDecoratorComposition()
        {
            var square = new DynamicDecorator.Square(1.23f);
            Console.WriteLine(square.AsString());

            var redSquare = new DynamicDecorator.ColorShape(square, "red");
            Console.WriteLine(redSquare.AsString());

            var redHalfTransparentSquare = new DynamicDecorator.TransparentShape(redSquare, 0.5f);
            Console.WriteLine(redHalfTransparentSquare.AsString());
        }

        public static void RunStaticDecoratorComposition()
        {
            //var redSquare = new StaticDecorator.ColoredShape<StaticDecorator.Square>();
            var redSquare = new StaticDecorator.ColoredShape<StaticDecorator.Square>("Red");
            Console.WriteLine(redSquare.AsString());

            var circle = new StaticDecorator.TransparentShape<StaticDecorator.ColoredShape<StaticDecorator.Circle>>(0.4f);
            Console.WriteLine(circle.AsString());
        }

        public static void RunDecoratorDI()
        {
            var b = new ContainerBuilder();
            b.RegisterType<ReportingService>().Named<IReportingService>("reporting");
            b.RegisterDecorator<IReportingService>(
                (context, service) => new ReportingServiceWithLogging(service),
                "reporting");

            using (var c = b.Build())
            {
                var r = c.Resolve<IReportingService>();
                r.Report();
            }
        }
    }
}
