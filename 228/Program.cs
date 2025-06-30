public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        IList<string> res = new List<string>();

        int len = nums.Length;
        if (len == 0)
            return res;
        int pre = nums[0];

        int[] range = new int[2];
        range[0] = nums[0];
        for (int i = 1; i < len; i++)
        {
            int current = nums[i];

            if (current != pre + 1)
            {
                if (range[0] == pre)
                    res.Add(pre.ToString());
                else
                {
                    res.Add(range[0].ToString() + "->" + pre.ToString());
                }
                range[0] = current;
            }

            pre = current;
        }

        if (range[0] == nums[len - 1])
            res.Add(pre.ToString());
        else
        {
            res.Add(range[0].ToString() + "->" + nums[len - 1].ToString());
        }

        return res;
    }
}