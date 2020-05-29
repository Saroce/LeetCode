/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution 
{
    //双指针移动解法
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        ListNode left = head;
        ListNode right = head;

        for (int i = 0; i < n; i++)
        {
            right = right.next;
        }
        if (right == null)
        {
            return head.next;
        }
        while (right.next != null)
        {
            right = right.next;
            left = left.next;
        }

        left.next = left.next.next;
        return head;
    }
}