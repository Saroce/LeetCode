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
    思路1：利用双列表模拟双向队列
    思路2：反转list列表元素
*/

public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        if (root == null) return new List<IList<int>>(); 
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        IList<IList<int>> res = new List<IList<int>>();
        queue.Enqueue(root);
        int level = 0;
        while (queue.Count > 0) {
            List<int> tmp = new List<int>();
            int len = queue.Count;
            for (int i = 0; i < len; i++) {
                TreeNode node = queue.Dequeue();
                tmp.Add(node.val);
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            if (level++ % 2 != 0) tmp.Reverse();
            res.Add(tmp);
        }
        return res;
    }
}