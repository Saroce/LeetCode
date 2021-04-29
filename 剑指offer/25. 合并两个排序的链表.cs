/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

/*
    思路：两个链表都有序，直接遍历两个链表，每次比较两个链表头节点，将较小
    值的节点放到合并的新链表中
*/

public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode dummyNode = new ListNode(-1);
        ListNode prev = dummyNode;
        while (l1 != null && l2 != null) {
            if (l1.val <= l2.val) {
                prev.next = l1;
                l1 = l1.next;
            } 
            else {
                prev.next = l2;
                l2 = l2.next; 
            }
            prev = prev.next;
        }
        prev.next = l1 == null ? l2 : l1;
        return dummyNode.next;
    }
}