using System;

Solution n = new Solution();
n.reverseBits(011);
public class Solution
{
    public int reverseBits(int n)
    {
        int reversed = 0;

        for (int i = 0; i < 32; i++)
        {
            reversed <<= 1;

            int lastBit = n & 1;

            reversed |= lastBit;

            n >>= 1;
        }

        return reversed;
    }
}
