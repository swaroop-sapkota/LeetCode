public class Solution {
    public int Fib(int n) {
        if(n <= 1)
        {
            return n;
        }

        // initialize our memoization map
        // size N+1 so that we can accommodate from 0 to N
        int[] dp = new int[n + 1];

        // put our base case
        dp[0] = 0;
        dp[1] = 1;

        //iterate through remaining values (2....N)
        for( int i = 2; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }

        return dp[n];
    }
}