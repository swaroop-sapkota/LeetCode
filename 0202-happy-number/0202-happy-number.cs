public class Solution {
    public bool IsHappy(int n) {
        
        HashSet<int> usedIntegers = new HashSet<int>();

        while (true)
        {
            int sum = 0;
            while(n > 0)
            {
                int rem = n % 10;
                sum += rem * rem;
                n /= 10;
            }

            if (sum == 1) return true;

            n = sum;

            if (usedIntegers.Contains(n)) return false;
            
            usedIntegers.Add(n);
        }
}
}