using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DessignPatterns.Solid_Principles
{
    public class Persistence
    {
        public void SaveToFile(Journal j, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
            {
                File.WriteAllText(filename, j.ToString());
            }
        }
    }
}
