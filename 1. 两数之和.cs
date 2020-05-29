public class Solution
 {
    public int[] TwoSum(int[] nums, int target)
    {
        //解题思路2：(哈希映射)一遍将没配对上的存进哈希表，若target - nums[i]在哈希表已存在，则找到，直接返回
        //字典存储也能达到类似的功能，但是速度没哈希表快
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(target - nums[i]))
            {
                return new int[]{dict[target - nums[i]], i};
            }
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
        }
        return new int[]{};
    }


     /*解题思路1：暴力匹配解法
    public int[] TwoSum(int[] nums, int target) 
    {
       for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[]{i, j};
                }
            }
        }   
        
        return new int[]{ };
    } */
}