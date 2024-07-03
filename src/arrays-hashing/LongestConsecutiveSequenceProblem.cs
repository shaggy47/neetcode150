using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_hashing
{
    public class LongestConsecutiveSequenceProblem
    {
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> numSet = new HashSet<int>(nums);
            int longest = 0;

            foreach (int n in numSet)
            {
                if (!numSet.Contains(n - 1))
                {
                    int length = 1;
                    while (numSet.Contains(n + length))
                    {
                        length++;
                    }
                    longest = Math.Max(length, longest);
                }
            }
            return longest;
        }
    }
}
