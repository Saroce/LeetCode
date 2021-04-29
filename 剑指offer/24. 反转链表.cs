/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

/* 
    思路1：头插法
    思路2：利用两个指针，cur，prev
*/

public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode dummyNode = new ListNode(-1);

        while (head != null) {
            ListNode temp = head;
            head = head.next;
            temp.next = dummyNode.next;
            dummyNode.next = temp;
        }

        return dummyNode.next;

        /*
        ListNode cur = head, prev = null;
        while (cur != null) {
            ListNode temp = cur.next;
            cur.next = prev;
            prev = cur;
            cur = temp;
        }
        return prev;
        */
    }
}