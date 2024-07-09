using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_pointers
{
    internal class TwoSum2
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var (l, r) = (0, numbers.Length - 1);

            for (int i = 0; i < numbers.Length; i++)
            {
                l = i;
                while (l < r)
                {
                    var sum = numbers[l] + numbers[r];
                    if (sum == target)
                        return new int[] { l + 1, r + 1 };
                    if (sum < target)
                        l++;
                    if (sum > target)
                        r--;
                }
            }

            return Array.Empty<int>();
        }
    }
}
