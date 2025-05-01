/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        
        Stack<int> stack = new Stack<int>();

        while(head != null)
        {
            stack.Push(head.val);
            head = head.next;

        }

        ListNode result = new ListNode(0);

        ListNode ptr = result;

        while(stack.Count > 0)
        {
            ptr.next = new ListNode(stack.Pop());
            ptr = ptr.next;
        }

        return result.next;
    }
}