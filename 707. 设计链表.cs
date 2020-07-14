/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */

public class LinkedNode
{
    public LinkedNode next;
    public int val;

    public LinkedNode(int val)
    {
        this.val = val;
    }
}

public class MyLinkedList
 {
     private LinkedNode head;
     public int totalNodeCount;


    /** Initialize your data structure here. */
    public MyLinkedList() 
    {
        head = new LinkedNode(-1);
        totalNodeCount = 0;
    }
    
    /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
    public int Get(int index) {
        if (index < 0 || index >= totalNodeCount) return - 1;
        LinkedNode p = head;
        for (int i = 0; i < index + 1; i++)
        {
            p = p.next;
        }
        return p.val;
    }
    
    /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
    public void AddAtHead(int val) {
        LinkedNode p = new LinkedNode(val);
        p.next = head.next;
        head.next = p;
        totalNodeCount++;
    }
    
    /** Append a node of value val to the last element of the linked list. */
    public void AddAtTail(int val) {
        AddAtIndex(totalNodeCount, val);
    }
    
    /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
    public void AddAtIndex(int index, int val) {
      
        if (index > totalNodeCount) return;
        if (index < 0) index = 0;  
        LinkedNode temp = new LinkedNode(val);
        LinkedNode p = head;
        for (int i = 0; i < index; i++)
        {
            p = p.next;
        }
        temp.next = p.next;
        p.next = temp;
        totalNodeCount++;
    }
    
    /** Delete the index-th node in the linked list, if the index is valid. */
    public void DeleteAtIndex(int index) {
        if (index < 0 || index >= totalNodeCount) return;
        for (int i = 0; i < index; i++)
        {
            p = p.next;
        }
        p.next = p.next.next;
        totalNodeCount--;
    }
}