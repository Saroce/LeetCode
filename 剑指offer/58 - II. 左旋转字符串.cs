/*
    库函数切割
*/

public class Solution {
    public string ReverseLeftWords(string s, int n) {
        string s1 = s.Substring(0, n);
        string s2 = s.Substring(n, s.Length - n);
        return s2 + s1;
    }
}