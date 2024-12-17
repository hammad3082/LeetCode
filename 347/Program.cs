int[] nums = { 1, 1, 1, 2, 2, 3, 3,3, 4,5,6,6,6,6,6 };

var res = TopKFrequent22(nums, 2);


const int k_MaxValue = 10000;
int[] TopKFrequent(int[] nums, int k)
{
    var counter = new int[2 * k_MaxValue + 1];
    var listsOfValuesPerCount = new List<int>[nums.Length];
    var results = new int[k];

    foreach (var n in nums) //O(n)
    {
        counter[n + k_MaxValue]++;
    }

    for (var i = 0; i < counter.Length; i++)
    {
        var value = i - k_MaxValue;
        var frequencyOfValue = counter[i];

        if (frequencyOfValue == 0) continue;

        listsOfValuesPerCount[frequencyOfValue - 1] ??= [];
        listsOfValuesPerCount[frequencyOfValue - 1].Add(value);
    }

    for (var i = listsOfValuesPerCount.Length - 1; i >= 0; i--) //O(n-1)
    {
        if (listsOfValuesPerCount[i] != null)
        {
            foreach (var v in listsOfValuesPerCount[i])
            {
                k--;
                results[k] = v;
            }
        }

        if (k == 0) break;
    }

    return results;
}
int[] TopKFrequent22(int[] nums, int k)
{
    int[] result = new int[k];
    var list = new List<int>[nums.Length];

    var arr = new int[2*10000 + 1];

    foreach (int i in nums)
    {
        arr[i]++;
    }

    for (int t =0; t<  arr.Length; t++)
    {
        int count = arr[t];
        if (count == 0)
            continue;

        if (list[count - 1] == null)
        {
            list[count - 1] = new List<int>();
        }

        list[count - 1].Add(t);
    }

    for (int i = list.Length - 1; i > -1; i--)
    {
        if (list[i] != null)
        {
            foreach (int j in list[i])
            {
                k--;
                if (k < 0)
                    break;
                result[k] = j;
            }
        }
        if (k < 0)
            break;
    }
    return result;
}

    //Array.Sort(ddd, (x, y) =>
    //{
    //    int result = x < y ? 1 : -1;
    //    return result;
    //});

    //int[] dd = counts.OrderByDescending(x => x).ToArray();
    Console.WriteLine(res);
int[] TopKFrequent2(int[] nums, int k)
{int[] result = new int[k];
    Dictionary<int,int > map = new Dictionary<int,int>();

    foreach (int i in nums)
    {
        if (map.ContainsKey(i)) map[i]++;
        else map[i] = 1;
    }

    int[] counts = map.Values.ToArray();

    Array.Sort(counts, (x,y) => y.CompareTo(x));

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = map.AsEnumerable().Where(x => x.Value == counts[i]).Select(y=>y.Key).FirstOrDefault();
        map[result[i]] = -1;
    }

    return result;
    
}