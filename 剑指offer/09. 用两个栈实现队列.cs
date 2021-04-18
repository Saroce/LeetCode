/*
    思路：一个栈用于模拟队列尾部插入元素，另外一个栈模拟队列删除元素
    根据栈与队列的性质，删除栈的元素要存放插入栈的全部元素
*/
public class CQueue {
    private Stack<int> stack1 = new Stack<int>();
    private Stack<int> stack2 = new Stack<int>();
    public CQueue() {

    }
    
    public void AppendTail(int value) {
        stack1.Push(value);
    }
    
    public int DeleteHead() {
        if (stack2.Count > 0) {
            return stack2.Pop();
        }
        while (stack1.Count > 0) {
            stack2.Push(stack1.Pop());
        }
        return stack2.Count > 0 ? stack2.Pop() : -1;
    }
}

/**
 * Your CQueue object will be instantiated and called as such:
 * CQueue obj = new CQueue();
 * obj.AppendTail(value);
 * int param_2 = obj.DeleteHead();
 */