public class Solution 
{
    //利用char的方法判断
    //IsLetterOrDight, IsDigit, IsLower, IsUpper
    public bool IsPalindrome(string s) 
    {
        if (string.IsNullOrEmpty(s))
            return true;
        s = s.ToLower();
        int left = 0, right = s.Length - 1;
        while (left < right)
        {
            if (!isVaild(s[left]))
            {
                left++;
                continue;
            }
            if (!isVaild(s[right]))
            {
                right--;
                continue;
            }
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
    
    private bool isVaild(char ch)
    {
        if ((ch >= 'a' && ch <= 'z')|| (ch >= '0' && ch <= '9'))
        {
            return true;
        }
        return false;
    }
}