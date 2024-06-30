using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_hashing
{
    public class TopKFrequentElementsProblem
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            ///Count the frequencies of each number in a dictionary.
            ///Declare a list of integer arrays to store the occurences of each item.
            ///Counting the frequencies K times from the right of the list of integer arrays gives top K frequencies.

            var tops = new int[2];
            var counts = new Dictionary<int, int>();
            List<int>[] freq = new List<int>[nums.Length + 1];
            for (int i = 0; i < freq.Length; i++)
            {
                freq[i] = new List<int>();
            }

            foreach (var n in nums)
            {
                if (counts.ContainsKey(n))
                    counts[n]++;
                else
                    counts[n] = 1;
            }

            foreach (var n in counts) 
            {
                freq[n.Value].Add(n.Key);
            }

            int index = 0;
            for (int i = freq.Length - 1; i > 0 && index < k; i--)
            {
                foreach (var n in freq[i])
                {
                    tops[index++] = n;
                    if (index == k)
                        return tops;
                }
            }

            return tops;
        }
    }
}
