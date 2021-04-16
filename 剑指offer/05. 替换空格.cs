
//  思路：扫描一遍字符串，遇到空字符直接替换成指定字符串
public class Solution {
    public string ReplaceSpace(string s) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == ' ') {
                sb.Append("%20");
            } 
            else {
                sb.Append(s[i]);
            }
        }
        return sb.ToString();
    }
}