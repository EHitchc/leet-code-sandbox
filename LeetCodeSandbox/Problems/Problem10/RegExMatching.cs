using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSandbox.Problems.Problem10
{
    class RegExMatching
    {
        public bool IsMatch(string s, string p)
        {
            bool[,] resultCache = new bool[s.Length + 1, p.Length + 1];
            resultCache[s.Length, p.Length] = true;

            // working backwards from end of array
            for (int i = s.Length; i >= 0; i--)
            {
                for (int j = p.Length - 1; j >= 0; j--)
                {
                    bool firstMatch = (i < s.Length &&
                                      (p[j] == s[i] ||
                                      p[j] == '.'));
                    // check if consume multiple chars
                    if (j + 1 < p.Length && p[j + 1] == '*')
                    {
                        resultCache[i, j] = resultCache[i, j + 2] || firstMatch && resultCache[i + 1, j];
                    }
                    else
                    {
                        resultCache[i, j] = firstMatch && resultCache[i + 1, j + 1];
                    }
                }
            }
            return resultCache[0, 0];
        }
    }
}
