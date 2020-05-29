public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        int i = 0, j = numbers.Length - 1;
        while (i < j)
        {
            if (target == numbers[i] + numbers[j])
                return new int[]{i + 1, j + 1};
            if (target < numbers[i] + numbers[j])
            {
                j--;
            }
            else
            {
                i++;
            }
        }
        return new int[]{};
    }
}