/*
    思路：TopK问题 - 1. 快速选择实现，快速排序的变形使用
                    2. 优先队列(堆)的实现
*/

public class Solution {
    public int[] GetLeastNumbers(int[] arr, int k) {
        if (k >= arr.Length) return arr;
        QuickSort(arr, k, 0, arr.Length - 1);
        int[] newArr = new int[k];
        for (int i = 0; i < k; i++) {
            newArr[i] = arr[i];
        }
        return newArr;
    }

    private void QuickSort(int[] arr, int k, int left, int right) {
        if (left >= right) return;
        int pivotIndex = Partition(arr, left, right);
        if (pivotIndex < k) QuickSort(arr, k, pivotIndex + 1, right);
        else if (pivotIndex > k) QuickSort(arr, k, left, pivotIndex - 1);
        return;
    }

    private int Partition(int[] arr, int left, int right) {
        int pivotValue = arr[left];
        int i = left, j = right;
        while (i < j) {
            while (i < j && arr[j] >= pivotValue) j--;
            arr[i] = arr[j];
            while (i < j && arr[i] <= pivotValue) i++;
            arr[j] = arr[i];
        }
        // 基准值放入合适位置
        arr[i] = pivotValue;
        // 返回序号
        return i;
    }
}