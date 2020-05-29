public class Solution 
{
    public int[] PlusOne(int[] digits) 
    {
        int i = digits.Length - 1;
        while (i >= 0 && digits[i] + 1 == 10)
        {
            digits[i] = 0;
            i--;
        }
        if (i < 0)   //产生进位多了一位的特殊情况
        {
            int[] newDigits = new int[digits.Length + 1];
            newDigits[0] = 1;
            return newDigits;
        }
        digits[i] += 1;
        return digits;
    }
}