using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Solid_Principles.InterfaceSegregation
{
    public class MultiFunctionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            //throw new NotImplementedException();
        }

        public void Print(Document d)
        {
            //throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            //throw new NotImplementedException();
        }
    }
}
