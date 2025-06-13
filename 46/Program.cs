
Solution sol = new Solution();

sol.Permute(new int[] { 1});

public class Solution2
{
    IList<IList<int>> res = new List<IList<int>>();

    public IList<IList<int>> Permute(int[] nums)
    {
        Backtrack(nums, 0);
        return res;
    }

    private void Backtrack(int[] nums, int start)
    {
        if (start == nums.Length)
        {
            res.Add(new List<int>(nums));
            return;
        }

        for (int i = start; i < nums.Length; i++)
        {
            Swap(nums, start, i);
            Backtrack(nums, start + 1);
            Swap(nums, start, i);
        }
    }

    private void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}

public class Solution
{
    IList<IList<int>> res;
    public IList<IList<int>> Permute(int[] nums)
    {
        res = new List<IList<int>>();

        if (nums.Length >= 2)
            BackTracking(nums, 0);
        else
            res.Add(new List<int>(nums));

        return res;
    }

    public void BackTracking(int[] arr, int istart)
    {
        if (istart == arr.Length)
        {
            res.Add(new List<int>(arr));
            return;
        }
        int temp = 0;

        for (int i = istart; i < arr.Length; i++)
        { 
                temp = arr[istart];
                arr[istart] = arr[i];
                arr[i] = temp;

                //res.Add(new List<int>(arr));
                BackTracking(arr, istart + 1);

                temp = arr[i];
                arr[i] = arr[istart];
                arr[istart] = temp;
        }
    }
}
public class Solution1
{
    IList<IList<int>> res;
    public IList<IList<int>> Permute(int[] nums)
    {
        res = new List<IList<int>>();

        if(nums.Length >= 2)
            BackTracking(nums, 0, 1);
        else
            res.Add(new List<int>(nums[0]));

        return res;
    }


    public void BackTracking(int[] arr, int istart, int jstart)
    {
        res.Add(new List<int>(arr));
        int temp = 0;

        for (int i = istart; i < arr.Length; i++)
        {
            for (int j = jstart; j < arr.Length; j++)
            {
                if (i != j)
                {
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;

                    res.Add(new List<int>(arr));
                    //BackTracking(arr, i, j);

                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            jstart = 0;
        }
    }
}