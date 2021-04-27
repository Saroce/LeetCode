/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

/*
    思路：直接删除节点，注意边界条件
*/

public class Solution {
    public ListNode DeleteNode(ListNode head, int val) {
        ListNode p = head;
        while (p != null) {
            if (p.val == val) {     // 删除首节点值相等情况
                return p.next;
            }
            if (p.next != null && p.next.val == val) {
                p.next = p.next.next;
                break;
            }
            p = p.next;
        }

        return head;
    }
}