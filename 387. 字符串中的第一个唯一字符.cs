public class Solution 
{
    public int FirstUniqChar(string s) 
    {
        int[] letter = new int[26];    //总共26个字母(小写)   若包括大写可转换成哈希表来存储一遍遍历各个字母出现的频率

        for (int i = 0; i < s.Length; i++)
        {
            letter[s[i] - 'a']++;     //第一次遍历找出各个字符出现的次数  'A' 65 'a' 97
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (letter[s[i] - 'a'] == 1)     //找出第一个次数为1的则为唯一出现的字母
            {
                return i;
            }
        }

        return -1;
    }


    /* 解题思路1：遍历字符串利用自带的方法提供左右搜索，若左右搜索的下标一致，
    则此字符为唯一出现字符
    public int FirstUniqChar(string s) 
    {
        char temp = ' ';
        for (int i = 0; i < s.Length; i++)
        {
            temp = s[i];
            if (s.IndexOf(temp) == s.LastIndexOf(temp))
            {
                return i;
            }
        }

        return - 1;
    }*/
}