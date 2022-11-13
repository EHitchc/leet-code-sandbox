using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSandbox.Problems.Problem901
{
    class OnlineStockSpan
    {
        private Stack<int[]> priceHistory;

        public OnlineStockSpan()
        {
            priceHistory = new Stack<int[]>();
        }

        public int Next(int price)
        {
            int count = 1;

            while (priceHistory.Count > 0 && priceHistory.Peek()[0] <= price)
                count += priceHistory.Pop()[1];

            priceHistory.Push(new int[] { price, count });

            return count;
        }
    }
}
