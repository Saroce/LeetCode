/*
    思路：借用一个辅助栈模拟入栈，出栈操作。若最后辅助栈为空，则检验正确
*/

public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) {
        Stack<int> stack = new Stack<int>();
        int popIndex = 0;
        for (int i = 0; i < pushed.Length; i++) {
            stack.Push(pushed[i]);
            while (stack.Count > 0 && stack.Peek() == popped[popIndex]) {
                stack.Pop();
                popIndex++;
            }
        }
        return stack.Count == 0;
    }
}