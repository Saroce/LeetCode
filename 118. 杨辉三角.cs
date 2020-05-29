public class Solution 
{
    public IList<IList<int>> Generate(int numRows) 
    {
       IList<IList<int>> lists = new List<IList<int>>();
       for (int i = 0; i < numRows; i++)
       {
           List<int> list = new List<int>();
           for (int j = 0; j <= i; j++)
           {
               if (j == 0 || j == i)   //全是1
               {
                   list.Add(1);
                   continue;
               }
               if (i > 1)
               {
                   int value = lists[i - 1][j] + lists[i - 1][j - 1];
                   list.Add(value);
               }
           }
           lists.Add(list);
       }
       return lists;
    }
}