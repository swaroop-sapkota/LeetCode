public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n = cost.Length;

        int[] minCost = new int[n + 1];

        minCost[0] = 0;
        minCost[1] = 0; 

        for(int i = 2; i <= n; i++)
        {
            minCost[i] = Math.Min(minCost[i - 1] + cost[i - 1], minCost[i - 2] + cost[i - 2]);

            /*
            int one = minCost[i - 1] + cost[i - 1];
            int two = minCost[i - 2] + cost[i - 2];
            if(one < two)
            {
                minCost[i] = one;
            }
            else
            {
                minCost[i] = two;
            }
            */
        }

        return minCost[n];
    }
}