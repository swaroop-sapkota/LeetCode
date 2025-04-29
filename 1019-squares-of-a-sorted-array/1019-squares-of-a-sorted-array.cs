public class Solution {
    public int[] SortedSquares(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];
        int p1 = 0, p2 = n - 1;

        int pos = n - 1;

        while(p1 <= p2)
        {
            int left = nums[p1] * nums[p1];
            int right = nums[p2] * nums[p2];

            if(left > right)
            {
                result[pos--] = left;
                p1++;
            }
            else
            {
                result[pos--] = right;
                p2--;
            }
        }

        return result;
    }
}