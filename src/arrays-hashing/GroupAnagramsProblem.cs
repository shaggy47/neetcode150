using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_hashing
{
    public class GroupAnagramsProblem
    {
        public List<List<string>> GroupAnagrams(string[] strs)
        {
            var ans = new Dictionary<string, List<string>>();

            foreach (var s in strs)
            {
                var count = new int[26];
                foreach (var c in s)
                {
                    count[c - 'a']++;
                }

                var key = string.Join(',', count);
                if (!ans.ContainsKey(key))
                {
                    ans[key] = new List<string>();
                }

                ans[key].Add(s);
            }

            return new List<List<string>>(ans.Values);
        }
    }
}
