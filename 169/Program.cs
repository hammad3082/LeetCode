int[] nums = { 1,1,1, 1,2, 2, 3, 3, 1,};

int res = MajorityElement(nums);

Console.WriteLine(res);

Console.WriteLine(res);

int MajorityElement(int[] nums)
{
    int count = 0, val = 0;

    foreach (int i in nums)
    {
        if (count == 0)
        {
            val = i;
        }

        if (i == val)
            count++;
        else
            count--;
    }
    return val;
}

int MajorityElement__(int[] nums)
{
    int counter = 0;
    int majElement = nums[0];

    foreach (int num in nums)
    {
        if (counter == 0)
        {
            majElement = num;
        }
        if (num == majElement)
        {
            counter++;
        }
        else
        {
            counter--;
        }
    }
    return majElement;
}

int MajorityElement_(int[] nums)
{
    int tem = 0, val = 0, maj = 0, len = nums.Length, count = 0; ;
    Dictionary<int,int> map = new Dictionary<int,int>();
    //int[] temp = new int[10];

    for (int i = 0; i < len; i++)
    {
        tem = (int)nums[i];
        map[tem] = 1 + map.GetValueOrDefault(tem);

        if (map[tem] > maj)
        {
            val = tem;
            maj = map[tem];
        }



        //if (map.TryGetValue(tem, out val))
        //    map[tem] = val + 1;
        //else map[tem] = 1;    
    }

    var res = map.Aggregate((x, y) => x.Value < y.Value ? y : x).Key;
    //var list = map.OrderByDescending(x => x.Value).Select(x=>x.Key).ToList();

    //list.Sort();
   // Array.Sort(temp, (x, y) => y.CompareTo(x));
    return res;
}
int MajorityElement1(int[] nums)
{
    int res = 0, len = nums.Length;

    int[] temp = new int[10];

    for (int i = 0; i < len; i++)
    {
        temp[nums[i]] +=1;
    }

    Array.Sort(temp,(x,y) => y.CompareTo(x));
    return temp[0];
}
