public class Solution 
{
    public int DominantIndex(int[] nums) 
    {
        int maxIdx = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[maxIdx])
                maxIdx = i;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (maxIdx != i && nums[maxIdx] < 2 * nums[i]) return -1;
        }
        return maxIdx;
    }
}