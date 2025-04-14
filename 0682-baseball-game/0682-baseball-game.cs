public class Solution {
    public int CalPoints(string[] operations) {
        
        Stack<int> nums = new Stack<int>();
        int total = 0;

        foreach (string op in operations) 
        {
            if (op == "+")
            {
                int top = nums.Pop();  
                int secondTop = nums.Peek(); 
                nums.Push(top); 
                nums.Push(top + secondTop);  
            }
            else if (op == "D")
            {
                nums.Push(2 * nums.Peek()); 
            }
            else if (op == "C")
            {
                nums.Pop();  
            }
            else
            {
                nums.Push(int.Parse(op));  
            }
        }

        foreach (var num in nums)
        {
            total += num;  
        }

        return total;
    }
}
