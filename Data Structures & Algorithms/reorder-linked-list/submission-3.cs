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
    public void ReorderList(ListNode head) {
        if (head == null) return;
        ListNode p1 = null;
        ListNode p2 = null;
        SplitList(head, ref p1, ref p2);
        ReverseList(ref p2);
        MergeLists(p1, p2);
    }

    private void SplitList(ListNode head, ref ListNode p1, ref ListNode p2) {
        ListNode slow = head;
        ListNode fast = head.next;

        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        p1 = head;
        p2 = slow.next;
        slow.next = null;
    }

    private void ReverseList(ref ListNode head) {
        ListNode temp = head;
        ListNode prev = null;
    
        while (temp != null) {
            ListNode next = temp.next;
            temp.next = prev;
            prev = temp;
            temp = next;
        }
        head = prev;
    }

    private ListNode MergeLists(ListNode p1, ListNode p2) {
        ListNode temp = p1;

        while (p2 != null) {
            ListNode s1 = temp.next;
            ListNode s2 = p2.next;
            temp.next = p2;
            p2.next = s1;
            temp = s1;
            p2 = s2;
        }
        return p1;
    }
}
