/*
    从尾到头反向遍历字符串，分别切割word
*/
public class Solution {
    public string ReverseWords(string s) {
        s = s.Trim();
        int j = s.Length - 1, i = j;
        StringBuilder sb = new StringBuilder();
        while (j >= 0) {
            while (i >= 0 && s[i] != ' ') i--;          // 找到第一个空格字符
            sb.Append(s.Substring(i + 1, j - i) + " "); // 切割字符串
            while (i >= 0 && s[i] == ' ') i--;          // 跳过空格
            j = i;
        }
        return sb.ToString().Trim();
    }
}