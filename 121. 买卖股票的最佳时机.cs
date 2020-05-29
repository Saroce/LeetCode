public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        if (prices == null || prices.Length == 0) return 0;
        int maxProfit = 0;
        int dp = prices[0];
        for (int i = 1; i < prices.Length; i++)
        {
            dp = Math.Min(dp, prices[i]);
            maxProfit = Math.Max(maxProfit, prices[i] - dp);
        }
        return maxProfit;
    }
}