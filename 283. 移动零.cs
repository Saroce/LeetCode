public class Solution 
{
    public void MoveZeroes(int[] nums) 
    {
        int lastNonZeroFoundAt = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[lastNonZeroFoundAt++] = nums[i];
            }
        }

        for (int i = lastNonZeroFoundAt; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}