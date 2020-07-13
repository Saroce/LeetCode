public class Solution 
{
    public int MySqrt(int x) 
    {
        int left = 0, right = x, mid = -1;
        int result = 0;
        while (left <= right)
        {
            mid = left + (right - left) / 2;
            if ((long)mid * mid <= x)
            {
                result = mid;
                left = mid + 1;
            }
            else right = mid  - 1;
        }
        return result;
    }
}