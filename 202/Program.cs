Solution sol = new Solution();
sol.IsHappy(19);
public class Solutions // nm bt grt
{
    public bool IsHappy(int n)
    {
        int slow = n, fast = SumOfSquares(n);

        while (fast != 1 && slow != fast)
        {
            slow = SumOfSquares(slow);
            fast = SumOfSquares(SumOfSquares(fast));
        }

        return fast == 1;
    }

    private int SumOfSquares(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            int digit = num % 10;
            sum += digit * digit;
            num /= 10;
        }
        return sum;
    }
}
public class Solution
{
    public bool IsHappy(int n)
    {
        HashSet<int> visited = new HashSet<int>();

        int sqSum = 0;

        while (true)
        {
            sqSum = 0;
            while (n > 0)
            {
                int digit = n % 10;

                sqSum += digit * digit;

                n /= 10;
            }
            if(visited.Contains(sqSum))
                return false;
            else if(sqSum == 1) 
                return true;
            n = sqSum;
            visited.Add(n);
        }

        return false;
    }
}