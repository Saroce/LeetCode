/*
    思路：双指针，滑动窗口
*/

public class Solution {
    public int[][] FindContinuousSequence(int target) {
        int i = 1, j = 2;
        int sum = i + j;
        List<int[]> list = new List<int[]>();
        while (i < j) {
            if (sum >= target) {
                if (sum == target) {
                    int[] num = new int[j - i + 1];
                    for (int k = i; k <= j; k++) {
                        num[k - i] = k;
                    }
                    list.Add(num);
                }
                sum -= i;
                i++;
            }
            else {
                j++;
                sum += j;
            }
        }
        return list.ToArray();
    }
}