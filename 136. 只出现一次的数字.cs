public class Solution 
{
    public int SingleNumber(int[] nums) 
    {
        //解法3思路：异或运算的运用 0⊕0=0，1⊕0=1，0⊕1=1，1⊕1=0（同为0，异为1）
        //交换律：a ^ b ^ c <=> a ^ c ^ b
        //任何数于0异或为任何数 0 ^ n => n
        //相同的数异或为0: n ^ n => 0
        //2 ^ 3 ^ 2 ^ 4 ^ 4等价于 2 ^ 2 ^ 4 ^ 4 ^ 3 => 0 ^ 0 ^3 => 3
        int num = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            num ^= nums[i];
        }

        return num;
    }


    /*public int SingleNumber(int[] nums) 
    {
        //解法2思路：先排序，目标数字只出现一次，其他所有数字出现两次, 则目标数字下标为偶数，总下标长度
        //偶数，用所有下标为偶数的数字减去所有下标为奇数的数的和，即为所需要的目标数字
        int num = 0;
        Array.Sort(nums);       //先排序

        for (int i = 0; i < nums.Length; i++)
        {
            num = i % 2 == 0 ? num + nums[i] : num - nums[i];
        }

        return num;
    }*/

    
    /*public int SingleNumber(int[] nums) 
    {
        //解法1思路：先排序，首先这个数组的长度肯定是奇数（目标数字只出现一次，其他所有数字出现两次），
        //所以如果上述步骤没有找到不相等的一组数，那么肯定是数组的最后一个数字是单独出现的
        Array.Sort(nums);       //先排序
        
        for (int i = 0; i < nums.Length - 1; i += 2)
        {
            if (nums[i] != nums[i + 1])
            {
                return nums[i];
            }
        }

        return nums[nums.Length - 1];
    } */
}