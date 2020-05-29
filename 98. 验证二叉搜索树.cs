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
    /*中序遍历取出所有升序的值存入List列表
    List<int> list = new List<int>();
    public bool IsValidBST(TreeNode root) 
    {
        inorder(root);
        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] <= list[i - 1])
            {
                return false;
            }
        }
        return true;
    }

    private void inorder(TreeNode node)   
    {
        if (node == null)
        {
            return;
        }
        inorder(node.left);
        list.Add(node.val);
        inorder(node.right);
    }
     */
    TreeNode prev = null;    //保存中序遍历的前继结点
    public bool IsValidBST(TreeNode root) 
    {
        if (root == null)
        {
            return true;
        }
        if (!IsValidBST(root.left))
        {
            return false;
        }
        if (prev != null && prev.val >= root.val)
        {
            return false;
        }
        prev = root;
        if (!IsValidBST(root.right))
        {
            return false;
        }
        return true;
    }
}