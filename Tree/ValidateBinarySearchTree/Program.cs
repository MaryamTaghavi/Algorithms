// LeetCode : https://leetcode.com/problems/validate-binary-search-tree/description/


TreeNode root = new TreeNode();

#region Create Nodes

// result => true ;

root.val = 2;
root.left = new TreeNode()
{
    val = 1,
    left = null,
    right = null
};

root.right = new TreeNode()
{
    val = 3,
    left = null,
    right = null
};

// result => false ;

//root.val = 5;
//root.left = new TreeNode() { val = 1, left = null, right = null };
//root.right = new TreeNode()
//{
//    val = 4,
//    left = new TreeNode() { val = 3, left = null, right = null },
//    right = new TreeNode() { val = 6, left = null, right = null }
//};

// result => false

//root.val = 2;
//root.left = new TreeNode()
//{
//    val = 2,
//    left = null,
//    right = null
//};

//root.right = new TreeNode()
//{
//    val = 2,
//    left = null,
//    right = null
//};

// result => false

//root.val = 5;
//root.left = new TreeNode() { val = 4 , left = null , right = null };
//root.right = new TreeNode() { val = 6, left = new TreeNode() { val = 3, left = null, right = null },
//    right = new TreeNode() { val = 7, left = null, right = null } };

#endregion

var result = IsValidBST(root);
Console.WriteLine(result);
Console.ReadLine();

bool IsValidBST(TreeNode root)
{
    return ValidNodes(root, long.MinValue, long.MaxValue);
}

bool ValidNodes(TreeNode node, long min, long max)
{
    if (node == null) return true;

    if (node.val <= min || node.val >= max)
        return false;

    return ValidNodes(node.left, min, node.val) &&
           ValidNodes(node.right, node.val, max);
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