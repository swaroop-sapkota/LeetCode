public class Solution {
    public void MoveZeroes(int[] nums) {
        
        int x = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != 0)
            {
                nums[x] = nums[i];
                x++;
            }
            
        }

        for(int j = x; j < nums.Length; j++)
        {
            nums[j] = 0;
        }
        
    }
}