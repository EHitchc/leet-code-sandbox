using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSandbox.Problems.Problem1774
{
    class ClosestDessertCost
    {
        private int result;

        public int ClosestCost(int[] baseCosts, int[] toppingCosts, int target)
        {
            result = baseCosts[0];
            foreach (int cost in baseCosts)
                recursiveBacktrack(cost, toppingCosts, 0, target);
            return result;
        }

        private void recursiveBacktrack(int current, int[] toppingCosts, int index, int target)
        {
            if (Math.Abs(target - current) < Math.Abs(target - result) || Math.Abs(target - current) == Math.Abs(target - result) && current < result)
                result = current;
            if (index == toppingCosts.Length || current >= target) return;
            recursiveBacktrack(current, toppingCosts, index + 1, target);
            recursiveBacktrack(current + toppingCosts[index], toppingCosts, index + 1, target);
            recursiveBacktrack(current + 2 * toppingCosts[index], toppingCosts, index + 1, target);
        }
    }
}
