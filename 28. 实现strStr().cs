public class Solution 
{
    public int StrStr(string haystack, string needle) 
    {
        //解题思路1：BF算法普通模式匹配   (扩展思路：KMP算法)
        if (needle == "")
        {
            return 0;
        }

        int i = 0, j = 0;
        while (i < haystack.Length && j < needle.Length)
        {
            if (haystack[i] == needle[j])
            {
                i++;
                j++;
            }
            else
            {
                i = i - j + 1;      //匹配失败回到开始匹配位置的下一个
                j = 0;              //回到初始位置
            }
        }
        if (j == needle.Length)   //匹配成功
        {
            return i - j;           //找到开始匹配的下标
        }

        return -1;
    }
}