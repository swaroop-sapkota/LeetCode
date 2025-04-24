public class Solution {
    public int Fib(int n) {
        
        if(n == 0) return 0;

        int f0 = 0, f1 = 1;
        int f = f0 + f1;

        for(int i = 2; i < n; i++)
        {
            f0 = f1;
            f1 = f;
            f = f0 + f1;
        }

        return f;
    }
}