public class Solution
{
    public int BeautySum(string s)
    {
        int res = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int[] alphabets = new int[26];

            for (int j = i; j < s.Length; j++)
            {
                alphabets[s[j] - 'a']++;

                int max = 0, min = s.Length;

                foreach (int c in alphabets)
                {
                    if (c > 0)
                    {
                        max = Math.Max(max, c);
                        min = Math.Min(min, c);
                    }
                }

                res += max - min;
            }
        }

        return res;
    }
}


//public int BeautySum(string s)
//{
//    //int[] alphabets = new int[26];
//    Dictionary<char, int> map = new Dictionary<char, int>();

//    foreach (char c in s)
//    {
//        map[c] = map.TryGetValue(c, out int val) ? val + 1 : 1;
//    }

//    var orederedMap = map.OrderBy(x => x.Value);

//    int maxF = orederedMap.First().Key;
//    int minF = orederedMap.Last().Value;

//    return maxF - minF;
//}