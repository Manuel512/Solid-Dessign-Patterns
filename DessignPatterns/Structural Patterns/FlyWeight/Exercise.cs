using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DessignPatterns.Structural_Patterns.FlyWeight
{
    public class Sentence
    {
        private WordToken[] wordTokens;
        public Sentence(string plainText)
        {
            wordTokens = plainText.Split(' ').Select(x => new WordToken { Word = x }).ToArray();
        }

        public WordToken this[int index]
        {
            get
            {
                return wordTokens[index];
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < wordTokens.Length; i++)
            {
                var c = wordTokens[i];
                if (c.Capitalize)
                {
                    c.Word = string.Join("",c.Word.Select(char.ToUpper));
                }

                sb.Append(c.Word);
                if (i < wordTokens.Length - 1)
                {
                    sb.Append(" ");
                }
            }

            return sb.ToString();
        }

        public class WordToken
        {
            public string Word;
            public bool Capitalize;
        }
    }

    public class SentenceByTeacher
    {
        private string[] words;
        private Dictionary<int, WordToken> tokens = new Dictionary<int, WordToken>();

        public SentenceByTeacher(string plainText)
        {
            words = plainText.Split(' ');
        }

        public WordToken this[int index]
        {
            get
            {
                WordToken wt = new WordToken();
                tokens.Add(index, wt);
                return tokens[index];
            }
        }

        public override string ToString()
        {
            var ws = new List<string>();
            for (var i = 0; i < words.Length; i++)
            {
                var w = words[i];
                if (tokens.ContainsKey(i) && tokens[i].Capitalize)
                    w = w.ToUpperInvariant();
                ws.Add(w);
            }
            return string.Join(" ", ws);
        }

        public class WordToken
        {
            public bool Capitalize;
        }
    }
}
