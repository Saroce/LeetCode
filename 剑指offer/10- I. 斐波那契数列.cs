/*
    思路: 不要用递归求解，从第3项开始，每1项跟前2项有关系，可以用2个变量存储数据变化
*/

public class Solution {
    public int Fib(int n) {
        int a = 0, b = 1;
        int sum = 0;
        
        for (int i = 0; i < n; i++) {
            sum = (a + b) % 1000000007;
            a = b;
            b = sum;
        }
        
        return a;
    }
}