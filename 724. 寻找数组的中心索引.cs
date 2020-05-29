public class Solution 
{
    /*
    public int PivotIndex(int[] nums) 
    {
        if (nums == null || nums.Length < 1) return -1;
        int sum1 = 0, sum2 = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            sum2 += nums[i];
        }
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (sum1 == sum2) return i;
            sum1 += nums[i];
            sum2 -= nums[i + 1];
        }
        if (sum1 == sum2) return nums.Length - 1;
        return -1;
    }*/

    /* leftSum = sum - num[i] - rightSum  公式
    public int PivotIndex(int[] nums) 
    {
        int leftSum = 0, rightSum = 0;
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
            sum += nums[i];
        for (int i = 0; i < nums.Length; i++)
        {
            if (2*leftSum == sum - nums[i]) return i;
            leftSum += nums[i];
        }
        return -1;
    }
    */
}