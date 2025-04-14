public class Solution {
    public int PivotIndex(int[] nums) {
        int total = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            total += nums[i];
        }

        int left = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            int right = total - left - nums[i];
            if(left == right) return i;
            left += nums[i];
        }

        return -1;
    }
}