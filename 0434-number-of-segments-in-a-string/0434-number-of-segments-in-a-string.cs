public class Solution {
    public int CountSegments(string s) {
        string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        // The length of the words array is the number of segments (words)
        return words.Length;
    }
}