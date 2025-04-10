public class Solution {
    public char FindTheDifference(string s, string t) {
        
        int sumS = 0, sumT = 0;

        foreach (char c in s)
        {
            sumS += c;
        }

        foreach(char c in t)
        {
            sumT += c;
        }

        return (char)(sumT - sumS);
}
}
/*
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
*/