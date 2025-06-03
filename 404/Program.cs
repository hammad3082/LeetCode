
TreeNode root = new TreeNode(2,
new TreeNode(9
    ),
    new TreeNode(20,
        new TreeNode(15),
        new TreeNode(7))
);

Solution solution = new Solution();

int res = solution.SumOfLeftLeaves(root);
int a = 1 + 2;
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
    int sum = 0;
    public int SumOfLeftLeaves(TreeNode root)
    {
        if (root != null)
            Traversal(root, false);

        return sum;
    }
    void Traversal(TreeNode node, bool isLeft)
    {
        if (isLeft && node.left == null && node.right == null)
            sum += node.val;

        if (node.left != null)
            Traversal(node.left, true);
        if (node.right != null)
            Traversal(node.right, false);
    }
}