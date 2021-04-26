public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        int n = intervals.Length;
        if(n == 0)
            return new int[][]{newInterval};
        
        int overlapFrom = 0;
        int overlapTo = 0;
        int low = 0, high = n - 1;
        int mid = 0;
        while(low != high){
            mid = (low + high) / 2;
            if(intervals[mid][0] <= newInterval[0])
            {
                overlapFrom = mid;
                low = mid + 1;              
            }
            else
            {
                high = mid;
            }
        }
        low = 0;
        high = n - 1;
        while(low != high){
            mid = (low + high) / 2;
            if(intervals[mid][1] >= newInterval[1])
            {
                overlapTo = mid;
                high = mid;
            }
            else
            {
                low = mid + 1;
            }
        }
        if(intervals[overlapTo][1] <= newInterval[1])
            intervals[overlapTo][1] = newInterval[1];
        else if (intervals[overlapTo][0] >= newInterval[1])
            intervals[overlapTo][0] = newInterval[1];
        
        if(intervals[overlapFrom][0] >= newInterval[0])
            intervals[overlapFrom][0] = newInterval[0];
        else if(intervals[overlapFrom][1] <= newInterval[0])
            intervals[overlapFrom][1] = newInterval[0];
        
        int skipCount = overlapTo - overlapFrom - 1;
        skipCount = skipCount > 0 ? skipCount : 0;
        
        Console.WriteLine(overlapFrom);
        Console.WriteLine(overlapTo);

        int[][] result = new int[n-skipCount][];
        for(int i = 0, index = 0; i < n ; i++){
            if(i > overlapFrom && i < overlapTo)
                continue;
            result[index] = intervals[i];
            index++;
        }
        return result;
    }
}
