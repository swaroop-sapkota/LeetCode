public class Solution {
    public int CountSegments(string s) {
        int count = 0;
        bool inSegment = false;  // To track if we're inside a word

        // Step through each character in the string
        for (int i = 0; i < s.Length; i++) {
            // If we encounter a non-space character
            if (s[i] != ' ') {
                // If we are not already inside a word, this is the start of a new word
                if (!inSegment) {
                    count++;
                    inSegment = true;  // We are now inside a word
                }
            } else {
                // If we encounter a space, we are no longer inside a word
                inSegment = false;
            }
        }

        return count;  // Return the total number of words (segments)
    }
}
