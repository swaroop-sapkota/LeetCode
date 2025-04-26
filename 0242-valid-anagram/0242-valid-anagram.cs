public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) return false;

        Dictionary<char, int> letterCounts = new Dictionary<char, int>();

        foreach (char letter in s) {
            if (letterCounts.ContainsKey(letter)) {
                letterCounts[letter]++;
            } else {
                letterCounts[letter] = 1;
            }
        }

        foreach (char letter in t) {
            if (!letterCounts.ContainsKey(letter)) {
                return false;
            }

            letterCounts[letter]--;

            if (letterCounts[letter] < 0) {
                return false;
            }
        }
        return true;
    }
}
