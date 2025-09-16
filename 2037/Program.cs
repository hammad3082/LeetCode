Solution sol = new Solution();

sol.MinMovesToSeat(new int[] { 3, 1, 5 }, new int[] { 2, 7, 4 });

public class Solution
{
    public int MinMovesToSeat(int[] seats, int[] students)
    {
        int moves = 0;

        Array.Sort(seats);
        Array.Sort(students);

        for(int i = 0; i< seats.Length; i++)
        {
            if (seats[i] != students[i])
                moves += Math.Abs(seats[i] - students[i]);
        }

        return moves;
    }
}