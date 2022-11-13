using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSandbox.Problems.Problem1356
{
    class CheckNAndDouble
    {
        public bool CheckIfExist(int[] arr)
        {
            HashSet<int> arrayMap = new HashSet<int>();
            int N = arr.Length;
            int doubleVal = 0;
            int half = 0;

            for (int i = 0; i < N; i++)
            {
                doubleVal = 2 * arr[i];
                half = arr[i] % 2 == 0 ? arr[i] / 2 : 0;

                if (arrayMap.Contains(doubleVal) || (arr[i] % 2 == 0 && arrayMap.Contains(half))) return true;

                if (!arrayMap.Contains(arr[i])) arrayMap.Add(arr[i]);
            }

            return false;
        }
    }
}