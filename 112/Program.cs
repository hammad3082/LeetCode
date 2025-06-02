TreeNode root = new TreeNode(-2, null, new TreeNode(-3));

Solution solution = new Solution();

solution.HasPathSum(root, -2);

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
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null)
        {
            return false;
        }
        
        if(root.left == null && root.right == null)
            return targetSum == root.val;

        if (HasPathSum(root.left, targetSum - root.val))
            return true;
        if(HasPathSum(root.right, targetSum - root.val))
            return true;
        return false;
    }
}
public class Solution
{
    int gTargetSum = 0;

    //bool TargetSumFound = false;
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        bool res = false;
        gTargetSum = targetSum;

        if (root != null)
            res = Travarsal(root, 0);

        return res;
    }

    bool Travarsal(TreeNode root, int sumTillNow)
    {
        //if (TargetSumFound)
        //    return true;

        sumTillNow += root.val;

        if (root.left == null && root.right == null)
        {
            if (sumTillNow == gTargetSum)
                //TargetSumFound = true;
                return true;
        }
        else
        {
            if (root.left != null)// && root.left.val + sumTillNow <= gTargetSum)
                if (Travarsal(root.left, sumTillNow))
                    return true;

            if (root.right != null)// && root.right.val + sumTillNow <= gTargetSum)
                if (Travarsal(root.right, sumTillNow))
                    return true;
        }

        return false;
    }
}