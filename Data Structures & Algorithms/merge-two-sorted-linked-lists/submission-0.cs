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
        ListNode head = new ListNode(-1, null);
        ListNode temp1 = list1;
        ListNode temp2 = list2;
        ListNode cur = head;
        while(temp1 != null && temp2 != null) {
            ListNode node = new ListNode();
            if(temp1.val <= temp2.val) {
                node.val = temp1.val;
                temp1 = temp1.next;
            }
            else {
                node.val = temp2.val;
                temp2 = temp2.next;
            }
            cur.next = node;
            cur = node;   
        }
        if(temp1 != null) {
            cur.next = temp1;
        }
        if(temp2 != null) {
            cur.next = temp2;
        }
        return head.next;
    }
}