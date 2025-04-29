public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] result = new int[nums1.Length];
        Stack<int> stack = new Stack<int>();

        for (int i = nums2.Length - 1; i >= 0; i--) 
        {
            int n = nums2[i];

            while (stack.Count > 0 && stack.Peek() <= n) 
            {
                stack.Pop();
            }

            int nextGreater = stack.Count > 0 ? stack.Peek() : -1;

            for (int j = 0; j < nums1.Length; j++) 
            {
                if (nums1[j] == n) {
                    result[j] = nextGreater;
                }
            }

            stack.Push(n);
        }

        return result;
    }
}
