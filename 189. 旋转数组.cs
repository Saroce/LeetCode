/*
将整个数组翻转，再分别翻转前后两个部分（AC）
输入: [1,2,3,4,5,6,7] 和 k = 3
输出: [5,6,7,1,2,3,4]
->7 6 5 | 4 3 2 1 
->5 6 7 | 1 2 3 4
 */
public class Solution 
{
    public void Rotate(int[] nums, int k) 
    {
        k = k % nums.Length;
        reverse(nums, 0, nums.Length - 1);
        reverse(nums, 0, k - 1);
        reverse(nums, k, nums.Length - 1);
    }

    private void reverse(int[] nums, int start, int end)
    {
        int temp = 0;
        while (start < end)
        {
            temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}