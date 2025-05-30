TreeNode root = new TreeNode(3,
                            new TreeNode(9),
                            new TreeNode(20,
                                new TreeNode(15), new TreeNode(7)
                            )
);

TreeNode root1 = new TreeNode(1,
    new TreeNode(2,
        new TreeNode(4),
        new TreeNode(5)
    ),
    new TreeNode(3)
);

Solution solution = new Solution();

solution.InvertTree(root);

solution.InvertTree(new TreeNode());

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
    public TreeNode InvertTree(TreeNode root)
    {
        if (root != null)
            recInvertTree(root);
        return root;
    }

    public void recInvertTree(TreeNode root)
    {
        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;

        if(root.left != null) 
            recInvertTree(root.left);

        if (root.right != null)
            recInvertTree(root.right);
    }
}