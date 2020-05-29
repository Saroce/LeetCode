public class Solution 
{
    //从后往前插入数组里面，避免空间开销
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        int p1 = m - 1, p2 = n - 1, p = m + n - 1;
        while (p1 >= 0 && p2 >= 0)
        {
            nums1[p--] = nums1[p1] > nums2[p2] ? nums1[p1--] : nums2[p2--];
        }
        Array.Copy(nums2, nums1, p2 + 1);
    }
}