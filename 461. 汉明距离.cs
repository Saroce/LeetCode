public class Solution 
{
    public int HammingDistance(int x, int y) 
    {
        int count = 0;
        for (int i = 0; i < 32; i++)
        {
            int n1 = x & 1;
            int n2 = y & 1;
            x >>= 1;
            y >>= 1;
            if (n1 != n2) count++;
        }
        return count;
    }
}