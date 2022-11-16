using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSandbox.Problems.Problem1539
{
    class MissingPositiveNumber
    {
        public int FindKthPositive(int[] arr, int k)
        {
            // Edge case where missing number extends past min length
            if (k < arr[0]) return k;
            // Edge case where missing number extends past max length
            if (k > calcDiff(arr, arr.Length - 1)) return k + arr[arr.Length - 1] - calcDiff(arr, arr.Length - 1);

            Dictionary<string, int> tp = new Dictionary<string, int>();
            tp.Add("start", 0);
            tp.Add("end", arr.Length - 1);

            int position = (tp["start"] + tp["end"]) / 2, difference;

            while (tp["start"] < tp["end"])
            {
                difference = calcDiff(arr, position);
                // if k is greater than disparity, set start/min pointer to position and binary search right
                if (k > difference)
                {
                    tp["start"] = position;
                }
                // else if k is less than disparity, set end/max pointer to position and binary search left
                else if (k <= difference)
                {
                    tp["end"] = position;
                }
                int newPosition = (tp["start"] + tp["end"]) / 2;
                if (newPosition == position) break;
                position = newPosition;
            }

            return arr[tp["start"]] + (k - calcDiff(arr, tp["start"]));
        }

        private int calcDiff(int[] arr, int pos)
        {
            return arr[pos] - (pos + 1);
        }
    }
}

// difference between actual value and expected value is arr[position] - (position + 1)
// two pointers solution
// find highest value with a difference less than k, then ans = arr[position] + (k - difference)
