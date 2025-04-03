//using System;
//using System.Collections.Generic;

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


       /*
        List<int> even = new List<int>();
        List<int> odd = new List<int>();

        foreach(int num in nums)
        {
            if(num % 2 == 0)
            {
                even.Add(num);
            }
            else
            {
                odd.Add(num);
            }
        }

        even.AddRange(odd);
        return even.ToArray(); 
        */

            
    }
}

    // Time Complexity = O(n)