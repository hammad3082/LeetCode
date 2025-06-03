TreeNode root = new TreeNode(2,
    new TreeNode(9
    ),
    new TreeNode(20,
        new TreeNode(15),
        new TreeNode(7))
);
TreeNode root1 = new TreeNode(2,
    null,
    new TreeNode(3,
        null,
        new TreeNode(4,
            null,
            new TreeNode(5,
                null,
                new TreeNode(6)
            )
        )
    )
);

TreeNode root3 = new TreeNode(1,
    new TreeNode(2,
        new TreeNode(4),
        new TreeNode(5)
    ),
    new TreeNode(3)
);
Solution solution = new Solution();

int res = solution.MinDepth(root3);
int a = 1+2;
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
    public int MinDepth(TreeNode root)
    {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        int depth = 0;
        // if (root != null)
        // {
        //     depth++;
        //     if(root.left != null)
        //         queue.Enqueue(root.left);
        //     if(root.right != null)
        //         queue.Enqueue(root.right);
        // }
        if (root != null)
            queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int len = queue.Count;
            depth++;

            for (int i = 0; i < len; i++)
            {
                TreeNode node = queue.Dequeue();

                if (node.left == null && node.right == null)
                    return depth;

                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
            }
        }
        return depth;
    }
    //int Traversal(TreeNode root)
    //{
    //    if (root == null)
    //        return 0;

    //    return 1 + Math.Min(Traversal(root.left), Traversal(root.right));
    //}
}