
TreeNode root = new TreeNode(1,
    new TreeNode(2,
        new TreeNode(4),
        new TreeNode(5)
    ),
    new TreeNode(3)
);

Solution solution = new Solution();

solution.MaxDepth(root);

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
    public int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;
        int leftDepth = MaxDepth(root.left);
        int rightDepth = MaxDepth(root.right);
        return 1 + Math.Max(leftDepth, rightDepth);
    }
    public int MaxDepth_11111(TreeNode root)
    {
        TreeNode treeNode = root, prevNode = null;
        int depth = 0;
        if (treeNode != null) 
        { 
            depth++;
        }

        while (treeNode.left != null && treeNode.right != null)
        {
            while (treeNode.left != null) 
            {
                prevNode = treeNode;
                treeNode = treeNode.left;
                depth++;
            }
            treeNode = prevNode;
            if (treeNode.right != null) 
            {
                treeNode = treeNode.right;
                depth++;
            }

        }
        return 0;
    }
}