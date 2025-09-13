// https://leetcode.com/problems/search-in-a-binary-search-tree/description/

/*
 تعریف دقیق Binary Search Tree (BST):

برای هر نود در درخت:

همه‌ی مقادیر در subtree چپش از مقدار خود نود کوچکتر یا مساوی هستن.

همه‌ی مقادیر در subtree راستش از مقدار خود نود بزرگتر یا مساوی هستن.

❌ نکته مهم:

این قاعده فقط بین کل subtreeها برقرار هست، نه فقط گره‌ی چپ و راست مستقیم.
یعنی:

root.left.val لزوماً کوچکتر از root.right.val نیست.

ولی همه‌ی گره‌های سمت چپ درخت باید < root.val باشن، و همه‌ی گره‌های سمت راست > root.val.
*/

TreeNode root = new TreeNode();

/* 
root.val = 1;
root.left = null;
root.right = new TreeNode() { val = 2, left = new TreeNode() { val = 3 } , right = null}; 
*/
 
/*
root.val = 4;
root.left = new TreeNode() { val = 2, left = new TreeNode() { val = 1 , right = null , left = null }, 
    right = new TreeNode() { val = 3 , right = null , left = null } } ;
root.right = new TreeNode() { val = 7, left = null , right = null} ; 
*/

var result = SearchBST(root , 2);
Console.ReadLine();

TreeNode? SearchBST(TreeNode root, int val)
{
    return SearchValue(root, val);
}

TreeNode? SearchValue(TreeNode root, int val)
{
    if(root == null) return null;

    if (root.val == val) return root;

    if (val <= root.val)
    {
        return SearchValue(root.left, val);
    }

    else
    {
        return SearchValue(root.right, val);
    }
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