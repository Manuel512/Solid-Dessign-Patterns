using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Solid_Principles
{
    public class Square : Rectangle
    {
        public override int Width 
        { 
            set { base.Width = base.Height = value; }
        }

        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }
}
