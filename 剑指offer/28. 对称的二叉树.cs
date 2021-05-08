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
    思路：递归，自顶向下，判断左右子树
*/

public class Solution {
    public bool IsSymmetric(TreeNode root) {
        if (root == null) return true;
        return Compare(root.left, root.right);
    }

    private bool Compare(TreeNode lTree, TreeNode rTree) {
        if (lTree == null && rTree == null) return true;
        if (lTree == null || rTree == null) return false;
        if (lTree.val != rTree.val) return false;
        return Compare(lTree.left, rTree.right) && Compare(lTree.right, rTree.left);
    }
}