/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 * 输入: 1->2->3->4->5->NULL
 * 输出: 5->4->3->2->1->NULL
 * https://www.cnblogs.com/seniusen/p/9781153.html
 */
public class Solution 
{
    /*解题思路1：迭代法反转链表
    public ListNode ReverseList(ListNode head) 
    {   
        if (head == null || head.next == null)
        {
            return head;
        }

        //链表至少有2个结点
        ListNode p1 = head;               //第一个结点
        ListNode p2 = p1.next;            //第二个结点
        ListNode p3 = p2.next;            //第三个结点

        while (p2 != null)                //第二个结点不为null
        {
            p3 = p2.next;
            p2.next = p1;                   //反转第一个跟第二个结点
            p1 = p2;                        //第1个结点往后移1位
            p2 = p3;                        //第2个结点往后移1位
        }

        head.next = null;                   //第一个head结点作为反转的最后一个结点指向null
        head = p1;                          //再将head结点变成反转后的第一个结点
        return head;
    }*/
    public ListNode ReverseList(ListNode head) 
    {
        ListNode curr = head;
        ListNode prev = null;
        
        while (curr != null)
        {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        
        return prev;
    }

}