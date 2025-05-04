/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {


        if(head == null) return false;

        // Start a slow and fast pointer
        ListNode slowPtr = head;
        ListNode fastPtr = head;

        while(fastPtr != null && fastPtr.next != null)
        {

            // Advance both the pointers
            slowPtr = slowPtr.next;
            fastPtr = fastPtr.next.next;

            // if they meet we found a loop
            if(slowPtr == fastPtr)
            {
                return true;
            }
        }
        return false;
    }
}
