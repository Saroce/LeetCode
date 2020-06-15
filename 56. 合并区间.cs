public class Solution 
{
    public int[][] Merge(int[][] intervals) 
    {
        if (intervals.Length == 0) return new int[0][];
        Array.Sort(intervals, (a, b)=> { 
            return a[0] - b[0];
        });
        List<int[]> list = new List<int[]>();
        list.Add(intervals[0]);
        for (int i = 1; i < intervals.Length; i++)
        {
            int[] topItem = list[list.Count - 1];
            if (intervals[i][0] <= topItem[1])
                topItem[1] = intervals[i][1] > topItem[1] ? intervals[i][1] : topItem[1];
                
            else
                list.Add(intervals[i]);
        }
        return list.ToArray();
    }
}