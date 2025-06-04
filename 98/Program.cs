using System.Xml.Linq;

TreeNode root = new TreeNode(3,
                           new TreeNode(9),
                           new TreeNode(20,
                               new TreeNode(15), new TreeNode(7)
                           )
);

TreeNode root1 = new TreeNode(1,
                           new TreeNode(1), null);

TreeNode root2 = new TreeNode(5,
    new TreeNode(4),
    new TreeNode(6,
        new TreeNode(3),
        new TreeNode(7)
    )
);

TreeNode root3 = new TreeNode(5,
    new TreeNode(1),
    new TreeNode(4,
        new TreeNode(3),
        new TreeNode(6)
    )
); TreeNode root4 = new TreeNode(45,
    new TreeNode(42,
        null,
        new TreeNode(44,
            new TreeNode(43,
                new TreeNode(41),
                null
            ),
            null
        )
    ),
    null
);
Solution solution = new Solution();

solution.IsValidBST(root4);

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
public class Solution33333
{
    bool isBST = true;
    int? maxTillNow = null;

    IList<int> nodes = new List<int>();
    public bool IsValidBST(TreeNode root)
    {
        Traversal(root);
        
        return isBST;
    }

    public int Traversal(TreeNode root) ///  failed
    {
        if (isBST)
        {
            if (root.left != null)
            {
                int l = Traversal(root.left);

                if (l >= root.val)
                    isBST = false;
            }

            if (maxTillNow is not null)
                maxTillNow = Math.Max(maxTillNow ?? 0, root.val);
            else
                maxTillNow = root.val;

            if (root.right != null)
            {
                int r = Traversal(root.right);

                if (r <= root.val)
                    isBST = false;
            }
        }
        
        return root.val;
    }
}

public class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        return IsValid(root, int.MinValue, int.MaxValue);
    }
    public bool IsValid(TreeNode root, long min, long max)
    {
        if (root == null)
            return true;

        if (root.val <= min || root.val >= max)
        {
            return false;
        }

        return IsValid(root.left, min, root.val) && IsValid(root.right, root.val, max);
    }

    bool isBST = false;

    IList<int> nodes = new List<int>();
    public bool IsValidBST1(TreeNode root)
    {

        Traversal(root);
        int[] arr = nodes.ToArray();
        if (arr.Length > 1)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] <= arr[i - 1])
                    return false;
            }
        }

        return true;
    }

    public void Traversal(TreeNode root)
    {
        if (root == null)
            return;

        Traversal(root.left);
        nodes.Add(root.val);
        Traversal(root.right);
    }
}