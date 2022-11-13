using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSandbox.Problems.Problem6
{
    class ZigzagConversion
    {
        public string Convert(string s, int numRows)
        {
            Dictionary<int, string> zigzagStringDict = new Dictionary<int, string>();
            if (numRows == 1) return s;

            //init Dict, easier for processing later
            for (int i = 0; i < numRows; i++) zigzagStringDict.Add(i, "");

            int j = 0, row = 0;
            bool downFlag = false;
            while (j < s.Length)
            {
                zigzagStringDict[row] = String.Concat(zigzagStringDict[row], s[j].ToString());
                if (row % numRows == 0 || row % numRows == numRows - 1) downFlag = !downFlag;
                if (downFlag) row++;
                else row--;
                j++;
            }

            string zigzagString = string.Empty;
            for (int i = 0; i < numRows; i++) zigzagString = String.Concat(zigzagString, zigzagStringDict[i]);

            return zigzagString;
        }

        public string ConvertAlternate(string s, int numRows)
        {
            Dictionary<int, string> zigzagStringDict = new Dictionary<int, string>();
            /*
            cycleLength = 2 * (numRows - 1)
            0th row : k * cycleLength 
            numRows - 1th row : k * cycleLength + numRows - 1
            ith row: k * cycleLength - i AND k * cycleLength + i
            */
            if (numRows == 1) return s;

            int N = s.Length;

            StringBuilder sb = new StringBuilder();
            int cycleLength = 2 * (numRows - 1);

            for (int i = 0; i < numRows; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j * cycleLength < N; j++)
                    {
                        sb.Append(s[j * cycleLength]);
                    }
                }
                else if (i != numRows - 1)
                {
                    for (int j = 0; j * cycleLength - i < N; j++)
                    {
                        if (j * cycleLength - i > 0) sb.Append(s[j * cycleLength - i]);
                        if (j * cycleLength + i < N) sb.Append(s[j * cycleLength + i]);
                    }
                }
                else
                {
                    for (int j = 0; j * cycleLength + numRows - 1 < N; j++)
                    {
                        sb.Append(s[j * cycleLength + numRows - 1]);
                    }
                }
            }

            return sb.ToString();
        }
    }
}
