Solution sol = new Solution();

bool res1 = sol.CanThreePartsEqualSum(new int[] { 1, -1, 1, -1 });
public class Solution
{
    public bool CanThreePartsEqualSum_(int[] nums) // failed for { 1, -1, 1, -1 }
    {
        int TotalSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            TotalSum += nums[i];
        }

        if (TotalSum % 3 != 0)
            return false;

        int OnePartSum = TotalSum / 3;

        int CurrentPartSum = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            CurrentPartSum += nums[i];

            if (CurrentPartSum == OnePartSum)
            {
                if (TotalSum * 2/3 == CurrentPartSum)
                    return true;
                OnePartSum += OnePartSum;
            }
        }
        return false;
    }
    public bool CanThreePartsEqualSum(int[] nums)
    {
        int TotalSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            TotalSum += nums[i];
        }
        if (TotalSum % 3 != 0)
        {
            return false;
        }

        int OnePartSum = TotalSum / 3;

        int CurrentPartSum = 0;

        bool OnePartDone = false;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            CurrentPartSum += nums[i];

            if(CurrentPartSum == OnePartSum)
            {
                if(OnePartDone)
                    return true;
                CurrentPartSum = 0;
                OnePartDone = true;
            }
        }
        return false;
    }
    public bool CanThreePartsEqualSum_1(int[] nums)
    {
        int Total = 0;
        int[] sumArr = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            Total += nums[i];
            sumArr[i] = Total;
        }
        if (Total % 3 != 0)
        {
            return false;
        }

        int part = Total / 3;
        int leftSum = 0, rightSum = 0, midSum = 0;

        int l = 0, r = sumArr.Length - 1;

        while(l + 1 != r)
        {
            leftSum = sumArr[l];
            rightSum = Total - sumArr[r - 1];
            midSum = Total - leftSum - rightSum;

            if(midSum == rightSum && rightSum == leftSum)
                return true;

            if (rightSum != part)
                r--;
            else
                l++;
        }
        return false;
    }


    public bool CanThreePartsEqualSum_ddd(int[] nums)//wrong
    {
        int Total = 0;
        int[] sumArr = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            Total += nums[i];
            sumArr[i] = Total;
        }
        if (Total % 3 != 0)
        {
            return false;
        }

        int part = Total / 3;
        int leftSum = 0, rightSum = 0, midSum = 0;

        int l = 0, r = sumArr.Length - 1;

        while (l != r)
        {
            leftSum = sumArr[l];
            rightSum = Total - sumArr[r - 1];
            midSum = Total - leftSum - rightSum;

            if (midSum == rightSum && rightSum == leftSum)
                return true;

            if (rightSum < leftSum)
                r--;
            else
                l++;
        }
        return false;
    }
}