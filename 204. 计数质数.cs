public class Solution 
{
    /*2到根号num中是否有数被整除
    private bool isPrime(int num)
    {
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
    */
}

//质数筛选法
public int CountPrimes(int n) 
{
    bool[] sign=new bool[n];
    int total = 0;
    for (int i = 2; i < n; i++)
    {
        if (!sign[i])
        {
            total++;
            for (int j = i * 2; j < n; j += i)
            {
                sign[j] = true;
            }
        }
    }

    return total;
}