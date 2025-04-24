public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n = cost.Length;

        int[] dp = new int[n + 1];

        dp[0] = 0;
        dp[1] = 0; 

        for(int i = 2; i <= n; i++)
        {
            int one = dp[i - 1] + cost[i - 1];
            int two = dp[i - 2] + cost[i - 2];
            

            if(one < two)
            {
                dp[i] = one;
            }
            else
            {
                dp[i] = two;
            }
        }

        return dp[n];
    }
}