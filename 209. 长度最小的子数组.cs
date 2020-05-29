public class Solution 
{
    public int MinSubArrayLen(int s, int[] nums) 
    {
        int minLen = int.MaxValue;
        int left = 0, right = 0;
        int sum = 0;
        while (right < nums.Length)
        {
            sum += nums[right++];
            while (sum >= s)
            {
                minLen = Math.Min(right - left, minLen);
                sum -= nums[left++];
            }
        }
        return minLen == int.MaxValue ? 0 : minLen;
    }
}