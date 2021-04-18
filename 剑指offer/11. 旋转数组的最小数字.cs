/*
    思路：看注释
*/

public class Solution {
    public int MinArray(int[] numbers) {
        int left = 0, right = numbers.Length - 1;
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (numbers[mid] < numbers[right]) right = mid;         // mid可能为最小值，所以区间划分right = mid
            else if (numbers[mid] > numbers[right]) left = mid + 1; // 这种情况下num[mid]肯定不是最小值，跳过mid，left = mid + 1
            else right--;                                           // 无法确定缩小区间，right--转化成暴力搜索
        }
        return numbers[left];
    }
}