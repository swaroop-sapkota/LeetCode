public class Solution {
    public int LengthOfLastWord(string s) {
        int length = 0;
        int last = s.Length - 1;

        while(s[last] == ' ')
        {
            last--;
        }

        while(last >= 0 && s[last] != ' ')
        {
            length++;
            last--;
        }

        return length;

    }
}