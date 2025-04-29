public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> hash = new HashSet<char>();
        int maxLength = 0;
        int left = 0;

        for(int right = 0; right < s.Length; right++)
        {
            while(hash.Contains(s[right]))
            {
                hash.Remove(s[left]);
                left++;
            }

            hash.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}