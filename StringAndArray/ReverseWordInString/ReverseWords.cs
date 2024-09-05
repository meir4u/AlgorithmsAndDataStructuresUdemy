using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWordInString
{
    //given an input string, reverse the string word by word.
    //A word is defined as a sequence of non-space characters.
    //The input string does not contain leading or trailing spaces and the words are always separated by a single space.
    internal class ReverseWords
    {
        public ReverseWords() { }

        public string Reversed(string s)
        {
            List<string> stringArrayRaw = s.Split(" ").ToList();

            var sb = new StringBuilder();
            
            for (int i = stringArrayRaw.Count - 1; i >= 0; i--)
            {
                sb.Append(stringArrayRaw[i] + " ");
            }

            return sb.ToString().Trim();

        }
    }
}
