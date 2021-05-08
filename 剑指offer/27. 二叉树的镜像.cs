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
    递归：自顶向下交换左右子树
*/

public class Solution {
    public TreeNode MirrorTree(TreeNode root) {
        if (root == null) return root;
        TreeNode left = MirrorTree(root.left);
        TreeNode right = MirrorTree(root.right);
        root.left = right;
        root.right = left;
        return root;
    }
}