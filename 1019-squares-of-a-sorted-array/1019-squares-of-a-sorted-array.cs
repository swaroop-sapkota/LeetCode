public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] result = new int[nums.Length];

        for(int i = 0; i < nums.Length; i++)
        {
            result[i] = nums[i] * nums[i];
        }

        for(int i = 0; i < result.Length; i++)
        {
            for(int j = 0; j < result.Length - i - 1; j++)
            {
                if(result[j] > result[j+1])
                {
                    int temp = result[j];
                    result[j] = result[j+1];
                    result[j+1] = temp;
                }
            }
        }

        return result;
    }
}