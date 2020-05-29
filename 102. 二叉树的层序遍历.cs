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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> lists = new List<IList<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        if (root == null)
            return lists;
        queue.Enqueue(root);
        while (queue.Count != 0)
        {
            List<int> list = new List<int>();
            int size = queue.Count;
            while (size-- > 0)
            {
                TreeNode front = queue.Dequeue();
                list.Add(front.val);
                if (front.left != null)
                    queue.Enqueue(front.left);
                if (front.right != null)
                    queue.Enqueue(front.right);
            }
            lists.Add(list);
        }
        return lists;
    }
}