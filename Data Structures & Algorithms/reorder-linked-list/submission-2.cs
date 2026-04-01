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
        if(head == null) return;

        ListNode list1 = new ListNode();
        ListNode list2 = new ListNode();

        SplitList(head, ref list1, ref list2);
        ReverseList(ref list2);
        head = MergeLists(list1, list2);
    }

    public void SplitList(ListNode head, ref ListNode list1, ref ListNode list2) {
        ListNode slow = head;
        ListNode fast = head.next;
        while(fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        list1 = head;
        list2 = slow.next;
        slow.next = null;

    }

    public void ReverseList(ref ListNode list) {
        ListNode prev = null, cur = list;
        while(cur != null) {
            ListNode temp = cur.next;
            cur.next = prev;
            prev = cur;
            cur = temp;
        }
        list = prev;
    }

    public ListNode MergeLists(ListNode list1, ListNode list2) {
        ListNode cur = list1;
        while(list2 != null) {
            ListNode temp1 = cur.next;
            ListNode temp2 = list2.next;
            cur.next = list2;
            list2.next = temp1;
            cur = temp1;
            list2 = temp2;
        }

        return list1;
    }
}
