/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution 
{
    public bool IsSymmetric(TreeNode root) 
    {
        if (root == null) return true;
        return compare(root.left, root.right);
    }

    private bool compare(TreeNode p1, TreeNode p2)
    {
        if (p1 == null && p2 == null) return true;
        if (p1 == null || p2 == null) return false;
        return compare(p1.left, p2.right) && compare(p1.right, p2.left);
    }
}