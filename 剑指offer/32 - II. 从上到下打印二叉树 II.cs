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
    思路：主要是解决每一层的问题
*/

public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        if (root == null) return new List<IList<int>>(); 
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        IList<IList<int>> res = new List<IList<int>>();
        queue.Enqueue(root);
        
        while (queue.Count > 0) {
            List<int> tmp = new List<int>();
            int len = queue.Count;
            for (int i = 0; i < len; i++) {
                TreeNode node = queue.Dequeue();
                tmp.Add(node.val);
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            res.Add(tmp);
        }
        return res;
    }
}