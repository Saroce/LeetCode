/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

/*
    思路：DFS，后序遍历求深度
*/

public class Solution {
    public int MaxDepth(TreeNode root) {
        if (root == null) return 0;
        int leftValue = MaxDepth(root.left);
        int rightValue = MaxDepth(root.right);
        return leftValue >= rightValue ? ++leftValue : ++rightValue;
    }
}