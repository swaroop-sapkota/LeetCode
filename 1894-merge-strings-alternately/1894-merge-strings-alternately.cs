public class Solution {
    public string MergeAlternately(string word1, string word2) {
        //Queue<char> queue = new Queue<char>();
        int p = 0, q = 0;
        string result = "";
        
        while (p < word1.Length || q < word2.Length) 
        {
            if (p < word1.Length) 
            {
                //queue.Enqueue(word1[p]);
                result += word1[p];
                p++;
            }
            if (q < word2.Length) {
                //queue.Enqueue(word2[q]);
                result += word2[q];
                q++;
            }
        }
        
        return result;
        //return new string(queue.ToArray());
    }
}
