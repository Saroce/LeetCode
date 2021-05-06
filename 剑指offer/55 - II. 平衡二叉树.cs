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
    思路1；利用求树的高度的方法，自顶向下求解。会产生大量重复计算
    思路2：后序遍历+剪枝
        1. 叶子节点返回深度0
        2. 判断左右子树深度高度差是否超过？
            超过: 返回-1
            没超过：返回子树最大深度值+1
        3. 检测过程中发现-1，直接返回最终结果。(-1非平衡二叉树，其他值为平衡二叉树高度)
*/

public class Solution {
    public bool IsBalanced(TreeNode root) {
        return DFS(root) != -1;
    }

    private int DFS(TreeNode node) {
        if (node == null) return 0;
        int leftValue = DFS(node.left);
        if (leftValue == -1) return -1;
        int rightValue = DFS(node.right);
        if (rightValue == -1) return -1;
        return Math.Abs(leftValue - rightValue) > 1 ? -1 : Math.Max(leftValue, rightValue) + 1;
    }
}