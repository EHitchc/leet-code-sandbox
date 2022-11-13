using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSandbox.Problems.Problem1
{
    class TwoSum
    {
        public int[] FindIndices(int[] nums, int target)
        {
            Dictionary<int, int> numsDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numsDict.ContainsKey(complement)) return new int[] { numsDict[complement], i };
                else if (!numsDict.ContainsKey(nums[i])) numsDict.Add(nums[i], i);
            }
            return null;
        }
    }
}
