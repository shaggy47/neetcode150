using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_pointers
{
    internal class ThreeSumProblem
    {
        public List<List<int>> ThreeSum(int[] nums)
        {
            var triplets = new List<List<int>>();
            Array.Sort(nums);
            var r = nums.Length - 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    break;

                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                var l = i + 1;
                while (l < r)
                {
                    int sum = nums[i] + nums[l] + nums[r];
                    if (sum > 0)
                        r--;
                    else if (sum < 0)
                        l++;
                    else
                    {
                        triplets.Add(new List<int>() { nums[i], nums[l], nums[r] });
                        l++;
                        r--;
                        while (l < r && nums[l] == nums[l - 1])
                            l++;
                    }
                }

                i++;
            }

            return triplets;
        }
    }
}
