public class Solution {
    public string ReversePrefix(string word, char ch) {
        
        List<char> words = new List<char>(word);

        int p1 = 0;
        int p2 = 0;

        for(int i = 0; i < words.Count; i++)
        {
            if(ch.Equals(words[i]))
            {
                p2 = i;
                break;
            }
        }

        if(p2 == -1)
        {
            return word;
        }

        while(p1 < p2)
        {
            char temp = words[p2];
            words[p2] = words[p1];
            words[p1] = temp;

            p1++;
            p2--;
        }

        return new string(words.ToArray());
    }
}