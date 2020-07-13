public class Solution 
{
    public IList<int> GetRow(int rowIndex) 
    {
        int[] arr = new int[rowIndex + 1];
        for (int i = 0; i <= rowIndex; i++)
        {
            arr[i] = 1;
            for (int j = i - 1; j >= 1; j--)
            {
                arr[j] += arr[j - 1];
            }
        }
        return new List<int>(arr);
    }
}