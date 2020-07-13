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
        next = null;
    }
}

public class MyLinkedList
 {
     private LinkedNode head;
     private LinkedNode tail;
     public int totalNodeCount;


    /** Initialize your data structure here. */
    public MyLinkedList() {
    }
    
    /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
    public int Get(int index) {
        if (index < 0 || index >= totalNodeCount) return - 1;
        LinkedNode p = head;
        for (int i = 0; i < index; i++)
        {
            p = p.next;
        }
        return p.val;
    }
    
    /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
    public void AddAtHead(int val) {
        LinkedNode p = new LinkedNode(val);
        p.next = head;
        head = p;
        totalNodeCount++;
        //添加第一个元素特殊情况
        if (totalNodeCount == 1) tail = p;
    }
    
    /** Append a node of value val to the last element of the linked list. */
    public void AddAtTail(int val) {
        LinkedNode p = new LinkedNode(val);
        tail.next = p;
        tail = p;
        totalNodeCount++;
    }
    
    /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
    public void AddAtIndex(int index, int val) {
        if (index <= 0) AddAtHead(val);
        else if (index == totalNodeCount) AddAtTail(val);
        else if (index > totalNodeCount) return;
        else {
            LinkedNode p = head;
            //找到待插入的前一个节点
            for (int i = 0; i < index - 1; i++)
            {
                p = p.next;
            }

            LinkedNode temp = new LinkedNode(val);
            temp.next = p.next;
            p.next = temp;
        }
        totalNodeCount++;
    }
    
    /** Delete the index-th node in the linked list, if the index is valid. */
    public void DeleteAtIndex(int index) {
        if (index < 0 || index >= totalNodeCount) return;
        // 删除头结点
        if (index == 0) head.next = head.next.next;
        else {
            LinkedNode p = head;
            // 找到待删除的前一个结点
            for (int i = 0; i < index - 1; i++)
            {
                p = p.next;
            }
            p.next = p.next.next;
            // 若删除的是尾元素，更新tail
            if (index == totalNodeCount - 1) tail = p;
        }
        totalNodeCount--;
    }
}