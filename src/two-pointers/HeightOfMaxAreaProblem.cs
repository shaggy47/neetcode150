using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_pointers
{
    internal class HeightOfMaxAreaProblem
    {
        public int MaxArea(int[] heights)
        {

            var (l, r) = (0, heights.Length - 1);
            int maxArea = int.MinValue;

            while (l < r)
            {
                var area = Math.Min(heights[l], heights[r]) * (r - l);
                maxArea = Math.Max(area, maxArea);

                if (heights[l] < heights[r])
                    l++;
                else
                    r--;
            }

            return maxArea;
        }
    }
}
