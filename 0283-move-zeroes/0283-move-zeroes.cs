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
        while(x < nums.Length)
        {
            nums[x] = 0;
            x++;
        }
        
    }
}