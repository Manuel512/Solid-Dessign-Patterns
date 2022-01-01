using DessignPatterns.Solid_Principles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DessignPatterns.Structural_Patterns.Composite.Composite_Specification
{
    public class Product
    {
        public string Name { get; private set; }
        public Color Color { get; private set; }
        public Size Size { get; private set; }

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }

    public class SizeSpecification : Specification<Product>
    {
        private Size size;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }
        public override bool IsSatisfied(Product t)
        {
            return t.Size == size;
        }
    }

    public class ColorSpecification : Specification<Product>
    {
        private Color color;

        public ColorSpecification(Color color)
        {
            this.color = color;
        }

        public override bool IsSatisfied(Product t)
        {
            return t.Color == color;
        }
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, Specification<T> spec);
    }

    public abstract class Specification<T>
    {
        public abstract bool IsSatisfied(T t);

        public static Specification<T> operator &(
            Specification<T> first, Specification<T> second)
        {
            return new AndSpecification<T>(first, second);
        }
    }

    public abstract class CompositeSpecification<T> : Specification<T>
    {
        protected readonly Specification<T>[] items;

        public CompositeSpecification(params Specification<T>[] items)
        {
            this.items = items;
        }
    }

    //combinators
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        //private Specification<T> first, second;

        //public AndSpecification(Specification<T> first, Specification<T> second)
        //{
        //    this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
        //    this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        //}

        public AndSpecification(params Specification<T>[] items) : base(items)
        {

        }

        public override bool IsSatisfied(T t)
        {
            return items.All(i => i.IsSatisfied(t));
        }
    }

    public class OrSpecification<T> : CompositeSpecification<T>
    {
        //private Specification<T> first, second;

        //public AndSpecification(Specification<T> first, Specification<T> second)
        //{
        //    this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
        //    this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        //}

        public OrSpecification(params Specification<T>[] items) : base(items)
        {

        }

        public override bool IsSatisfied(T t)
        {
            return items.Any(i => i.IsSatisfied(t));
        }
    }
}
