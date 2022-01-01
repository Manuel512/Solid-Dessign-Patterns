using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Structural_Patterns.Decorator
{
    public class MyStringBuilder
    {
        private StringBuilder sb = new StringBuilder();

        public static implicit operator MyStringBuilder(string s)
        {
            var msb = new MyStringBuilder();
            msb.Append(s);
            return msb;
        }

        public static MyStringBuilder operator +(MyStringBuilder msb, string s) 
        {
            msb.Append(s);
            return msb;
        }

        public MyStringBuilder Append(string value)
        {
            sb.Append(value);
            return this;
        }

        public override string ToString()
        {
            return sb.ToString();
        }
    }
}
