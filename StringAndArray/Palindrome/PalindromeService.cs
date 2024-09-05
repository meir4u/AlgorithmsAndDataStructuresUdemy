using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal static class PalindromeService
    {
        internal static bool IsPalindromeByRecursion(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1) return true;

            if (s[0] != s[s.Length - 1])
            {
                return false;
            }
            return IsPalindromeByRecursion(s.Substring(1, s.Length - 1)); ;
        }
    }
}
