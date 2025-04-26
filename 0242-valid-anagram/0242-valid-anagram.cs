public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if (s.Length != t.Length) {
            return false;
        }

        Dictionary<char, int> letterCounts = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            char letter = s[i];

            if (letterCounts.ContainsKey(letter)) {
                letterCounts[letter] = letterCounts[letter] + 1;
            } else {
                letterCounts[letter] = 1;
            }
        }

        for (int i = 0; i < t.Length; i++) {
            char letter = t[i];

            if (!letterCounts.ContainsKey(letter)) {
                return false;
            }

            letterCounts[letter] = letterCounts[letter] - 1;

            if (letterCounts[letter] < 0) {
                return false;
            }
        }

        return true;
    }
}
