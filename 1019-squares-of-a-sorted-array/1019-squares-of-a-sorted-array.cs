public class Solution {
    public int[] SortedSquares(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];
        int p1 = 0, p2 = n - 1;

        for(int i = 0; i < n; i++)
        {
            nums[i] = nums[i] * nums[i];
        }

        for(int x = n - 1; x >= 0; x--)
        {
            if(nums[p1] > nums[p2])
            {
                result[x] = nums[p1];
                p1++;
            }
            else
            {
                result[x] = nums[p2];
                p2--;
            }
        }
        return result;
    }
}