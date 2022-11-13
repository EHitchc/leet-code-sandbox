using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSandbox.Problems.Problem4
{
    class MedianTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int mergedSize = nums1.Length + nums2.Length;
            int optimizedSize = (mergedSize) / 2 + 1;
            int[] mergedNums = new int[optimizedSize];

            for (int i = 0, j = 0, k = 0; k < optimizedSize; k++)
            {
                if (i >= nums1.Length || j < nums2.Length && nums1[i] > nums2[j])
                {
                    mergedNums[k] = nums2[j++];
                }
                else
                    mergedNums[k] = nums1[i++];
            }

            if (mergedSize % 2 == 1)
            {
                return mergedNums[optimizedSize - 1];
            }
            else
            {
                return ((float)mergedNums[optimizedSize - 2] + (float)mergedNums[optimizedSize - 1]) / 2;
            }
        }
    }
}
