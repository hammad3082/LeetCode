
Solution sol = new Solution();

sol.BuildArray(new int[] { 1, 3 }, 3);
public class Solution
{
    public IList<string> BuildArray(int[] target, int n)
    {
        IList<string> res = new List<string>();

        int targetIndex = 0;

        
        for (int i = 1; /*i <= n */ targetIndex < target.Length; i++)
        {
            //if (targetIndex >= target.Length)
            //    break;

            if (i == target[targetIndex])
            {
                targetIndex++;
                res.Add("Push");
            }
            else
            {
                res.Add("Push");
                res.Add("Pop");
            }
        }

        return res;
    }
}