public class Solution 
{
    public int Rob(int[] nums) 
    {
        int len = nums.Length;
        int prev = 0;
        int cur = 0;
        for (int i = 0; i < len; i++)
        {
            int temp = cur;
            cur = Math.Max(cur, prev + nums[i]);
            prev = temp;
        }
        return cur;
    }

    /*public int Rob(int[] nums)     正规dp做法
    {
        int len = nums.Length;
        if (nums == null || len == 0) return 0;
        if (len == 1) return nums[0];
        if (len == 2) return Math.Max(nums[0], nums[1]);

        int[] dp = new int[len];
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0], nums[1]);
        for (int i = 2; i < len; i++)
        {
            dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
        }
        return dp[len - 1];
    }*/
}