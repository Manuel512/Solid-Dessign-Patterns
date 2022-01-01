using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Structural_Patterns.Decorator
{
    public class CodeBuilder
    {
        private StringBuilder builder = new StringBuilder();

        public CodeBuilder AppendLine(string? value)
        {
            builder.AppendLine(value);
            return this;
        }

        public override string ToString()
        {
            return builder.ToString();
        }
    }
}
