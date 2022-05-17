using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeString
{
    internal class PalindromeChecker
    {
        public static bool CheckIfPalindrome(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            int[] letters = new int[128];

            foreach(char c in s1)
            {
                letters[c]++;
            }

            foreach (char c in s2)
            {
                letters[c]--;

                if (letters[c] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
