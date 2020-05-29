public class Solution 
{
    public string CountAndSay(int n) 
    {
        if (n == 1) return "1";
        string s = "1";
        for (int i = 2; i <= n; i++)
        {
            s = convert(s);
        }
        return s;
    }

    private static string convert(string s)
    {
        StringBuilder sb = new StringBuilder();
        int count = 1;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                count++;
                continue;
            }
            else
            {
                sb.Append(count).Append(s[i - 1]);
                count = 1;
            }
        }
        sb.Append(count).Append(s[s.Length - 1]);
        return sb.ToString();
    }
}