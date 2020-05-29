public class Solution 
{
    public int RomanToInt(string s) 
    {
        if (string.IsNullOrEmpty(s)) return 0;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        dict.Add('I', 1);
        dict.Add('V', 5);
        dict.Add('X', 10);
        dict.Add('L', 50);
        dict.Add('C', 100);
        dict.Add('D', 500);
        dict.Add('M', 1000);
        int res = dict[s[s.Length-1]];
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (dict[s[i]] < dict[s[i+1]])
            {
                res -= dict[s[i]];
            }
            else
            {
                res += dict[s[i]];
            }
        }
        return res;
    }
}