public class Solution 
{
    public int MaxSubArray(int[] nums) 
    {
        int dp = nums[0];
        int res = dp;
        for (int i = 1; i < nums.Length; i++)
        {
            dp = Math.Max(dp + nums[i], nums[i]);
            res = Math.Max(dp, res);
        }
        return res;
    }

    /*https://www.cnblogs.com/patatoforsyj/p/9463945.html
    public int MaxSubArray(int[] nums) 
    {
        int dp = new int[nums.Length];
        dp[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            dp[i] = Math.Max(dp[i - 1] + nums[i], nums[i]);
        }
        int k = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (dp[i] > dp[k]) k = i;
        }
        return dp[k];
    }*/
}