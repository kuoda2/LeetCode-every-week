public class Solution {
    public int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) =>
        {
            return (a[0] == b[0]) ? (a[1] - b[1]) : (a[0] - b[0]);
        });

        int result = 0, currIndex = 0;
        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] < intervals[currIndex][1])
            {
                result++;
                currIndex = (intervals[i][1] < intervals[currIndex][1] ? i : currIndex);
            }
            else
            {
                currIndex = i;
            }
        }

        return result;
    }
}
