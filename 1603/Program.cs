public class ParkingSystem
{
    int[] arr = new int[3];
    public ParkingSystem(int big, int medium, int small)
    {
        arr[0] = big;
        arr[1] = medium;
        arr[2] = small;
    }

    public bool AddCar(int carType)
    {
        arr[carType - 1]--;

        if(arr[carType - 1] < 0)
            return false;

        return true;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */

public class ParkingSystem1
{
    int bigCount, mediumCount, smallCount;
    public ParkingSystem1(int big, int medium, int small)
    {
        bigCount = big;
        mediumCount = medium;
        smallCount = small;
    }

    public bool AddCar(int carType)
    {
        if (carType == 1)
        {
            if (--bigCount < 0)
                return false;
        }
        else if (carType == 2)
        {
            if (--mediumCount < 0)
                return false;
        }
        else
        {
            if (--smallCount < 0)
                return false;
        }

        return true;
    }
}


/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */