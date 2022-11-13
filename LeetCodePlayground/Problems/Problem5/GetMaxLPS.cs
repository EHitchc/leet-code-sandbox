using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace LeetCodePlayground.Problems.Problem5
{
    public partial class GetMaxLPS : Component
    {
        public GetMaxLPS()
        {
            InitializeComponent();
        }
        public string LongestPalindrome(string s)
        {
            if (s.Length == 0) return "";
            if (s.Length == 1) return s;

            int N = 2 * s.Length + 1;
            int[] pRadii = new int[N];

            int rCenterPos = 2;
            int centerPos = 1;
            int maxCenterPos = 1;
            int maxLPS = 1;
            int currLPos;
            int distanceToCenterRight;

            // pRadii for first two positions are always the same
            pRadii[0] = 0;
            pRadii[1] = 1;

            for (int i = 2; i < N; i++)
            {
                currLPos = 2 * centerPos - i;
                distanceToCenterRight = rCenterPos - i;

                if (currLPos >= 0)
                    pRadii[i] = Math.Min(pRadii[currLPos], distanceToCenterRight);

                // Test characters either side of center
                while ((i + pRadii[i] + 1 < N && i - pRadii[i] - 1 >= 0) && (((i + pRadii[i] + 1) % 2 == 0) || (s[(i + pRadii[i]) / 2] == s[(i - pRadii[i]) / 2 - 1])))
                    pRadii[i]++;

                if (pRadii[i] > maxLPS)
                {
                    maxCenterPos = i;
                    maxLPS = pRadii[i];
                }

                if (centerPos + pRadii[centerPos] < i + pRadii[i])
                {
                    centerPos = i;
                    rCenterPos = i + pRadii[i];
                }
            }

            return s.Substring(((maxCenterPos - pRadii[maxCenterPos]) / 2), maxLPS);
        }
    }
}
