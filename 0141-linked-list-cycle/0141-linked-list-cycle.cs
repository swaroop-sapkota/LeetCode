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
        ListNode slowPtr = head;
        ListNode fastPtr = head;

        while(slowPtr != null && fastPtr != null && fastPtr.next != null)
        {
            slowPtr = slowPtr.next;
            fastPtr = fastPtr.next.next;

            if(slowPtr == fastPtr)
            {
                return true;
            }
        }
        return false;
    }
}

/*
        // HashSet to store visited nodes
        HashSet<ListNode> visitedNodes = new HashSet<ListNode>();
        
        // Traverse the linked list
        while (head != null) {
            // If the current node is already in the hash set, cycle is detected
            if (visitedNodes.Contains(head)) {
                return true;
            }
            
            // Add current node to the hash set
            visitedNodes.Add(head);
            
            // Move to the next node
            head = head.next;
        }
        
        // No cycle found
        return false;

*/
