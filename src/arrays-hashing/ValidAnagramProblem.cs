using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_hashing
{
    public class ValidAnagramProblem
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var counts = new int[26];

            foreach (var c in s)
            {
                counts[c - 'a']++;
            }

            foreach (var c in t)
            {
                counts[c - 'a']--;
            }

            foreach (var c in counts)
                if (c != 0)
                    return false;

            return true;
        }
    }
}
