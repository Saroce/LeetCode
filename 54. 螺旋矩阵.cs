public class Solution 
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        List<int> list = new List<int>();
        if ( matrix.Length == 0) return list;
        int left = 0, right = matrix[0].Length - 1, top = 0, bottom = matrix.Length - 1;
        while (true)
        {
            for (int i = left; i <= right; i++)
                list.Add(matrix[top][i]);
            if (++top > bottom) break;
            for (int i = top; i <= bottom; i++)
                list.Add(matrix[i][right]);
            if (--right < left) break;
            for (int i = right; i >= left; i--)
                list.Add(matrix[bottom][i]);
            if (--bottom < top) break;
            for (int i = bottom; i >= top; i--)
                list.Add(matrix[i][left]);
            if (++left > right) break;
        }
        return list;
    }
}