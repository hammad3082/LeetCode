TreeNode root = new TreeNode(3,
                           new TreeNode(9),
                           new TreeNode(20,
                               new TreeNode(15), new TreeNode(7)
                           )
);

Solution solution = new Solution();

solution.LevelOrder(root);

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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> res = new List<IList<int>>();

        if (root == null)
            return res;

        Queue<TreeNode> queue = new Queue<TreeNode>();

        queue.Enqueue(root);
        
        while (queue.Count > 0) 
        { 
            int levelLength = queue.Count;
            List<int> current_level = new List<int>();
            while (levelLength > 0)
            {
                TreeNode node = queue.Dequeue();
                levelLength--;

                current_level.Add(node.val);

                if (node.left is not null)
                    queue.Enqueue(node.left);

                if (node.right is not null)
                    queue.Enqueue(node.right);
            }
            res.Add(current_level);
        }

        return res;
    }
}