public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        IList<string> result = new List<string>();

        for (int count = 1; count <= n; count++)
        {
            if (count % 3 == 0 && count % 5 == 0)
            {
                result.Add("FizzBuzz");
            }
            else if (count % 5 == 0)
            {
                result.Add("Buzz");
            }
            else if (count % 3 == 0)
            {
                result.Add("Fizz");
            }
            else
            {
                result.Add(count.ToString());
            }
        }

        return result;
    }
}