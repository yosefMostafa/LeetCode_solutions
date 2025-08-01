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
         if (head == null || head.next == null) return false;
        
        ListNode slow = head;
        ListNode fast = head;
        
        while (fast != null && fast.next != null) {
            slow = slow.next;           // move 1 step
            fast = fast.next.next;      // move 2 steps
            
            if (slow == fast) return true; // cycle detected
        }
        
        return false; // no cycle
    //    if(head == null)
    //         return false;
    //     HashSet<ListNode> nodesHandler = new HashSet<ListNode>();
    //     ListNode node = head;
    //     while(node != null){
    //         if(!nodesHandler.Add(node))
    //             return true;
    //         node = node.next;
    //     }
    //     return false;
        
    }
}