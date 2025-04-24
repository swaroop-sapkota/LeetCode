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

        // By Sorting
        /*
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = 0; j < nums.Length - i - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    int temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                }
            }
        }
        return nums[nums.Length / 2];
        */

    }
}