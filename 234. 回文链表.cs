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
    public bool IsPalindrome(ListNode head) 
    {
        if (head == null || head.next == null)
        {
            return true;
        }
        ListNode slow = head, fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        slow = reverseNode(slow);
        while (head != null && slow != null)
        {
            if (head.val != slow.val)
            {
                return false;
            }
            head = head.next;
            slow = slow.next;
        }
        return true;
    }

    private ListNode reverseNode(ListNode head)
    {
        ListNode pre = null;
        while (head != null)
        {
            ListNode temp = head.next;
            head.next = pre;
            pre = head;
            head = temp;
        }
        return pre;
    }
}


/*
public bool IsPalindrome(ListNode head)    //利用栈的特性，先进后出也可以解
{
    if (head == null)
    {
        return true;
    }
    List<int> list = new List<int>();
    while (head != null)
    {
        list.Add(head.val);
        head = head.next;
    }
    int left = 0, right = list.Count - 1;
    while (left < right)
    {
        if (list[left++] != list[right--])
        {
            return false;
        }
    }
    return true;
}
*/
