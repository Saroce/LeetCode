/* 
    思路：利用一个辅助栈实现记录当前比较能放入的最小值
*/
public class MinStack {
    private Stack<int> dataStack = new Stack<int>();
    private Stack<int> minStack = new Stack<int>();

    /** initialize your data structure here. */
    public MinStack() {

    }
    
    public void Push(int x) {
        dataStack.Push(x);
        if (minStack.Count == 0 || minStack.Peek() >= x) {
            minStack.Push(x);
        }
    }
    
    public void Pop() {
        int value = dataStack.Pop();
        if (value == minStack.Peek()) minStack.Pop();
    }
    
    public int Top() {
        return dataStack.Peek();
    }
    
    public int Min() {
        return minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.Min();
 */