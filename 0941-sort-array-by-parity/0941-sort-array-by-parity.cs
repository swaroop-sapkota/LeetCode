using System;
using System.Collections.Generic;

public class Solution {
    public int[] SortArrayByParity(int[] nums) {
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
    }
}

    // Time Complexity = O(n)