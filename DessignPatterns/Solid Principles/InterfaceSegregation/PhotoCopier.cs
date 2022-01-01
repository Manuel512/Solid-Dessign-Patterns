using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Solid_Principles.InterfaceSegregation
{
    class PhotoCopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }
}
