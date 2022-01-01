using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Builder_Pattern.Exercise
{
    public class CodeBuilder
    {
        private const int indentSize = 2;
        private ClassBuilder classBuilder;

        public CodeBuilder(string name)
        {
            classBuilder = new ClassBuilder(name);
        }

        public CodeBuilder AddField(string name, string type)
        {
            classBuilder.properties.Add(new PropertyBuilder(name, type, indentSize));
            return this;
        }

        public override string ToString()
        {
            return classBuilder.ToString();
        }
    }
}
