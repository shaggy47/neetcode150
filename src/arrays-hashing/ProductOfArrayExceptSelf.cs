using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_hashing
{
    public class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var output = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                var temp = nums[i];
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                        temp *= nums[j];
                }
                output[i] = temp;
                temp = nums[i];
            }

            return output;
        }
    }
}
