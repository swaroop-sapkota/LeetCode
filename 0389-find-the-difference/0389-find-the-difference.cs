public class Solution {
    public char FindTheDifference(string s, string t) {
        
        List<char> sList = new List<char>(s);

        foreach(char c in t)
        {
            if(sList.Contains(c))
            {
                sList.Remove(c);
            }

            else
            {
                return c;
            }
        }

        return '\0';
}
}