/*
    思路：递增序列，双指针
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int i = 0, j = nums.Length - 1;
        while (i < j) {
            int sum = nums[i] + nums[j];
            if (sum == target) return new int[] {nums[i], nums[j]};
            else if (sum < target) i++;
            else j--;
        }
        return new int[0];
    }
}