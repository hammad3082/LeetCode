TreeNode root = new TreeNode(3,
                            new TreeNode(9),
                            new TreeNode(20, 
                                new TreeNode(15), new TreeNode(7)
                            )
);

Solution solution = new Solution();

solution.IsBalanced(root);

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

public class Solution
{
    bool result = true;
    public bool IsBalanced(TreeNode root)
    {
        MaxDepth(root);

        return result;
    }
    public int MaxDepth(TreeNode root)
    {   
        if(!result)
            return 0;
        if (root == null) return 0;
        int leftDepth = MaxDepth(root.left);
        int rightDepth = MaxDepth(root.right);

        if (Math.Abs(leftDepth -  rightDepth) >1)
            result = false;

        return 1 + Math.Max(leftDepth, rightDepth);
    }
}