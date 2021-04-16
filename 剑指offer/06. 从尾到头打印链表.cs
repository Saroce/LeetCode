/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

/*
    思路1：遍历一遍链表，利用栈的特性存放链表元素
    思路2：链表不长可考虑递归，回溯添加元素
*/

public class Solution {
    public int[] ReversePrint(ListNode head) {
        Stack<int> stack = new Stack<int>();
        while (head != null) {
            stack.Push(head.val);
            head = head.next;
        }

        int[] arr = new int[stack.Count];
        while (stack.Count > 0) {
            arr[arr.Length - stack.Count] = stack.Pop();
        }
        return arr;
    }
/*    
    private List<int> list = new List<int>();
    public int[] ReversePrint(ListNode head) {
        DFS(head);
        return list.ToArray();
    }

    private void DFS(ListNode node) {
        if (node == null) return;
        DFS(node.next);
        list.Add(node.val);
    }
*/
}