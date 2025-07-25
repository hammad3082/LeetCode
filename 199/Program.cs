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
    public IList<int> RightSideView(TreeNode root) //got in first try !!!
    {
        IList<int> res = new List<int>();

        if (root != null)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int levelWidth = queue.Count;

                for (int i = 0; i < levelWidth; i++)
                {
                    TreeNode node = queue.Dequeue();

                    if (node.left != null) 
                        queue.Enqueue(node.left);
                    if(node.right != null)
                        queue.Enqueue(node.right);

                    if(i + 1 == levelWidth)
                        res.Add(node.val);
                }
            }
        }
        return res;
    }
}