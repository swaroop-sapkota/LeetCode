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
    public bool IsPalindrome(ListNode head) {

        if (head == null || head.next == null) 
        {
            return true;
        }

        // Middle
        ListNode fast = head, slow = head;

        while(fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        if(fast != null) // odd nodes: let right half smaller
        {
            slow = slow.next;
        }

        // Reverse the second half

        slow = reverseList(slow);
        fast = head;

        // comparing one by one

        while(slow != null)
        {
            if(fast.val != slow.val) return false;

            fast = fast.next;
            slow = slow.next;
        }

        return true;
    }

    private ListNode reverseList(ListNode head)
    {

        ListNode prev = null;
        ListNode curr = head;

        while(curr != null)
        {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }
}