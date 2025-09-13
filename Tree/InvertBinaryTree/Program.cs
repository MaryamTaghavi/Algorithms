// LeetCode : https://leetcode.com/problems/invert-binary-tree/description/


TreeNode root = new TreeNode();

#region Create Nodes

root.val = 2;
root.left = new TreeNode()
{
    val = 3,
    left = null,
    right = null
};

root.right = new TreeNode()
{
    val = 2,
    left = null,
    right = null
};

#endregion

var result = InvertTree(root);
Console.WriteLine(result);
Console.ReadLine();
TreeNode InvertTree(TreeNode root)
{
    result = ChangeNodes(root);
    return result;
}

TreeNode? ChangeNodes(TreeNode root)
{
    if (root == null) return null;

    var temp = root.left;
    root.left = root.right;
    root.right = temp;

    ChangeNodes(root.left);
    ChangeNodes(root.right);
    return root;
}

// Definition for a binary tree node.
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}