// LeetCode : https://leetcode.com/problems/balanced-binary-tree/description/

// منظور این الگوریتم است اختلاف عمق چپ و راست نباید بیشتر از 1 باشد
// ∣height(left)−height(right)∣≤1

TreeNode root = new TreeNode();

#region Create Nodes

// result => false ;

//root.val = 1;
//root.left = new TreeNode()
//{
//    val = 2,
//    left = new TreeNode() { val = 2, left = new TreeNode() { val = 3, right = null, left = new TreeNode() { val = 4, right = null, left = null } }, right = null },
//    right = null
//};

//root.right = new TreeNode()
//{
//    val = 2,
//    left = null,
//    right = new TreeNode() { val = 3, left = null, right = new TreeNode() { val = 3, left = null, right = new TreeNode() { val = 4, left = null, right = null } } }
//}; 

// result => true ;

//root.val = 3;
//root.left = new TreeNode()
//{
//    val = 9,
//    left = null,
//    right = null
//};

//root.right = new TreeNode()
//{
//    val = 20,
//    left = new TreeNode()
//    {
//        val = 15,
//        left = null,
//        right = null
//    },
//    right = new TreeNode() { val = 7, left = null, right = null }
//};

// result => false

root.val = 1;
root.left = null;

root.right = new TreeNode()
{
    val = 2,
    left = null,
    right = new TreeNode() { val = 3, left = null, right = new TreeNode() { val = 5, right = null, left = null } }
};

#endregion

var result = IsBalanced(root);
Console.WriteLine(result);
Console.ReadLine();

bool IsBalanced(TreeNode root)
{
    if (root == null) return true;

    if (Math.Abs(MaxDepth(root.left) - MaxDepth(root.right)) > 1)
    {
        return false;
    }

    return IsBalanced(root.left) && IsBalanced(root.right);
}

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
