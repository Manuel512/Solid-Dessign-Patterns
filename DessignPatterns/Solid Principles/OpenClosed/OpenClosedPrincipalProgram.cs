using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Solid_Principles
{
    public class OpenClosedPrincipalProgram
    {
        public static void Run()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };
            var pf = new ProductFilter();
            Console.WriteLine("Green products (old):");
            foreach (var p in pf.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($" - {p.Name} is green");
            }

            Console.WriteLine("Large products (old):");
            foreach (var p in pf.FilterBySize(products, Size.Large))
            {
                Console.WriteLine($" - {p.Name} is large");
            }

            Console.WriteLine(Environment.NewLine);

            //New change requested FilterByboth size and color
            //So we implement this
            var bf = new BetterFilter();
            Console.WriteLine("Green products (new): ");
            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {p.Name} is green");
            }
            
            Console.WriteLine("Large products (new): ");
            foreach (var p in bf.Filter(products, new SizeSpecification(Size.Large)))
            {
                Console.WriteLine($" - {p.Name} is large");
            }

            Console.WriteLine("Large blue items (new):");
            var colorSpec = new ColorSpecification(Color.Blue);
            var sizeSpec = new SizeSpecification(Size.Large);
            var andSpecification = new AndSpecification<Product>(colorSpec, sizeSpec);
            foreach (var p in bf.Filter(products, andSpecification))
            {
                Console.WriteLine($" - {p.Name} is blue and large");
            }
        }
    }
}
