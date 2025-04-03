public class Solution {
    public string ReverseVowels(string s) {
        
        char[] chars = s.ToCharArray();
        int i = 0;
        int j = s.Length - 1;
        
        bool IsVowel(char c) 
        {
            c = char.ToLower(c);
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }

        while (i < j) {
            if (!IsVowel(chars[i])) 
            {
                i++;
            } 
            else if (!IsVowel(chars[j])) 
            {
                j--;
            } else 
            {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
                i++;
                j--;
            }
        }

        return new string(chars);
    }
}