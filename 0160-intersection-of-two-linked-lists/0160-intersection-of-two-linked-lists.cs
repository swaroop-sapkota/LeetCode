/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        
        int lenA = GetLength(headA);
        int lenB = GetLength(headB);

        while(lenA > lenB)
        {
            lenA--;
            headA = headA.next; 
        }

        while(lenB > lenA)
        {
            lenB--;
            headB = headB.next;
        }

        while(headA != headB)
        {
            headA = headA.next;
            headB = headB.next;    
        }

        return headA;
    }

    private int GetLength(ListNode head)
    {
        int length = 0;
        while(head != null)
        {
            length++;
            head = head.next;
        }
        return length;
    }
}