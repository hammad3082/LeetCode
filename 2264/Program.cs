public class Solution
{
    public string LargestGoodInteger(string num)// TL
    {
        string Result = "";

        string[] arr = ["999", "888", "777", "666", "555", "444", "333", "222", "111", "000"];

        for (int i = 0; i < arr.Length; i++)
        {
            if (num.Contains(arr[i]))
            {
                Result = arr[i];
                break;
            }
        }

        return Result;
    }
    public string LargestGoodInteger_x(string num)
    {
        int target = -1;

        for (int i = 0; i < num.Length - 2; i++)
        {
            if (num[i] == num[i + 1] && num[i] == num[i + 2])
            {
                int current = Convert.ToInt32(num.Substring(i, 3));

                target = Math.Max(target, current);
            }
        }

        if (target != -1)
        {
            if (target == 0)
            {
                return target + "00";
            }

            return target.ToString();
        }

        return "";
    }
}