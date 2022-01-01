using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DessignPatterns.Solid_Principles
{
    public class SingleResponsabilityPrincipleProgram
    {
        public static void Run()
        {
            var j = new Journal();
            j.AddEntry("I cried today");
            j.AddEntry("I ate a bug");
            Console.WriteLine(j);

            var p = new Persistence();
            var filename = @"c:\temp\journal.txt";
            p.SaveToFile(j, filename, true);
            Process.Start(@"cmd.exe", "/c " + filename);
        }
    }
}
