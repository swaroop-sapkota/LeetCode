public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> hash = new HashSet<char>();
        int maxLength = 0;
        int left = 0, right = 0;

        while(right < s.Length)
        {
            if(!hash.Contains(s[right]))
            {
                hash.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
            }
            else
            {
                hash.Remove(s[left]);
                left++;
            }
        }
        return maxLength;
    }
}