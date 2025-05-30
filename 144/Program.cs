TreeNode root = new TreeNode(3,
                            new TreeNode(9),
                            new TreeNode(20,
                                new TreeNode(15), new TreeNode(7)
                            )
);

Solution solution = new Solution();

solution.PreorderTraversal(root);

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
    IList<int> nodes = new List<int>();

    #region PreorderTraversal
    public IList<int> PreorderTraversal(TreeNode root)
    {
        if (root == null)
            return nodes;

        recPreorderTraversal(root);

        return nodes;
    }

    public void recPreorderTraversal(TreeNode root)
    {
        if (root == null)
            return;

        nodes.Add(root.val);

        recPreorderTraversal(root.left);
        recPreorderTraversal(root.right);
    }
    #endregion

    #region InorderTraversal
    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root == null)
            return nodes;

        Traversal(root);

        return nodes;
    }

    public void Traversal(TreeNode root)
    {
        if (root == null)
            return;

        Traversal(root.left);
        nodes.Add(root.val);
        Traversal(root.right);
    }
    #endregion

    #region PostorderTraversal
    public IList<int> PostorderTraversal(TreeNode root)
    {
        if (root == null)
            return nodes;

        recPostorderTraversal(root);
        return nodes;
    }

    public void recPostorderTraversal(TreeNode root)
    {
        if (root == null)
            return;

        recPostorderTraversal(root.left);
        recPostorderTraversal(root.right);
        nodes.Add(root.val);
    }
    #endregion
}
