public class Solution {
    public int FindRepeatNumber(int[] nums) {
        int n = nums.Length;
        for (int i = 0; i < n; i++) {
            while (nums[i] != i && nums[i] != nums[nums[i]]) {
                nums[i] = nums[i] + nums[nums[i]];
                nums[nums[i]] = nums[i] - nums[nums[i]];
                nums[i] = nums[i] - nums[nums[i]];   
            };
            if (nums[i] != i && nums[i] == nums[nums[i]]) return nums[i];
        }
        return -1;
    }
}