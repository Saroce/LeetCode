public class Solution 
{
    //滑动窗口解法
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int left = 0, right= 0;
        int maxCount = 0;
        while (right < nums.Length)
        {
            if (nums[right++] == 0)
            {
                maxCount  = Math.Max(maxCount, right - left - 1);
                left = right;
            }
        }
        return Math.Max(maxCount, right - left);
    }

    /*常规解法
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int maxCount = 0, count = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                count++;
            }
            else if (count != 0 && nums[i] == 0)
            {
                maxCount = count > maxCount ? count : maxCount;
                count = 0;
            }
        }
        return count > maxCount ? count : maxCount;;
    }
    */
}