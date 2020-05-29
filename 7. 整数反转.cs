public class Solution 
{
    /*将数字转换为字符串处理
    public int Reverse(int x) 
    {
        string s = x < 0 ? x.ToString().Substring(1) : x.ToString();
        long total = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            int num = s[i] - '0';
            total = total * 10 + num;
            if (total > int.MaxValue)
                return 0;
        }
        return x < 0 ? -(int)total : (int)total;
    }*/
    public int Reverse(int x) 
    {
        long total = x % 10;
        while (x < -9 || x > 9)
        {
            x /= 10;
            total = total * 10 + x % 10;
        }
        if (total < int.MinValue || total > int.MaxValue)
            return 0;
        return total;
    }
}