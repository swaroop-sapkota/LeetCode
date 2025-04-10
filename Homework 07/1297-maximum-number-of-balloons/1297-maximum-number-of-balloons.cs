public class Solution {
    public int MaxNumberOfBalloons(string text) {
        int b = 0, a = 0, l = 0, o = 0, n = 0;

        
        foreach (char c in text) {
            if (c == 'b') b++;
            else if (c == 'a') a++;
            else if (c == 'l') l++;
            else if (c == 'o') o++;
            else if (c == 'n') n++;
        }

        
        l /= 2;
        o /= 2;

        int min = b;  
        if (a < min) min = a; 
        if (l < min) min= l;  
        if (o < min) min = o; 
        if (n < min) min = n; 

        return min; 
    }
}