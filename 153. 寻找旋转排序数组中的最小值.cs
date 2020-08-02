public class Solution {
    public int FindMin(int[] nums) 
    {
        if (nums.Length == 1) return nums[0];
        int left = 0, right = nums.Length - 1;
        while (left < right)
        {
            //当前搜索区域没有翻转，直接返回left即为最小值
            if (nums[right] > nums[left]) return nums[left];  
            int mid = left + (right - left) / 2;
            if (nums[mid] >= nums[left]) left = mid + 1;
            else if (nums[mid] < nums[left]) right = mid;
        }
        return nums[left];
    }
}