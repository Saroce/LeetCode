/*
    思路：动态规划转移方程dp[i] = dp[i - 1] + dp[i - 2]
    dp 列表第i项只与第i-1和第i-2项有关，因此只需要初始化三个整形变量 sum, a, b ，
    利用辅助变量sum使a, b两数字交替前进即可 （具体实现见代码） 。因为节省dp列表空间，因此空间复杂度降至 O(1)
*/

public class Solution {
    public int NumWays(int n) {
        int a = 1, b = 1;
        int sum = 0;
        
        for (int i = 0; i < n; i++) {
            sum = (a + b) % 1000000007;
            a = b;
            b = sum;
        }

        return a;
    }
}