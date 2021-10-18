public class Solution {
    public int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) =>
        {
            return (a[0] == b[0]) ? (a[1] - b[1]) : (a[0] - b[0]);
        });
        var result = 0;
        var currentIndex = 0;
        for(int i = 1; i < intervals.Length; i++){
            if(intervals[i][0] < intervals[currentIndex][1]){
                result++;
                // 重疊時，取end小的Index
                currentIndex = intervals[currentIndex][1] > intervals[i][1] ? i : currentIndex;
            }
            else{
                currentIndex = i;
            }
        }
        return result;
    }
}
