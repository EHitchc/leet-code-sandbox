using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSandbox.Problems.Problem7
{
    class ReverseInteger
    {
        // W/O library reverse methods
        public int Reverse(int x)
        {
            bool isNegative = x < 0;

            string numText = x.ToString();
            StringBuilder sbReversed = new StringBuilder();

            for (int i = numText.Length - 1; i >= 0; i--)
                sbReversed.Append(numText[i]);

            if (isNegative)
            {
                sbReversed.Remove(sbReversed.Length - 1, 1);
                sbReversed.Insert(0, '-');
            }

            try
            {
                return int.Parse(sbReversed.ToString());
            }
            catch
            {
                return 0;
            }
        }

        public int ReverseAlt(int x)
        {
            bool isNegative = x < 0;
            char[] stringReversedArray = x.ToString().ToCharArray();
            Array.Reverse(stringReversedArray);

            StringBuilder sb = new StringBuilder();
            sb.Append(stringReversedArray);

            if (isNegative)
            {
                sb.Remove(sb.Length - 1, 1);
                sb.Insert(0, '-');
            }

            try
            {
                return int.Parse(sb.ToString());
            } catch
            {
                return 0;
            }
        }
    }
}
