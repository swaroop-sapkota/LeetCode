public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        HashSet<int> hash = new HashSet<int>();

        foreach(var n in nums)
        {
            if(!hash.Add(n))
            {
                return true;
            }
        }

        return false;  
    }
}