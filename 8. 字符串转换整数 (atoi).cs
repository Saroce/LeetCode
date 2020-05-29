public class Solution 
{
    public int MyAtoi(string str) 
    {
        str = str.Trim();    //去掉两边多余的空格
        bool isMinus = false;
        long num = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (i == 0)
            {
                if (str[i] == '-')
                {
                    isMinus = true;
                    continue;
                }
                if (str[i] == '+') continue;
            }
            if (str[i] < '0' || str[i] > '9') break;
            num = num * 10 + str[i] - '0';   
            if (num > int.MaxValue) //若超出int32限制范围
            {
                return isMinus ? int.MinValue : int.MaxValue;
            }
        }
        return isMinus ? -1 * (int)num : (int)num;
    }
}