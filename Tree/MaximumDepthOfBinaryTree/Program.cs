// LeetCode : https://leetcode.com/problems/maximum-depth-of-binary-tree/description/


TreeNode root = new TreeNode();
root.val = 3;
root.left = new TreeNode() { val = 9, left = null, right = null }; ;
root.right = new TreeNode() { val = 20, left = new TreeNode() { val = 15 }, right = new TreeNode() { val = 7 } };

Console.WriteLine(MaxDepth(root));
Console.ReadLine();

// این الگ.ریتم به روش DFS (جستجو در عمق حل شده است)
int MaxDepth(TreeNode root)
{
    if (root == null) return 0;
    return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
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
