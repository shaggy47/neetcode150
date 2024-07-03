using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_hashing
{
    internal class EncodeDecodeProblem
    {
        public string Encode(IList<string> strs)
        {
            return string.Concat(strs.SelectMany(s => $"{s.Length}#{s}"));
        }

        public List<string> Decode(string s)
        {
            var list = new List<string>();
            var i = 0;
            while (i < s.Length)
            {
                var j = i;
                var count = 0;
                while (s[j] != '#')
                {
                    ++j;
                    count++;
                }

                var l = int.Parse(s.Substring(i, count));
                var sub = s.Substring(j + 1, l);
                list.Add(sub);
                i = j + l + 1;
            }

            return list;
        }
    }
}
