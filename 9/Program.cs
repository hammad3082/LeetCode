
Solution sol = new Solution();

bool ss = sol.IsPalindrome(999001);

int sss= 1 + 2;
public class Solution
{
    public bool IsPalindrome1(int x)
    {
        if (x < 0)
            return false;

        string num = x.ToString();

        int half = num.Length / 2;

        for (int i = 0; i < half; i++)
        {
            if(num[i] != num[num.Length - 1 - i])
                return false;
        }

        return true;
    }

    public bool IsPalindrome(int x)//not mine
    {
        if (x < 0 || (x % 10 == 0 && x != 0)) return false;

        int reversed = 0;
        while (x > reversed)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }

        return x == reversed || x == reversed / 10;
    }
}

