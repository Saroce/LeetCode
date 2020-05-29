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
    //递归实现 能否使用迭代实现？
    public int MaxDepth(TreeNode root) 
    {
        if (root == null)
        {
            return 0;
        }
        int lDepth = MaxDepth(node.left);
        int rDepth = MaxDepth(node.right);
        return lDepth > rDepth ? lDepth + 1: rDepth + 1;
    }
}