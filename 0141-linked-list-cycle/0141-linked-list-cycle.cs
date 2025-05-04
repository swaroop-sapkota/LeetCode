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
        if (head == null || head.next == null) return false;  // Edge case for very short lists

        ListNode slowPtr = head;
        ListNode fastPtr = head.next;  // Start fastPtr one step ahead for better logic

        // Start a slow and fast pointer
        while (fastPtr != null && fastPtr.next != null) {
            if (slowPtr == fastPtr) {
                return true; // Cycle found
            }

            // Advance both the pointers
            slowPtr = slowPtr.next;
            fastPtr = fastPtr.next.next;
        }

        return false; // No cycle
    }
}

 /*
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

*/
