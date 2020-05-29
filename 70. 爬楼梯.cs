public class Solution {
    public int ClimbStairs(int n) 
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        if (n == 2) return 2;
        
        int a = 1, b = 2, cur = 0;
        for (int i = 3; i <= n; i++)
        {
            cur = a + b;
            a = b;
            b = cur;
        }
        return cur;
    }
}