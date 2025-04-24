public class Solution {
    public void ReverseString(char[] s) {
        
        int j = s.Length - 1;
        
        for(int i = 0; i < j; i++, j--)
        {
            char temp = s[i];
            s[i] = s[j];
            s[j] = temp;
            
        }

    }
}