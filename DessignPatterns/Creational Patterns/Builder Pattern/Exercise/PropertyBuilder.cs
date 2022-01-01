using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Builder_Pattern.Exercise
{
    public class PropertyBuilder
    {
        private string Name, Type;
        private int indentSize;

        public PropertyBuilder(string name, string type, int indent)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Type = type ?? throw new ArgumentNullException(paramName: nameof(type));
            indentSize = indent;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(new string(' ', indentSize));
            sb.Append($"public {Type} {Name};");
            return sb.ToString();
        }
    }
}
