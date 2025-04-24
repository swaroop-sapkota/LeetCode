public class Solution {
    public int Fib(int n) {
        
        if(n==0) return 0;

        int f0 = 0,f1 = 1;
        var f= f0 + f1;        
        for(var i = 2; i < n; i++)
        {
            f0 = f1;
            f1 = f;
            f= f0 + f1;
        }

        return f;
    }
}