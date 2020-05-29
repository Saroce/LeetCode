public class Solution 
{
    public void ReverseString(char[] s) 
    {
        int end = s.Length - 1;
        int start = 0;
        char temp;

        while (start < end)
        {
            temp = s[start];
            s[start++] = s[end];
            s[end--] = temp;
        }
    }
}