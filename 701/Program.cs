
TreeNode root = new TreeNode(4,
    new TreeNode(2,
        new TreeNode(1),
        new TreeNode(3)
    ),
    new TreeNode(7)
);
TreeNode root1 = new TreeNode(40,
    new TreeNode(20,
        new TreeNode(10),
        new TreeNode(30)
    ),
    new TreeNode(60,
        new TreeNode(50),
        new TreeNode(70)
    )
);
Solution solution = new Solution();

TreeNode res = solution.InsertIntoBST(root1, 25);

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
    TreeNode Root;
    public TreeNode InsertIntoBST(TreeNode root, int val)
    {
        Root = root;

        while (root != null)
        {
            if (val < root.val)
            {
                if (root.left  == null)
                {
                    root.left = new TreeNode(val);
                    return Root;
                }
                //else if (val > root.left.val)
                //{
                //    TreeNode temp = root.left;
                //    root.left = new TreeNode(val);
                //    root.left.left = temp;
                //}
                root = root.left;
            }
            else if (val > root.val)
            {
                if (root.right == null)
                {
                    root.right = new TreeNode(val);
                    return Root;
                }
                //else if (val > root.right.val)
                //{
                //    TreeNode temp = root.right;
                //    root.right = new TreeNode(val);
                //    root.right.right = temp;
                //}
                root = root.right;
            }
         }   
        return Root;
    }
}