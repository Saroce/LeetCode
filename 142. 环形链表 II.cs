/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution 
{
    /* 哈希表处理，将遍历的每一个结点都存起来
    遇到相同结点，则有环，返回这个入环结点，否则返回null
    public ListNode DetectCycle(ListNode head) 
    {
        HashSet<ListNode> set = new HashSet<ListNode>();
        
        while (head != null)
        {
            if (set.Contains(head)) return head;
            else set.Add(head);
            head = head.next;
        }
        return null;
    }*/

    // 双指针解法
    public ListNode DetectCycle(ListNode head) 
    {
        if (head == null || head.next == null) return null;
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast) break;
        }
        if (slow != fast) return null;   //无环情况

        fast = head;
        while (fast != slow)
        {
            slow = slow.next;
            fast = fast.next;
        }
        return fast;
    }
}
