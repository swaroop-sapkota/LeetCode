public class Solution {
    public string ReverseStr(string s, int k) 
    {
        char[] chars = s.ToCharArray();  


        for(int i = 0; i < s.Length; i += 2 * k)
        {
            int left = i;  
            int right = Math.Min(i + k - 1, s.Length - 1); 

            while(left < right)
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
                left++;
                right--;
            }
        }       

        return new string(chars);
    }
}