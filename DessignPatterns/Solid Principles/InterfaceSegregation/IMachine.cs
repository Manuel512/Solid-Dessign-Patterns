using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Solid_Principles.InterfaceSegregation
{
    public interface IMachine
    {
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }
}
