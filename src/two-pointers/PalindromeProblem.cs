using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_pointers
{
    internal class PalindromeProblem
    {
        public bool IsPalindrome(string s)
        {
            var (l, r) = (0, 0);
            var isPalindrome = false;

            var trimmed = s.Replace(" ", string.Empty)
                           .ToLower()
                           .ToCharArray();

            r = trimmed.Length - 1;
            if (trimmed.Length == 1 && IsSpecialChar(trimmed[0]))
                return true;

            if (trimmed.Length == 2 && IsSpecialChar(trimmed[0]) && IsSpecialChar(trimmed[1]))
                return true;

            while (l < r)
            {
                if (IsSpecialChar(trimmed[l]))
                    l++;

                if (IsSpecialChar(trimmed[r]))
                    r--;
                if (trimmed[l] == trimmed[r])
                    isPalindrome = true;
                else
                    return false;
                l++;
                r--;
            }

            return isPalindrome;
        }

        private bool IsSpecialChar(char c)
        {
            var isNumber = c >= 48 && c <= 57;
            var isSpecialChar = !isNumber && ((c >= 32 && c <= 47) || (c >= 58 && c <= 64));

            return isSpecialChar;
        }
    }
}
