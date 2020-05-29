public class Solution 
{
    public IList<string> FizzBuzz(int n) 
    {
        IList<string> list = new List<string>();
        string s = "";
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                s = "FizzBuzz";
            else if (i % 3 == 0)
                s = "Fizz";
            else if (i % 5 == 0)
                s = "Buzz";
            else
                s = i.ToString();
            list.Add(s);
        }
        return list;
    }
}