/*
    思路：因为都时小写字母，直接用一个26位的数组统计每个字符出现个次数即可(不仅限于小写字母可以用哈希表)
*/

public class Solution {
    public char FirstUniqChar(string s) {
        int[] arr = new int[26];
        for (int i = 0; i < s.Length; i++) {
            arr[s[i] - 'a']++;
        }
        for (int i = 0; i < s.Length; i++) {
            if (arr[s[i] - 'a'] == 1) return s[i];
        }
        return ' ';
    }
}