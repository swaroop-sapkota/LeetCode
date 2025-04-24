public class Solution {
    public int MajorityElement(int[] nums) {
        
        // Moores voting algorithm

        int majority = nums[0], votes = 1;
        
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] == majority) votes++;
            else if(votes == 0)
            {
                votes++;
                majority = nums[i];
            }
            else
            {
                votes--;
            }
        }
        return majority;

    }
}