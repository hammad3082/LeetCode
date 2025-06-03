
TreeNode root = new TreeNode(4,
    new TreeNode(2,
        new TreeNode(1),
        new TreeNode(3)
    ),
    new TreeNode(7)
);

Solution solution = new Solution();

TreeNode res = solution.SearchBST(root, 2);

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
    public TreeNode SearchBST(TreeNode root, int val)
    {
        while (root != null)
        {
            if (root.val == val)
            {
                return root;
            }
            else if (root.val < val)
            {
                root = root.left;
            }
            else
            {
                root = root.right;
            }
        }
        return null;
    }
}