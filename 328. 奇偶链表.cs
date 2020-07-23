/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode OddEvenList(ListNode head) 
    {
        if (head == null) return null;
        int i = 0;
        ListNode oddHead = new ListNode(-1), evenHead = new ListNode(-1);
        ListNode oddTail = oddHead, evenTail = evenHead;
        
        while (head != null)
        {
            if (++i % 2 == 1)       //序号为奇数
            {
                oddTail.next = head;
                oddTail = head;
            }
            else
            {
                evenTail.next = head;
                evenTail = head;
            }
            head = head.next;
        }
        evenTail.next = null;
        oddTail.next = evenHead.next;
        return oddHead.next;
    }
    
    /* 原地控制指针next指向得到解法
    public ListNode OddEvenList(ListNode head) 
    {
        if (head == null) return null;
        ListNode odd = head, evenHead = head.next, even = evenHead;
        while (even != null && even.next != null)
        {
            odd.next = even.next;
            odd = odd.next;
            even.next = odd.next;
            even = even.next;
        }
        odd.next = evenHead;
        return head;
    }
    */
}