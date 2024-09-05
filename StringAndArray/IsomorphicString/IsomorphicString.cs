using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsomorphicString
{
    //given two string a and b, determine if they are isomorphic
    //isomorphic strings should have same patterns
    //egg => add ; isomorphic
    //egg => ego ; not isomorphic
    internal class IsomorphicString
    {
        /// <summary>
        /// true
        /// f => b
        /// o => a
        /// o => a
        /// -------------
        /// false
        /// f => b
        /// o => a
        /// o => r
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsIsomorphic(string s, string t) 
        {
            if (s.Length != t.Length) return false;
            
            var sToTMapping = new Dictionary<char,char>();
            var tToSMapping = new Dictionary<char,char>();

            for (int i = 0; i < s.Length; i++)
            {
                var sChar = s[i];
                var tChar = t[i];

                if (sToTMapping.ContainsKey(sChar))
                {
                    if (sToTMapping[sChar] != tChar) return false;
                }
                else
                {
                    if (tToSMapping.ContainsKey(tChar))
                    {
                        if (tToSMapping[tChar] != sChar) return false;
                    }
                }

                // Create the mapping in both dictionaries
                sToTMapping[sChar] = tChar;
                tToSMapping[tChar] = sChar;
            }

            return true;
        }
    }
}
