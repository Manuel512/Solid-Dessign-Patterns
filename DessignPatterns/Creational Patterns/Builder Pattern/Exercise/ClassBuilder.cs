using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Builder_Pattern.Exercise
{
    public class ClassBuilder
    {
        public string Name;
        public List<PropertyBuilder> properties = new List<PropertyBuilder>();

        public ClassBuilder(string name)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {Name}");
            sb.AppendLine("{");
            foreach (var prop in properties)
            {
                sb.AppendLine(prop.ToString());
            }
            sb.Append("}");
            return sb.ToString();
        }
    }
}
