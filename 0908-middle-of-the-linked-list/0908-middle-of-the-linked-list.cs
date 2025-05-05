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
    public ListNode MiddleNode(ListNode head) {
        
        int length = GetLength(head);
        int mid = length / 2;

        for(int i = 0; i < mid; i++)
        {
            head = head.next;
        }

        return head;
    }

    private int GetLength(ListNode temp)
    {
        int length = 0;
        while(temp != null)
        {
            length++;
            temp = temp.next;
        }

        return length;
    }
}