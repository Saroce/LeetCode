/* 
    思路：维护一个递减的队列，每次入队列时，将队列中所有比它小的元素出队列。窗口滑动时，移除
    的元素若等于队列的队首元素，则将此元素出队列
*/
public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if (nums.Length == 0) return new int[0];
        
        LinkedList<int> queue = new LinkedList<int>();
        int[] newArr = new int[nums.Length - k + 1];

        for (int i = 0, j = 0; j < nums.Length; j++) {
            if (j >= k && nums[i++] == queue.First()) {
                queue.RemoveFirst();
            }
            
            while (queue.Count > 0 && queue.Last() < nums[j]) queue.RemoveLast();
            queue.AddLast(nums[j]);

            if (j >= k - 1) {
                newArr[i] = queue.First();
            }
        }

        return newArr;
    }
}