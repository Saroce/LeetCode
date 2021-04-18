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
    思路：利用前序遍历的root节点找到其在中序遍历的位置，划分其左子树与右子树
    递归回溯创建树
*/
public class Solution {
    private Dictionary<int, int> map = new Dictionary<int, int>();
    private int[] preorder;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        this.preorder = preorder;
        // 创建字典便于查找当前区间段的root节点在中序遍历的位置
        for (int i = 0; i < inorder.Length; i++) {
            // 注意这里只适用与树节点数值不会重复
            map.Add(inorder[i], i);
        }
        return DFS(0, 0, inorder.Length - 1);
    }

    /// <summary>
    /// 递归创建树
    /// </summary>
    /// <param name="root">当前区间段的root节点</param>
    /// <param name="left">区间段的左边界(中序遍历)</param>
    /// <param name="right">区间段的右边界(中序遍历)</param>
    /// <returns></returns>
    private TreeNode DFS(int root, int left, int right) {
        // 确保区间不越界
        if (left > right) return null;
        int val = preorder[root];
        TreeNode node = new TreeNode(val);
        // 取出当前前序遍历的root节点在中序遍历数组中的序号
        int idx = map[val];
        node.left = DFS(root + 1, left, idx - 1);
        node.right = DFS(root + idx - left + 1, idx + 1, right);
        return node;
    }
}