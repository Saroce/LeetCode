/*
    思路：模拟题意按照4个方向移动指针，不断缩小区域
*/


public class Solution {
    public int[] SpiralOrder(int[][] matrix) {
        if (matrix.Length == 0 || matrix[0].Length == 0) return new int[0];
        
        int left = 0, right = matrix[0].Length - 1, top = 0, bottom = matrix.Length - 1;
        int index = 0;
        List<int> list = new List<int>();

        while (true) {
           for (int i = left; i <= right; i++) {
               list.Add(matrix[top][i]);
           }
           if (++top > bottom) break;

           for (int i = top; i <= bottom; i++) {
               list.Add(matrix[i][right]);
           }
           if (--right < left) break;

           for (int i = right; i >= left; i--) {
               list.Add(matrix[bottom][i]);
           }
           if (--bottom < top) break;

           for (int i = bottom; i >= top; i--) {
               list.Add(matrix[i][left]);
           }
           if (++left > right) break;
        }
        return list.ToArray();
    }
}