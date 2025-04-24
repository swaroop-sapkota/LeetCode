public class Solution {
    public bool IsHappy(int n) {
        
        HashSet<int> seen = new HashSet<int>();

        while (n != 1 && !seen.Contains(n))
        {
            seen.Add(n);
            
            int sumOfSq = 0;
            while(n > 0)
            {
                int digit = n % 10;
                sumOfSq += digit * digit;
                n /= 10;
            }
            n = sumOfSq;

        }
        
        return n == 1;
        
    }
}