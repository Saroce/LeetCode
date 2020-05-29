public class Solution 
{
    //利用List的IndexOf查找
    public int[] Intersect(int[] nums1, int[] nums2) 
    {
        List<int> numList = new List<int>();
        List<int> resultList = new List<int>();

        foreach(int num in nums1)
        {
            numList.Add(num);
        }
        foreach (int num in nums2)
        {
            int i = numList.IndexOf(num);
            if (i != -1)    //在第二个数组中找到了一个对应相同的数，提取次数，将记录list中次数减掉
            {
                resultList.Add(num);
                numList.RemoveAt(i);
            }
        }

        return resultList.ToArray();
    }

    /* 哈希表解法
    public int[] Intersect(int[] nums1, int[] nums2) 
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        List<int> list = new List<int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            if (!dict.ContainsKey(nums1[i]))
            {
                dict.Add(nums1[i], 1);
            }
            else
            {
                dict[nums1[i]]++;
            }
        }
        for (int i = 0; i < nums2.Length; i++)
        {
            if (dict.ContainsKey(nums2[i]))
            {
                list.Add(nums2[i]);
                if (--dict[nums2[i]] == 0)
                {
                    dict.Remove(nums2[i]);
                }
            }
        }
        return list.ToArray();
    }*/
}