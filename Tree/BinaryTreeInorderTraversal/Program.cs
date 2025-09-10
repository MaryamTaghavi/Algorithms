// LeetCode : https://leetcode.com/problems/binary-tree-inorder-traversal/description/

/*

Traversal یعنی پیمایش همه‌ی گره‌های درخت به یک ترتیب مشخص.
درخت مثل یه خانواده‌نامه‌ست → باید مشخص کنیم از کجا شروع کنیم و به چه ترتیبی اعضا رو ببینیم.

Inorder Traversal (چپ → ریشه → راست)

توی Inorder، ترتیب بازدید اینجوریه:

اول میریم سمت چپ

بعد میایم روی خود ریشه (Root)

آخر میریم سمت راست

*/

/*

موضوع سوال اینه که ریشه - چپ - راست به ما میده 
و از ما چپ - ریشه - راست میخواد

*/

TreeNode root = new TreeNode();
root.val = 1;
root.left = null;
root.right = new TreeNode() { val = 2 , left = new TreeNode() { val = 3} };

var result= InorderTraversal(root);
Console.ReadLine();

IList<int> InorderTraversal(TreeNode root)
{
    List<int> result = new List<int>();
    Inorder(root, result);
    return result;
}

void Inorder(TreeNode node, List<int> result)
{
    if (node == null)
        return;

    // اول چپ
    Inorder(node.left, result);

    // بعد ریشه
    result.Add(node.val);

    // بعد راست
    Inorder(node.right, result);
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