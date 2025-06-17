
Solution Solution = new Solution();

int res = Solution.LongestConsecutive(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 });
int res2 = Solution.LongestConsecutive(new int[] { -1000000000, 1, 2, 3, 9, 1000000000 });
int res3 = Solution.LongestConsecutive(new int[] { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 });
int a = 1 + 1;
public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        HashSet<int> hash = new HashSet<int>();

        int count = 0, maxCount = 0;

        foreach (int num in nums)
        {
            hash.Add(num);
        }

        foreach(int num in hash)
        {
            if(!hash.Contains(num - 1))
            {
                count = 1;
                int lnum = num + 1;

                while (hash.Contains(lnum))
                {
                    lnum++;
                    count++;
                }
                if (count > maxCount)
                    maxCount = count;
                count = 0;
            }
        }

        return maxCount;
    }
    public int LongestConsecutive3(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        Queue<int> QueueSmallest = new();
        HashSet<int> hash = new HashSet<int>();

        int count = 0, maxCount = 0, smallest = nums[0];

        QueueSmallest.Enqueue(smallest);
        
        foreach (int num in nums)
        {
            if (num < smallest || num - smallest > nums.Length)
            {
                smallest = num;
                QueueSmallest.Enqueue(smallest);
            }

            hash.Add(num);
        }

        while (QueueSmallest.Count > 0)
        {
            int num = QueueSmallest.Dequeue();

            while(true)
            {
                if (hash.Contains(num))
                {
                    num++;
                    count++;
                }
                else
                {
                    if (count > maxCount)
                        maxCount = count;
                    count = 0;
                    break;
                }
            }
            
        }

        if (count > maxCount)
            maxCount = count;
        return maxCount;
    }

    public int LongestConsecutive2(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        int[] ArrSmallest = new int[nums.Length];
        int count = 0, maxCount = 0, smallest = nums[0], a = 0;

        ArrSmallest[a++] = smallest;
        HashSet<int> hash = new HashSet<int>();
        //List<int> list = new List<int>();
        foreach (int num in nums)
        {
            if (num < smallest)
            {
                smallest = num;
                ArrSmallest[a++] = smallest;
                //a++;
            }else if (num - smallest > nums.Length)
            {
                smallest = num;
                ArrSmallest[a++] = smallest;
                //a++;
            }

            hash.Add(num);
        }

        a = 0;
        for (int i = ArrSmallest[a]; i <= nums.Length;)
        {
            if (hash.Contains(i))
            {
                i++;
                count++;
            }
            else
            {
                if (count > maxCount)
                    maxCount = count;
                //maxCount = Math.Max(count, maxCount);
                count = 0;
                i = ArrSmallest[++a];
            }
        }
        if (count > maxCount)
            maxCount = count;
        return maxCount;
    }
    public int LongestConsecutive1(int[] nums)
    {
        if(nums.Length == 0)
            return 0;

        int count = 0, maxCount = 0, smallest = nums[0];


        List<int> list = new List<int>();
        foreach (int num in nums)
        {
            if(num < smallest)
                smallest = num;

            list.Add(num);
        }


        for(int i = smallest; i <= nums.Length; i++)
        {
            if (list.Contains(i))
                count++;
            else
            {
                if(count  > maxCount)
                    maxCount = count;
                //maxCount = Math.Max(count, maxCount);
                count = 0;
            }
        }
        if (count > maxCount)
            maxCount = count;
        return maxCount;
    }
}