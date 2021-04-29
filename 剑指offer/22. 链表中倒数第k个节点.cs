/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

/*
    思路：双指针解法

*/

public class Solution {
    public ListNode GetKthFromEnd(ListNode head, int k) {
        ListNode p1 = head, p2 = head;
        for (int i = 0; i < k; i++) {
            if (p2 == null) return null;    // k 值大于链表长度情况判断
            p2 = p2.next;
        }
        while (p2 != null) {
            p2 = p2.next;
            p1 = p1.next;
        }
        return p1;
    }
}