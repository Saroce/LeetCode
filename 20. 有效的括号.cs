public class Solution 
{
    public bool IsValid(string s) 
    {
        if (s == "")
        {
            return true;
        }
        
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                stack.Push(s[i]);
            }
            if (s[i] == ')' || s[i] == '}' || s[i] == ']')   //弹出栈顶元素进行消除
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                char topItem = stack.Pop();
                if (s[i] == ')' && topItem != '(')
                {
                    return false;
                }
                if (s[i] == '}' && topItem != '{')
                {
                    return false;
                }
                if (s[i] == ']' && topItem != '[')
                {
                    return false;
                }
            }
        }
        
        return stack.Count == 0;
    }
}