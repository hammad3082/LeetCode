
Solution sol = new Solution();

sol.Check(new int[] { 1, 2, 1, 1 });
public class Solution
{
    public bool Check(int[] nums)
    {
        if (nums.Length <= 2)
            return true;
        int minIndex = 0, toRotateBy = 0;
        bool rotateNCheck = false;
        for (int i = 1; i < nums.Length; i++)
        {
            if(!rotateNCheck && nums[i - 1] >  nums[i])
                rotateNCheck = true;

            if(nums[minIndex] > nums[i])
                minIndex = i;
            else if (nums[minIndex] == nums[i] && (/*(i == nums.Length - 1) ||*/ nums[i - 1] > nums[i]))
                minIndex = i;
            //else if (nums[minIndex] == nums[i] && i == nums.Length -1)
            //    minIndex = i;
        }
        if(rotateNCheck)
        {
            toRotateBy = nums.Length - minIndex;

            int[] newArr = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int newIndex = (i + toRotateBy) % nums.Length;
                newArr[newIndex] = nums[i];
            }

            for (int i = 1;i < newArr.Length; i++)
            {
                if(newArr[i - 1] > newArr[i])
                    return false;
            }
        }
        return true;
    }
}