public class Solution {
    public int GetLucky(string s, int k) {

        int sum = 0;


        foreach(char c in s)
        {
            int num = c - 96;

            while(num > 0)
            {
                sum += (num % 10);
                num /= 10;
            }
        }

        

        while(k > 1)
        {
            int total = 0;

            while(sum > 0)
            {
                total += (sum % 10);
                sum /= 10;
            }
            
            sum = total;
            k--;
        }

        return sum;

    }
}
