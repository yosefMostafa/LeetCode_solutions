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
       if(head == null)
            return false;
        HashSet<ListNode> nodesHandler = new HashSet<ListNode>();
        ListNode node = head;
        while(node != null){
            if(!nodesHandler.Add(node))
                return true;
            node = node.next;
        }
        return false;
        
    }
}