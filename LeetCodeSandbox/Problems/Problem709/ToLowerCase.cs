using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSandbox.Problems.Problem709
{
    class ToLowerCaseClass
    {
        public string ToLowerCase(string s)
        {
            var sb = new StringBuilder();

            foreach (char c in s)
            {
                if (c >= 'A' && c <= 'Z') sb.Append(Convert.ToChar(c + 32));
                else sb.Append(c);
            }

            return sb.ToString();
        }
    }
}
