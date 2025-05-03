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
    public int GetDecimalValue(ListNode head) {
       ListNode temp = head;
        int sum = 0;

       while(temp != null)
       {
            sum = sum * 2 + temp.val;
            temp = temp.next;

       }

       return sum;

    }
}