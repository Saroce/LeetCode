/*
    思路: 利用数组的特性每一行都按照从左到右递增的顺序排序，每一列都按照从上到下递增的顺序排序。
    每次比较没找到可以消除一行或者一列
*/

public class Solution {
    public bool FindNumberIn2DArray(int[][] matrix, int target) {
        if (matrix.Length == 0 || matrix[0].Length == 0) return false;
        int i = 0, j = matrix[0].Length - 1;
        while (i < matrix.Length && j >= 0) {
            if (target == matrix[i][j]) return true;
            if (target > matrix[i][j]) {
                i++;
            }
            else {
                j--;
            }
        }
        return false;
    }
}