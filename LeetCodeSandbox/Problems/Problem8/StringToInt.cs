using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSandbox.Problems.Problem8
{
    class StringToInt
    {
        public int MyAtoi(string s)
        {
            var sTrimmed = s.Trim();

            int start = 0;
            if (sTrimmed.Length == 0 || ((sTrimmed[start] >= 58 || sTrimmed[start] <= 47) && sTrimmed[start] != '-' && sTrimmed[start] != '+'))
                return 0;

            var isNegative = sTrimmed[start] == '-' ? true : false;

            if (sTrimmed[start] == '+' || sTrimmed[start] == '-')
            {
                sTrimmed = sTrimmed.Remove(start, 1);
            }

            if (sTrimmed.Length == 0 || sTrimmed[start] >= 58 || sTrimmed[start] <= 47)
                return 0;

            int end = start;
            while (end < sTrimmed.Length && sTrimmed[end] < 58 && sTrimmed[end] > 47)
            {
                end++;
            }

            sTrimmed = sTrimmed.Substring(start, end - start);

            while (sTrimmed[0] == '0' && sTrimmed.Length > 1)
            {
                sTrimmed = sTrimmed.Remove(0, 1);
            }

            if (isNegative) sTrimmed = sTrimmed.Insert(0, "-");

            try
            {
                return int.Parse(sTrimmed);
            }
            catch
            {
                if (isNegative) return Int32.MinValue;
                return Int32.MaxValue;
            }
        }
    }
}
