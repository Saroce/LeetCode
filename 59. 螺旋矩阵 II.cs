public class Solution 
{
    //模拟法(设定边界值)
    public int[][] GenerateMatrix(int n) 
    {
        int[][] matrix = new int[n][];
        for (int i = 0; i < n; i++)
            matrix[i] = new int[n];
        int l = 0, r = n - 1, t = 0, b = n - 1;
        int num = 1, tar = n * n;
        while (num <= tar)
        {
            
            for (int i = l; i <= r; i++)    //从左走到右
            {
                matrix[t][i] = num++;
            }
            t++;
            for (int i = t; i <= b; i++)    //从上走到下
            {
                matrix[i][r] = num++;
            }
            r--;
            for (int i = r; i >= l; i--)    //从右走到左
            {
                matrix[i][b] = num++;
            }
            b--;
            for (int i = b; i >= t; i--)    //从下走到上
            {
                num[i][l] = num++;
            }
            l++;
        }
        return matrix;
    }
}