public class Solution
{
    /*高斯求和可能会溢出
    public int MissingNumber(int[] nums) 
    {
        int count = nums.Length;
        int total = count * (count + 1) / 2;
        for (int i = 0; i < count; i++)
            total -= nums[i];
        return total;
    }*/
    //位运算
    public int MissingNumber(int[] nums) 
    {
        int result = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            result ^= i ^ nums[i]; 
        }
        return result;
    }
}