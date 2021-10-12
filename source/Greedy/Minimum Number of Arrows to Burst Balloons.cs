public class Solution {
    public int FindMinArrowShots(int[][] points) {
        Array.Sort(points, Comparer<int[]>.Create((a, b) =>
        {
            return a[0].CompareTo(b[0]);
        }));
        var result = 1;
        if(points.Length < 2)
            return result;
        for(int i = 1; i < points.Length; i++){
            if(points[i][0] > points[i-1][1]){
                result++;
            }
            else{
                points[i][1] = Math.Min(points[i][1], points[i-1][1]);
            }
        }
        return result;
    }
}
