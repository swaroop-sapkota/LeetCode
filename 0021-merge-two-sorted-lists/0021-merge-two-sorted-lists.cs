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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        ListNode returnNode = new ListNode(0);
        ListNode headNode = returnNode;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                returnNode.next = list1;
                list1 = list1.next;
            }
            else
            {
                returnNode.next = list2;
                list2 = list2.next;
            }
            returnNode = returnNode.next;
        }

        if (list1 == null)
        {
            returnNode.next = list2;
        }
        else
        {
            returnNode.next = list1;
        }

        return headNode.next;
    }
}
