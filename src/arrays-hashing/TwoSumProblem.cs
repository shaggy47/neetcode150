using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_hashing
{
    public class TwoSumProblem
    {
        public int[] TwoSumOptimised(int[] nums, int target)
        {
            Dictionary<int, int> indices = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (indices.ContainsKey(diff))
                {
                    return new int[] { indices[diff], i };
                }
                indices[nums[i]] = i;
            }

            return null;
        }


        public int[] TwoSumBruteForce(int[] nums, int target)
        {
            int i = 0;
            while (i < nums.Length)
            {
                int j;
                for (j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }

                i++;
            }

            return new int[0];
        }


    }
}
