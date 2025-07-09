
decimal s = (decimal)(2 * 1.000000);

decimal dd = decimal.Round(s, 5);

int d = 1 + 2;

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
    IList<double> result;
    public IList<double> AverageOfLevels(TreeNode root)
    {
        result = new List<double>();

        Queue<TreeNode> queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int CurrentLevelLength = queue.Count;

            double CurrentSum = 0;

            for (int i = 0; i < CurrentLevelLength; i++)
            {
                TreeNode treeNode = queue.Dequeue();

                CurrentSum += treeNode.val;

                if(treeNode.left is not null)
                    queue.Enqueue(treeNode.left);

                if (treeNode.right is not null)
                    queue.Enqueue(treeNode.right);
            }

            result.Add(double.Round(CurrentSum/CurrentLevelLength, 5));
        }

        return result;
    }
}