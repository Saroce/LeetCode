/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

/*
    思路1：用哈希表建立原链表与复制链表的隐射关系。遍历二遍原链表即可
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        if (head == null) return null;
        Dictionary<Node, Node> dict = new Dictionary<Node, Node>();
        Node cur = head;
        while (cur != null) {
            Node node = new Node(cur.val);
            dict.Add(cur, node);
            cur = cur.next;
        }
        cur = head;
        while (cur != null) {
            if (cur.next != null) {
                dict[cur].next = dict[cur.next];
            }
            if (cur.random != null) {
                dict[cur].random = dict[cur.random];
            }
            cur = cur.next;
        }
        return dict[head];
    }
}