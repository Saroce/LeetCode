public class Solution 
{
    public string AddBinary(string a, string b) 
    {
        int i = a.Length - 1, j = b.Length - 1;
        int add = 0;
        StringBuilder sb = new StringBuilder();
        while (i >= 0 || j >= 0)
        {
            int anum = i < 0 ? 0 : a[i] - '0';
            int bnum = j < 0 ? 0 : b[j] - '0';
            sb.Append((anum + bnum + add) % 2);
            add = (anum + bnum + add) / 2;
            i--;
            j--;
        }
        if (add != 0)
            sb.Append(1);
        char[] charArr = sb.ToString().ToCharArray();
        Array.Reverse(charArr);
        return new string(charArr);
    }
}