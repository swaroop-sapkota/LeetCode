public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        foreach(char c in s)
        {
            if(c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }

            if(stack.Count == 0)
            {
                return false;
            }

            else if(c == ')')
            {
                if(stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else if(c == '}')
            {
                if(stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else if(c == ']')
            {
                if(stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else 
                {
                    return false;
                }
            }
        }
        if(stack.Count != 0)
        {
            return false;
        }

        return true;
    }
}
