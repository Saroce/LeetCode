public class Solution 
{
    //思路：哈希表的运用(处理全部可能出现的字母)
    public bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.ContainsKey(s[i]))
            {
                dict.Add(s[i], 1);
            }
            else
            {
                dict[s[i]]++;
            }
        }
        for (int j = 0; j < s.Length; j++)
        {
            if (!dict.ContainsKey(t[i]) || --dict[t[i]] < 0)
            {
                return false;
            }
        }
        
        return true;
    }


    /*   只针对出现的全是小写字母的处理
    public bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        int[] nums = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            nums[s[i] - 'a']++;
            nums[t[i] - 'a']--;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                return false;
            }
        }
        return true;
    }
    */
}