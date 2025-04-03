public class Solution {
    public int[] SortArrayByParity(int[] nums) {

        int i = 0;
        int j = nums.Length - 1;

        while(i < j)
        {
            if(nums[i] % 2 > nums[j] % 2)
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }

            if(nums[i] % 2 == 0)
            {
                i++;
            }

            if(nums[j] % 2 != 0)
            {
                j--;
            }
        }
        return nums;
 
    }
}

    // Time Complexity = O(n)
    

       /*
        List<int> result = new List<int>();

        foreach(int num in nums)
        {
            if(num % 2 == 0)
            {
                result.Add(num);
            }
        }

        foreach(int num in nums)
        {
            if(num % 2 != 0)
            {
                result.Add(num);
            }
        }

        return result.ToArray(); 
        */

           