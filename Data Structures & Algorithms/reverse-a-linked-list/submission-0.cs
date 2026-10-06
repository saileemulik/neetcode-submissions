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
         ListNode prev = null;

        while (head != null)
        {
            ListNode next = head.next;  // Save original next

            head.next = prev;           // Reverse the link

            prev = head;                // Move prev forward
            head = next;                // Move head forward
        }

        return prev;
        
    }
}
