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
    public bool HasCycle(ListNode head) 
    {
        if (head == null)
        {
            return false;
        }

        Hashtable ht = new Hashtable(); //创建一个Hashtable实例
        while (head != null)
        {
            if (ht.Contains(head))
            {
                return true;
            }
            ht.Add(head, head.val);
            head = head.next;
        }

        return false;
    }

    /* 解题思路1：快慢指针，若存在环，则两者一定会相遇
    public bool HasCycle(ListNode head) 
    {
        if (head == null)
        {
            return false;
        }
        
        ListNode p2 = head;            //快指针每次走两格
        while (p2 != null && p2.next != null)
        {
            head = head.next;
            p2 = p2.next.next;
            if (head == p2)
            {
                return true;
            }
        }

        return false;
    }*/
}