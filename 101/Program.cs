TreeNode root = new TreeNode(2,
    new TreeNode(3,
        new TreeNode(4),
        new TreeNode(5)
    ),
    new TreeNode(3,
        new TreeNode(5)
    )
);

TreeNode root1 = new TreeNode(1,
    new TreeNode(2,
        new TreeNode(3,
            new TreeNode(5), new TreeNode(4)),
        new TreeNode(4,
            new TreeNode(3), new TreeNode(2))
    ),
    new TreeNode(2,
        new TreeNode(4,
            new TreeNode(2), new TreeNode(3)),
        new TreeNode(3,
            new TreeNode(4), new TreeNode(5))
    )
);
Solution solution = new Solution();

solution.IsSymmetricIteratively(root1);

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
    public bool IsSymmetricIteratively(TreeNode root)//not mine
    {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root.left);
        queue.Enqueue(root.right);
        while (queue.Count > 0)
        {
            var left = queue.Dequeue();
            var right = queue.Dequeue();

            if (left == null && right == null)
                continue;
            if (left == null || right == null)
                return false;
            if (left.val != right.val)
                return false;

            queue.Enqueue(left.right);
            queue.Enqueue(right.left);

            queue.Enqueue(left.left);
            queue.Enqueue(right.right);
        }

        return true;
    }
    public bool IsSymmetric(TreeNode root)
    {
        Queue<TreeNode> queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int levelLength = queue.Count;


            int half = levelLength / 2;
            int[] arr = new int[levelLength];

            for (int i = 0; i < levelLength; i++)
            {
                TreeNode node = queue.Dequeue();

                if (node != null)
                {
                    if (levelLength > 1 && i >= half)
                    {
                        if (arr[levelLength -1- i] != node.val)
                            return false;
                    }

                    arr[i] = node.val;

                    queue.Enqueue(node.left);
                    
                    queue.Enqueue(node.right);
                }
                else
                {
                    if (i >= half)
                    {
                        if (arr[levelLength-1 - i] != -101)
                            return false;
                    }
                    arr[i] = -101;
                }
            }

            //for (int i = 0; i < levelLength; i++)
            //{
            //    if(arr[i] != arr[levelLength - 1 - i])
            //        return false;
            //}
        }
        return true;
    }
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