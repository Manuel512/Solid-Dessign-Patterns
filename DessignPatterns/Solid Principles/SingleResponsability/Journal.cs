using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DessignPatterns.Solid_Principles
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        //This violates Single Responsability
        public void Save(string filename)
        {
            File.WriteAllText(filename, ToString());
        }

        //This violates Single Responsability
        public static Journal Load(string filename)
        {
            //Handle retrieval from file
            return new Journal();
        }

        //This violates Single Responsability
        public void Load(Uri uri)
        {
           //load file from uri
        }
    }
}
