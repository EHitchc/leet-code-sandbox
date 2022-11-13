using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSandbox.Problems.Problem3
{
    class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            int length = s.Length;
            int max = 0;

            Dictionary<char, int> stringMap = new Dictionary<char, int>();

            for (int i = 0, j = 0; j < length; j++)
            {
                if (stringMap.ContainsKey(s[j]))
                {
                    i = Math.Max(i, stringMap[s[j]] + 1);
                    stringMap[s[j]] = j;
                }
                else
                    stringMap.Add(s[j], j);

                max = Math.Max(max, j - i + 1);
            }

            return max;
        }
    }
}
