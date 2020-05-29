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
    //注：传入的结点为待删除的结点
    public void DeleteNode(ListNode node) 
    {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}