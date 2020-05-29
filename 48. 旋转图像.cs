public class Solution 
{
    public void Rotate(int[][] matrix) 
    {
        int len = matrix.Length;

        for (int i = 0, e = len - 1; i < e; i++, e--)
        {
            for (int j = i; j < e; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[len - 1 - j][i];
                matrix[len - 1 - j][i] = matrix[len - 1 - i][len - 1 - j];
                matrix[len - 1 - i][len - 1 - j] = matrix[j][len - 1 - i];
                matrix[j][len - 1 - i] = temp;
            }
        }
    }
}