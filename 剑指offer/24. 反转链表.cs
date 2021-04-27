/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

/* 
    思路：头插法
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
    }
}