using System.Xml.Linq;

TreeNode root7 = new TreeNode(7);
TreeNode root2 = new TreeNode(2,
        new TreeNode(1),
        new TreeNode(3));
TreeNode root22 = new TreeNode(4,
    root2,
    root7
);

TreeNode node4 = new TreeNode(4);
TreeNode node5 = new TreeNode(5,
    new TreeNode(6),
    new TreeNode(2,
        new TreeNode(7),
        node4
    )
);

TreeNode root = new TreeNode(3,
    node5,
    new TreeNode(1,
        new TreeNode(0),
        new TreeNode(8)
    )
);
Solution solution = new Solution();

TreeNode res = solution.LowestCommonAncestor(root, node5, node4);

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

public class Solution1
{
    TreeNode pNode;
    TreeNode qNode;

    TreeNode rNode;

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        pNode = p;
        qNode = q;

        if (root != pNode && root != qNode)
            trversal(root);
        else
            rNode = root;
        return rNode;
    }

    public int trversal(TreeNode root)
    {
        int lcount = 0;
        if (rNode == null)
        {
            if (root == pNode || root == qNode)
                lcount++;

            if (root.left != null)
                lcount += trversal(root.left);

            //if (lcount == 2 && rNode == null)
            //{
            //    rNode = root;
            //    return 2;
            //}

            if (root.right != null && rNode == null)
                lcount += trversal(root.right);

            if (lcount == 2 && rNode == null)
            {
                rNode = root;
                return 2;
            }
        }
        return lcount;
    }
}

public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == p || root == q)
        {
            return root;
        }

        TreeNode lNode = LowestCommonAncestor(root.left, p, q);
        TreeNode rNode = LowestCommonAncestor(root.right, p, q);

        if(lNode != null && rNode != null)
            return root;

        if(lNode != null)
            return lNode;

        return rNode;
    }
}