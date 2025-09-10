
Solution Solution = new Solution();

Solution.GarbageCollection(new string[] { "G", "P", "GP", "GG" }, new int[] { 2, 4, 3 });
public class Solution
{
    public int GarbageCollection(string[] garbage, int[] travel)
    {
        int GTime = 0;

        int pTruck = 0, mTruck = 0, gTruck = 0;

        for (int i = 0; i < garbage.Length; i++)
        {
            string house = garbage[i];

            foreach (char type in house)
            {
                if (type == 'M')
                {
                    mTruck = i;
                }
                else if (type == 'P')
                {
                    pTruck = i;
                }
                else
                {
                    gTruck = i;
                }
                GTime++;
            }
        }

        int[] prefixTravel = new int[garbage.Length];

        for (int i = 1; i < garbage.Length; i++)
        {
            prefixTravel[i] = prefixTravel[i - 1] + travel[i - 1];
        }

        GTime += prefixTravel[mTruck] + prefixTravel[pTruck] + prefixTravel[gTruck];


        return GTime;
    }
    public int GarbageCollection_2(string[] garbage, int[] travel)
    {
        int GTime = 0;

        int pTruck = 0, mTruck = 0, gTruck = 0;

        for (int i = 0; i < garbage.Length; i++)
        {
            string house = garbage[i];

            foreach (char type in house)
            {
                if (type == 'M')
                {
                    mTruck = i;
                }
                else if (type == 'P')
                {
                    pTruck = i;
                }
                else
                {
                    gTruck = i;
                }
                GTime++;
            }
        }

        foreach (int travelTime in travel)
        {
            if (mTruck-- > 0)
                GTime += travelTime;
            if (pTruck-- > 0)
                GTime += travelTime;
            if (gTruck-- > 0)
                GTime += travelTime;
        }

        return GTime;
    }
    public int GarbageCollection_1(string[] garbage, int[] travel)
    {
        int res = 0;

        int pTime = 0, mTime = 0, gTime = 0;

        int pTruck = 0, mTruck = 0, gTruck = 0;

        //int travelTimeTillNow = 0;

        for (int i = 0; i < garbage.Length; i++)
        {
            string house = garbage[i];

            //if(i != 0)
            //    travelTimeTillNow += travel[i - 1];

            foreach (char type in house)
            {
                if (type == 'M')
                {
                    mTime++;
                    mTruck = i;
                }
                else if (type == 'P')
                {
                    pTime++;
                    pTruck = i;
                }
                else
                {
                    gTime++;
                    gTruck = i;
                }
            }
        }

        foreach (int travelTime in travel)
        {
            if (mTruck-- > 0)
                mTime += travelTime;
            if (pTruck-- > 0)
                pTime += travelTime;
            if (gTruck-- > 0)
                gTime += travelTime;

            //if (mTruck <= 0 && pTruck <= 0 && gTruck <= 0)
            //    break;
        }

        res = mTime + pTime + gTime;
        return res;
    }
}