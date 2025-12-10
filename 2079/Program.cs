public class Solution
{
    public int WateringPlants(int[] plants, int capacity)
    {
        int waterInCan = capacity;
        int steps = 0;

        for (int i = 0; i < plants.Length; i++)
        {
            if (waterInCan < plants[i])
            {
                // i to go back and 1 to come back and 1 to actually go n water or move to current plant index
                steps += (i + i + 1);
                waterInCan = capacity - plants[i];
            }
            else
            {
                steps++;
                waterInCan -= plants[i];
            }
        }

        return steps;
    }
}