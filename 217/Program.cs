
ContainsDuplicate(new int[] { 1, 2, 3, 1 });
bool ContainsDuplicate(int[] nums)
{

    Dictionary<int, int> keyValues = new Dictionary<int, int>();

    foreach (int num in nums)
    {
        if (keyValues.GetValueOrDefault(num) > 0)
            return true;
        keyValues[num] = keyValues.GetValueOrDefault(num) + 1;
    }
    return false;
}