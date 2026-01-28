Solution sol = new Solution();

sol.Decrypt(new int[] { 5, 7, 1, 4 }, 3);
public class Solution
{
    public int[] Decrypt(int[] code, int k)// AI clean up
    {
        int n = code.Length;
        int[] res = new int[n];

        if (k == 0) return res;

        for (int i = 0; i < n; i++)
        {
            int subSum = 0;
            int absK = Math.Abs(k);

            for (int j = 1; j <= absK; j++)
            {
                int index;

                if (k > 0)
                {
                    index = (i + j) % n;
                }
                else
                {
                    index = (i - j) % n;
                    if (index < 0) index += n;
                }
                subSum += code[index];
            }
            res[i] = subSum;
        }

        return res;
    }
    public int[] Decrypt_1(int[] code, int k)
    {
        int[] res = new int[code.Length];

        if (k != 0)
        {
            int windowSize = Math.Abs(k);

            bool isKPositive = k > 0;

            for (int i = 0; i < code.Length; i++)
            {
                int subSum = 0;
                int windowCount = windowSize;

                while (windowCount > 0)
                {
                    int index = 0;

                    if (isKPositive)
                    {
                        index = (i + windowCount) % code.Length;
                    }
                    else
                    {
                        index = (i - windowCount) % code.Length;

                        if (index < 0)
                            index += code.Length;
                    }

                    subSum += code[index];

                    windowCount--;
                }

                res[i] = subSum;
            }
        }

        return res;
    }
}