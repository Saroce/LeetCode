public class Solution 
{
    //循环
    public bool IsPowerOfThree(int n) 
    {
        if (n < 1)
            return false;
        while (n % 3 == 0)
            n /= 3;
        return n == 1;
    }
    /*递归
    public bool IsPowerOfThree(int n) 
    {
        if (n < 1)
            return false;
        if (n == 1)
            return true;
        if (n % 3 != 0)
            return false;
        else
            return IsPowerOfThree(n / 3);
    }
    */
}