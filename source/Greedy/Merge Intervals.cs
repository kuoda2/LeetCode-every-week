public class Solution {
    public int[][] Merge(int[][] intervals) {
        Stack<int[]> stack = new Stack<int[]>();
        Array.Sort(intervals,(x, y) => x[0] == y[0] ? x[1] - y[1] : x[0] - y[0]);
        stack.Push(intervals[0]);
        for(int i = 1; i < intervals.Length; i ++){
            var lastStart = stack.Peek()[0];
            var lastEnd = stack.Peek()[1];
            if(lastEnd - intervals[i][0] >= 0 ){
                var min = Math.Min(lastStart, intervals[i][0]);
                var max = Math.Max(lastEnd, intervals[i][1]);
                stack.Pop();
                stack.Push(new []{min, max});
            }
            else{
                stack.Push(intervals[i]);
            }
        }
        var list = stack.ToList();
        list.Reverse();
        var result = list.ToArray();
        return result;
    }
}
