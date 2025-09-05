
Solution sol = new Solution();

sol.TransformArray(new int[] { 4, 3, 2, 1 });
public class Solution
{
    public int[] TransformArray(int[] nums)
    {
        int even = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                even++;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = i < even ? 0 : 1;
        }

        return nums;
    }
    public int[] TransformArray2(int[] nums)
    {
        int odd = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 != 0)
                odd++;
        }

        int[] res = new int[nums.Length];

        int j = nums.Length - 1;
        while(odd > 0)
        {
            res[j] = 1;
            j--;odd--;
        }

        return res;
    }
    public int[] TransformArray1(int[] nums)
    {
        int l = 0, r = nums.Length - 1;
        int[] res = new int[nums.Length];
        for (int i = 0, j = nums.Length - 1; i < nums.Length; i++, j--)
        {
            if (nums[i] % 2 == 0)
            {
                l++;
            }
            if(nums[j] % 2 != 0)
            {
                res[r] = 1;
                r--;
            }
        }
        return res;
    }
}
//public class Solution
//{
//    public int[] TransformArray(int[] nums)
//    {
//        for (int i = 0; i < nums.Length; i++)
//        {
//            if (nums[i] % 2 == 0)
//            {
//                nums[i] = 0;
//            }
//            else
//            {
//                nums[i] = 1;
//            }
//        }

//        Array.Sort(nums);
//        return nums;
//    }
//}