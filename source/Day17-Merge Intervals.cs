public class Solution {
    public int[][] Merge(int[][] intervals) {
        HashSet<int>  overlapHashSet = new HashSet<int>();
        Comparer<int> comparer = Comparer<int>.Default;
        Array.Sort(intervals,(x, y) => comparer.Compare(x[0], y[0]));
        for(int i = 0; i < intervals.Length - 1; i ++){
            if(intervals[i][1] >= intervals[i+1][0] && 
               (intervals[i+1][1] >= intervals[i][1] ||  intervals[i+1][1] >= intervals[i][0])){
                intervals[i+1][0] = Math.Min(intervals[i][0],intervals[i+1][0]);
                intervals[i+1][1] = Math.Max(intervals[i][1],intervals[i+1][1]);
                overlapHashSet.Add(i);
            }
        }
        
        int[][] result = new int[intervals.Length - overlapHashSet.Count][];
        for(int i = 0, ri = 0; i < intervals.Length; i++){
            if(overlapHashSet.Contains(i))
                continue;
            result[ri] = intervals[i];
            ri++;
        }
        return result;
    }
}
